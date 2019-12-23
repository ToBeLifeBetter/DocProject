using DataEntity.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{


    /// <summary>
    /// 标签列表总类
    /// </summary>
    public class TagContentListModel
    {
        public int id { get; set; }
        /// <summary>
        /// 模块标签名
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 内容标签Url地址
        /// </summary>
        public string href { get; set; }
        public bool spread { get; set; }
        /// <summary>
        /// 内容标签集合
        /// </summary>
        public List<TagContentSonListModel> children { get; set; }
        public int level {get;set;}
        public int fatherId { get; set; }

    }

    /// <summary>
    /// 内容标签类
    /// </summary>
    public class TagContentSonListModel
    {
        public int id { get; set; }
        /// <summary>
        /// 内容标签名
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 内容标签Url地址
        /// </summary>
        public string href { get; set; }

        public bool spread { get; set; }
        
        /// <summary>
        ///行为标签集合
        /// </summary>
        public List<TagBehaviorListModel> children { get; set; }
        public int level { get; set; }
        public int fatherId { get; set; }
    }


    /// <summary>
    /// 行为标签类
    /// </summary>
    public class TagBehaviorListModel 
    {

        public int id { get; set; }

        /// <summary>
        /// 行为标签名
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 行为标签Url地址
        /// </summary>
        public string href { get; set; }
        //所属级别
        public int level { get; set; }
        public int  fatherId { get; set; }

    }





}
