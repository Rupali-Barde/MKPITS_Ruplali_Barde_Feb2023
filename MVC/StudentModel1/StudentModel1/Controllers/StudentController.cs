using StudentModel1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentModel1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.StudentModel = "All Student In Class";
            StudentHandler Handler = new StudentHandler();
            ModelState.Clear();
            return View(Handler.GetRecords());
            //return View();
        }
        // Insert Record Into Table
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel ilist)
        {
            if (ModelState.IsValid)
            {
                StudentHandler studHandler = new StudentHandler();
                if (studHandler.InsertRecord(ilist))
                {
                    ViewBag.Message = "Record Inserted Successfully";
                    ModelState.Clear();

                }
            }
            return View();
        }

        //Update Records In StudentModel
        [HttpGet]
        public ActionResult Edit(int ID) 
        {
            StudentHandler studHandler = new StudentHandler();
            return View(studHandler.GetRecords().Find(m => m.ID == ID));

        }
        [HttpPost]
        public ActionResult Edit( int ID,StudentModel ilist) 
        {
            try
            {
                StudentHandler studHandler = new StudentHandler();
                studHandler.UpdateRecord(ilist);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //Delete Records From StudentModel
        public ActionResult Delete(int ID) 
        {
            try
            {
                StudentHandler studHandler = new StudentHandler();
                if(studHandler.DeleteRecord(ID))
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
        public ActionResult Details(int ID)
        {
            StudentHandler studHandler = new StudentHandler();
            return View(studHandler.GetRecords().Find(m=>m.ID==ID));
        }
    }
    
}