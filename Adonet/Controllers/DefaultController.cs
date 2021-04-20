using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Adonet.Models;
namespace Adonet.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.GetEmployees());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel e)
        {
            int i = db.saveEmployee(e);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
            
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel e)
        {
            int i = db.EditEmployee(e);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.Delete(id);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }

        }

        public ActionResult HtmlHelper() {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpName = "Anjum";
            return View(obj);
        }
    }
}