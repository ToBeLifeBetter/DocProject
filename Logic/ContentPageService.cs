using DataEntity.EntityModel;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// 生成菜单实体类
    /// </summary>
    public class ContentPageService
    {
        private TagFatherSerivce tagFather = new TagFatherSerivce();

        private TagSonService tagSon = new TagSonService();

        private TagBehaviorService tagBehavior = new TagBehaviorService();
        /// <summary>
        /// <summary>
        /// 根据专题Id 获取子模块名称
        /// </summary>
        public List<TagContentListModel> GetSectionTitle(int fatherid)
        {
            //标签列表总类
            List<TagContentListModel> tagContentListModelList = new List<TagContentListModel>();
            //内容标签类
            List<TagContentSonListModel> tagContentSonListModelList = new List<TagContentSonListModel>();
            //行为标签类
            List<TagBehaviorListModel> tagBehaviorListModelList = new List<TagBehaviorListModel>();

            //所有模块
            IQueryable<MainContentListTagFather> tagFatherModel = tagFather.GetEntities(model => model.FatherId == fatherid);
            //某个模块下的内容Model集合
            IQueryable<MainContentListTagSon> tagSonModel = null;
            //获取行为Model集合
            List<MainContentListTagBehavior> mainContentListTagBehaviors = tagBehavior.GetEntities(model => true).ToList();
            int thrid = 1001;
            int second = 101;
            int first = 1;
            foreach (var item in mainContentListTagBehaviors)
            {
                var tagBehaviorListModel = new TagBehaviorListModel
                {
                    title = item.Name,
                    href = item.UrlName,
                    id = thrid++,
                    level=3,
                      fatherId = second
                };
                tagBehaviorListModelList.Add(tagBehaviorListModel);
            }

        
            if (tagFatherModel.Count() > 0)
            {
                //遍历所有模块
                foreach (MainContentListTagFather item in tagFatherModel)
                {
                    //某模块的所有内容集合
                    tagSonModel = tagSon.GetEntities(model => model.ContentListTagFatherId == item.Id);
                    //给每一个内容集合添加行为
                    foreach (MainContentListTagSon sonitem in tagSonModel)
                    {
                        var tagContentSonListModel = new TagContentSonListModel
                        {
                            title = sonitem.Name,
                            href = sonitem.UrlName,
                            children = tagBehaviorListModelList,
                            id = second++,
                            level=2,
                            fatherId=first
                        };
                        if (second == 102)
                            tagContentSonListModel.spread = true;
                        else
                            tagContentSonListModel.spread = false;

                        tagContentSonListModelList.Add(tagContentSonListModel);
                    }
                    var tagContentListModel = new TagContentListModel
                    {
                        title = item.Name,
                        href = item.UrlName,
                        children = tagContentSonListModelList.GetRange(0, tagContentSonListModelList.Count),
                        id=first++,
                        level=1
                    };
                    if(first==2)
                    tagContentListModel.spread = true;
                    else
                    tagContentListModel.spread = false;

                    tagContentListModelList.Add(tagContentListModel);
                    tagContentSonListModelList.Clear();
                }

            }
            return tagContentListModelList;


        }


        //根据获取的Id进行相关的数据菜单展示数据生成
        public void WriteMenuData(string path) 
        {
            

        }

    }
}
