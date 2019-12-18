using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToBeLiftBetter.DOCProject.UI.Controllers
{
    public class DocumentListController : Controller
    {
        // GET: DocumentList
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DocPage() 
        {
            if (Request.QueryString.Count ==0)
            {
                return RedirectToAction("Index");
            }
              string aa=       Request.QueryString[0].ToString();

            Dictionary<string, string> taglist = new Dictionary<string, string>();
            for (int i = 1; i <=5; i++) 
            {
                taglist["section-" + i] = "第" + i + "部分";
            }
          
            ViewBag.list = taglist;



            ViewData.Model = aa;
            return View();
        }
    }
}