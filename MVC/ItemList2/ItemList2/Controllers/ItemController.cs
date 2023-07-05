using ItemList2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItemList2.Controllers
{
    public class ItemController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ItemModel ilist)
        {
            
                if(ModelState.IsValid)
                {
                    ItemDBHandler ItemHandler = new ItemDBHandler();
                    if(ItemHandler.InsertItem(ilist))
                    {
                        ViewBag.Message = "Item Added Successfully";
                        ModelState.Clear();
                    }
                }

                return View();
            
        }




        //GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List page";
            ItemDBHandler itemDBHandler = new ItemDBHandler();
            ModelState.Clear();
            return View(itemDBHandler.GetItemList());
            //return View();
        }

       // Update Item Details
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            ItemDBHandler ItemHandler = new ItemDBHandler();
            return View(ItemHandler.GetItemList().Find(m => m.ID == ID));

        }
        [HttpPost]
        public ActionResult Edit(int ID, ItemModel ilist)
        {
            try
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                ItemHandler.UpdateItem(ilist);
                return RedirectToAction("index");
            }
            catch
            {
                return View(ilist);
            }
        }

        public ActionResult Delete(int ID)
        {
            try
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                if (ItemHandler.DeleteItem(ID))
                {
                    ViewBag.AlertMsg = "Item Deleted Successfully";

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }


}