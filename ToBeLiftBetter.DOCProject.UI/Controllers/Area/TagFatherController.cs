using DataEntity.EntityModel;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToBeLiftBetter.DOCProject.UI.Controllers.Area
{
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
          ViewData.Model =  tagFatherSer.GetEntities(model=>true);

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
            tagFatherSer.DeleteEntity(tagFather);
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