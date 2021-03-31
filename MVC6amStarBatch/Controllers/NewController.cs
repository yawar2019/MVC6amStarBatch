using MVC6amStarBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6amStarBatch.Controllers
{
    //commented
    [RoutePrefix("Hyderabad")]
    public class NewController : Controller
    {
        // GET: New
        public string  Index()
        {
            return "happy birthday to divya and anjum";
        }
        public int Index2()
        {
            return 12;
        }

        public string index3(int? EmpId)
        {

            return "hwllo world this is my id:"+ EmpId;
        }

        public string index4(int? id,string Name)
        {

            return "hello world this is my id:" + id+" Name is "+Name;
        }

        [Route("AnnaBandi/Dosa")]
        [Route("AnnaBandi/Idli")]
        [Route("AnnaBandi/wada")]
        [Route("AnnaBandi/ookma/{id}")]
        public ActionResult TestAttribute(int? id)
        {
            ViewBag.Name = 1211;
            return View();
        }
        public ActionResult SendObject()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shaik";
            obj.EmpSalary = 90000;


            ViewBag.info = obj;

            return View();
        }

        public ActionResult SendMultipleObject()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shaik";
            obj.EmpSalary = 90000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 290000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 1213;
            obj2.EmpName = "Anjum";
            obj2.EmpSalary = 390000;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1214;
            obj3.EmpName = "vasantha";
            obj3.EmpSalary = 490000;


            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);
            listObj.Add(obj3);


            ViewBag.info = listObj;

            return View();
        }

        public ActionResult SendObjectViewModel()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shaik";
            obj.EmpSalary = 90000;

            return View(obj);
        }

        public ActionResult SendMultipleObjectViewModel()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shaik";
            obj.EmpSalary = 90000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 290000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 1213;
            obj2.EmpName = "Anjum";
            obj2.EmpSalary = 390000;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1214;
            obj3.EmpName = "vasantha";
            obj3.EmpSalary = 490000;


            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);
            listObj.Add(obj3);

            return View(listObj);
        }

        public ActionResult SendMultipleModel()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shaik";
            obj.EmpSalary = 90000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 290000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 1213;
            obj2.EmpName = "Anjum";
            obj2.EmpSalary = 390000;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1214;
            obj3.EmpName = "vasantha";
            obj3.EmpSalary = 490000;


            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);
            listObj.Add(obj3);


            //////////////////////////////////////////////


            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Marketing";


            List<DepartmentModel> listdeptObj = new List<DepartmentModel>();
            listdeptObj.Add(dept);
            listdeptObj.Add(dept1);

            EmpDeptModel  objcombo = new Models.EmpDeptModel();
            objcombo.emp = listObj;
            objcombo.dept = listdeptObj;



            return View(objcombo);
        }

        public ActionResult ShowEmployee(int? id)
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shaik";
            obj.EmpSalary = 90000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 290000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 1213;
            obj2.EmpName = "Anjum";
            obj2.EmpSalary = 390000;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1214;
            obj3.EmpName = "vasantha";
            obj3.EmpSalary = 490000;


            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);
            listObj.Add(obj3);


            EmployeeModel emp = listObj.Where(s => s.EmpId == id).FirstOrDefault();

            return View(emp);
        }
    }
}