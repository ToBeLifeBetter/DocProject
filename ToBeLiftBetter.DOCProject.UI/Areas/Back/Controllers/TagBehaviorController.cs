using DataEntity.EntityModel;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToBeLiftBetter.DOCProject.UI.Areas.Back.Controllers
{

    /// <summary>
    /// 后台管理控制器之--大模块下的子模块名称
    /// </summary>
    public class TagBehaviorController : Controller
    {
        public TagBehaviorService tagBehaviorSer;

        public TagBehaviorController()
        {
            tagBehaviorSer = new TagBehaviorService();
        }

        // GET: TagFather  
        [HttpGet]
        public ActionResult Index()
        {
            ViewData.Model = tagBehaviorSer.GetEntities(model => model.IsDelete==0);
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MainContentListTagBehavior tagBehavior)
        {
            tagBehavior.CreateTime = DateTime.Now;
            tagBehavior.IsDelete = 0;
            tagBehavior.IsUpadte = 1;
            tagBehaviorSer.AddEntity(tagBehavior);
            tagBehaviorSer.SaveChange();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(MainContentListTagBehavior tagBehavior)
        {
            //tagBehaviorSer.DeleteEntity(tagBehavior);
            tagBehavior.IsDelete = 1;
            tagBehaviorSer.UpdateEntity(tagBehavior);
            tagBehaviorSer.SaveChange();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewData.Model = tagBehaviorSer.GetEntities(model => model.Id == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Edit(MainContentListTagBehavior tagBehavior)
        {
            tagBehaviorSer.UpdateEntity(tagBehavior);
            tagBehaviorSer.SaveChange();
            return RedirectToAction("Index");
        }

    }
}