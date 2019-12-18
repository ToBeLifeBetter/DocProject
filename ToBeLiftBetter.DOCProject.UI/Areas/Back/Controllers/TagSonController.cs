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
    public class TagSonController : Controller
    {
        public TagSonService tagSonSer;

        public TagSonController()
        {
            tagSonSer = new TagSonService();
        }

        // GET: TagFather  
        [HttpGet]
        public ActionResult Index()
        {
            ViewData.Model = tagSonSer.GetEntities(model => model.IsDelete==0);
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MainContentListTagSon tagSon)
        {
            tagSon.CreateTime = DateTime.Now;
            tagSon.IsDelete = 0;
            tagSon.IsUpadte = 1;
            tagSonSer.AddEntity(tagSon);
            tagSonSer.SaveChange();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(MainContentListTagSon tagSon)
        {
            //tagSonSer.DeleteEntity(tagSon);
            tagSon.IsDelete = 1;
            tagSonSer.UpdateEntity(tagSon);
            tagSonSer.SaveChange();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewData.Model = tagSonSer.GetEntities(model => model.Id == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Edit(MainContentListTagSon tagSon)
        {
            tagSonSer.UpdateEntity(tagSon);
            tagSonSer.SaveChange();
            return RedirectToAction("Index");
        }

    }
}