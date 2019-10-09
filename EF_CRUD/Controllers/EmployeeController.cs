using EF_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EF_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            db.EmployeeTable.ToList();
            db.EmployeeSalary.ToList();
            return View(db.EmployeeTable.ToList());
        }
      
        public ActionResult ViewById(int id)
        {
            EmployeeModel employeeDetail=db.EmployeeTable.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(employeeDetail);
        }

        public ActionResult Delete(int id)
        {

            EmployeeModel employeeDetail = db.EmployeeTable.Where(x => x.EmployeeId == id).SingleOrDefault();
            db.EmployeeTable.Remove(employeeDetail);
            db.SaveChanges();
            return RedirectToAction("/Index");          
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(EmployeeModel employeeDetail)
        {
            db.EmployeeTable.Add(employeeDetail);
            db.SaveChanges();

            return RedirectToAction("/Index");
        }

        public ActionResult Update(int id)
        {
            EmployeeModel currentDetail = db.EmployeeTable.Where(x => x.EmployeeId == id).SingleOrDefault();
            return View(currentDetail);
        }

        [HttpPost]
        public ActionResult Update(EmployeeModel employeeDetail)
        {

            EmployeeModel currentDetail = db.EmployeeTable.Where(x => x.EmployeeId == employeeDetail.EmployeeId).SingleOrDefault();
            if(currentDetail!=null)
            {

                db.Entry(currentDetail).CurrentValues.SetValues(employeeDetail);
                db.SaveChanges();
            }
            return RedirectToAction("/Index");
        }

    }
}