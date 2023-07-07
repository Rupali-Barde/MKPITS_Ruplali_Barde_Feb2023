using DropDownEx2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DropDownEx2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details()
        {
            bindCategory();
            return View();
        }

        public void bindCategory()
        {
            DataModel1 modelDemo = new DataModel1();
            var tblcategory = modelDemo.tblCategories.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "--Select Category--", Value = "0" });

            foreach (var m in tblcategory)
            {


                li.Add(new SelectListItem { Text = m.catname, Value = m.catid.ToString() });
                ViewBag.category = li;

            }
        }




    }
}