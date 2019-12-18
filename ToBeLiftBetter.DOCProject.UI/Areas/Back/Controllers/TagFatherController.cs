using DataEntity.EntityModel;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ToBeLiftBetter.DOCProject.UI.Areas.Back
{
    /// <summary>
    /// 后台管理控制器之--主内容列表大模块名称
    /// </summary>
    public class TagFatherController : Controller
    {
        public TagFatherSerivce tagFatherSer;

        public TagFatherController()
        {
            tagFatherSer = new TagFatherSerivce();
        }

        // GET: TagFather  
        [HttpGet]
        public ActionResult Index()
        {
          ViewData.Model =  tagFatherSer.GetEntities(model=> model.IsDelete==0);

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MainContentListTagFather tagFather)
        {
            tagFather.IsUpadte = 1;
            tagFather.IsDelete = 0;
            tagFather.CreateTime = DateTime.Now;
            tagFatherSer.AddEntity(tagFather);
            tagFatherSer.SaveChange();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(MainContentListTagFather tagFather)
        {
            //tagFatherSer.DeleteEntity(tagFather);
            tagFather.IsDelete = 1;
            tagFatherSer.UpdateEntity(tagFather);
            tagFatherSer.SaveChange();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            
            ViewData.Model = tagFatherSer.GetEntities(model => model.Id ==id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Edit(MainContentListTagFather tagFather)
        {
            tagFatherSer.UpdateEntity(tagFather);
            tagFatherSer.SaveChange();

            return RedirectToAction("Index");
        }

    }
}