using Common.Helper;
using DataModel;
using Logic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToBeLiftBetter.DOCProject.UI.Controllers
{
    public class DocumentListController : Controller
    {

        ContentPageService contentPageService = new ContentPageService();

        // GET: DocumentList
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 知道获取的是哪个页面
        /// </summary>
        /// <returns></returns>
        public ActionResult DocPage() 
        {
            //根据fatherId进行数据菜单加载

            int id=0, level=0, fatherid=0;
            for (int i = 0; i < Request.QueryString.Count; i++)
            {
                if (i == 1) 
                {
                    id = Convert.ToInt32(Request.QueryString[1]);
                }
                if (i == 2) 
                {
                    level= Convert.ToInt32(Request.QueryString[2]);
                }
                if (i == 3) 
                {
                    fatherid =Convert.ToInt32(Request.QueryString[3]);
                }
            }

            if (Request.QueryString.Count ==0)
            {
                return RedirectToAction("Index");
            }
              string aa = Request.QueryString[0].ToString();

            List<TagContentListModel> page = Session["menudata"]  as List<TagContentListModel>;
            string jsonvalue = JsonConvert.SerializeObject(page, Formatting.Indented);
          

            Dictionary<string, string> taglist = new Dictionary<string, string>();
            for (int i = 1; i <=5; i++) 
            {
                taglist["section-" + i] = "第" + i + "部分";
            }
          
            ViewBag.list = taglist;
            ViewBag.LeftList = jsonvalue;
            ViewBag.id = id;
            ViewBag.level = level;
            ViewBag.fatherid = fatherid;
            ViewData.Model = aa;
            return View();
        }


        public ActionResult FirstDocPage()
        {
            //根据fatherId进行数据菜单加载
            int FatherId = Convert.ToInt32(Request.QueryString[0]) ;

            var page = contentPageService.GetSectionTitle(FatherId);

            string jsonvalue = JsonConvert.SerializeObject(page, Formatting.Indented);
            Session["menudata"] = page;
            //TagJsonList tagJsonList = new TagJsonList();
            //string str =     tagJsonList.GetJson(page);
            if (Request.QueryString.Count == 0)
            {
                return RedirectToAction("Index");
            }

           

            Dictionary<string, string> taglist = new Dictionary<string, string>();
            for (int i = 1; i <= 5; i++)
            {
                taglist["section-" + i] = "第" + i + "部分";
            }

            ViewBag.list = taglist;



            ViewData.Model = FatherId;


            ViewData.Model = FatherId;
            ViewBag.LeftList = jsonvalue;

            return View();
        }


        // GET: DocumentList
        public ActionResult MyVideo()
        {
            return View();
        }
    }
}