﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataEntity.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestForDocProjectEntities : DbContext
    {
        public TestForDocProjectEntities()
            : base("name=TestForDocProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MainContentListShowCode> MainContentListShowCode { get; set; }
        public virtual DbSet<MainContentListTagBehavior> MainContentListTagBehavior { get; set; }
        public virtual DbSet<MainContentListTagFather> MainContentListTagFather { get; set; }
        public virtual DbSet<MainContentListTagSon> MainContentListTagSon { get; set; }
    }
}