using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageDemo.Filters;
using ImageDemo.Models;

namespace ImageDemo.Controllers
{
    public class StudentsController : Controller
    {
        public static List<Student> students=new List<Student>();
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(StudentsController));

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "example", "data" };
        }
        // GET: StudentsController
        public ActionResult Index()
        {
            _log4net.Info("Index method called");
            ViewBag.quantity = TempData["qty"];
            return View(students) ;
        }

        // GET: StudentsController/Details/5
        
        public ActionResult Details(int id)
        {
            _log4net.Info("Details method with id: " + id + " was called");
            return View();
        }

        // GET: StudentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
     //   [ServiceFilter(typeof(CustomActionFilter))]
        public ActionResult Create(Student S)
        {
            _log4net.Info("Student Name of " + S.StudentName + " is Added to the list");
            if (ModelState.IsValid)
            {
                try
                {
                    students.Add(S);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: StudentsController/Edit/5
      //  [ServiceFilter(typeof(CustomActionFilter))]
        public ActionResult Edit(int id)
        {
            _log4net.Info("Edit method with id: " + id + " was called");
            return View();
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            Student s=students.Where(i => i.Sid == id).FirstOrDefault();
            return View(s);
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _log4net.Info("Record with id: " + id + " was Deleted");
            try
            {
                Student s = students.Where(i => i.Sid == id).FirstOrDefault();
                if (s != null)
                {
                    students.Remove(s);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    throw new("Record not found");
                }
            }
            catch(Exception e)
            {
                _log4net.Error(e.Message);
                return View();
            }
        }

        public ActionResult GetQty()
        {
            _log4net.Info("GetQty method was called");
            return View();
        }

        [HttpPost]
        public ActionResult GetQty(IFormCollection f)
        {
            _log4net.Info("Value of Qty " + f["qty"].ToString() + " was sent by user");
            TempData["qty"] = Convert.ToInt32(f["qty"]);
            return RedirectToAction("index");

        }

    }
}
