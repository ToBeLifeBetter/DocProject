using DataEntity.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class BaseService<TModel> where TModel : class, new()
    {


        DbContext Db
            {
                get
                {
                DbContext db = CallContext.GetData("DbContext") as DbContext;
                if (db == null) 
                {
                    db = new TestForDocProjectEntities();
                    CallContext.SetData("DbContext", db);
                }
                return db;
                }
            }

        public int SaveChange()
        {
            return Db.SaveChanges();
        }
      


        #region 查询
        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <param name="whereExpression">查询条件 例如查询所有：m=>m</param>
        /// <returns></returns>
        public IQueryable<TModel> GetEntities(Expression<Func<TModel, bool>> whereExpression)
            {

                return Db.Set<TModel>().Where(whereExpression).AsQueryable();

            }

            /// <summary>
            /// 分页查询
            /// </summary>
            /// <typeparam name="TResult">查询的数据实体</typeparam>
            /// <param name="pageSize">一页数据条数</param>
            /// <param name="currentPage">当前页</param>
            /// <param name="totalCount">数据总数</param>
            /// <param name="whereExpression">条件查询的条件</param>
            /// <param name="orderExpression">排序条件</param>
            /// <param name="isAsc">是否升序排序</param>
            public IQueryable<TModel> GetEntitiesByPaging<TResult>(int pageSize, int currentPage, out int totalCount, Expression<Func<TModel, bool>> whereExpression, Expression<Func<TModel, TResult>> orderExpression, bool isAsc)
            {
                totalCount = Db.Set<TModel>().Count();

                if (isAsc)
                {
                    //升序
                    var temp = Db.Set<TModel>().Where(whereExpression)
                                                                         .OrderBy(orderExpression)
                                                                         .Skip(pageSize * (currentPage - 1))
                                                                         .Take(pageSize).AsQueryable();
                    return temp;
                }
                else
                {
                    //降序
                    var temp = Db.Set<TModel>().Where(whereExpression)
                                                                    .OrderByDescending(orderExpression)
                                                                    .Skip(pageSize * (currentPage - 1))
                                                                    .Take(pageSize).AsQueryable();
                    return temp;
                }
            }
            #endregion 查询


            #region 添加
            public TModel AddEntity(TModel entity)
            {
                Db.Set<TModel>().Add(entity);
                //  Db.SaveChanges();
                //添加成功后，主键有值了，如果主键是自动增长得话
                return entity;
            }
            #endregion 添加

            #region 修改
            public bool UpdateEntity(TModel entity)
            {
                //修改某一个属性用Attach，整个修改可以不用

                //   Db.UserInfoSet.Attach(user);
                Db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                return true;//Db.SaveChanges() > 0;

            }
            #endregion 删除

            #region 删除
            public bool DeleteEntity(TModel entity)
            {

                Db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                return true;// Db.SaveChanges() > 0;

            }
            #endregion 删除
        }
    }
