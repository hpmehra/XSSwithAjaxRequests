using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XSS_with_Ajax_Requests.Models;



namespace XSS_with_Ajax_Requests.Controllers
{
    [FilterConfig.ValidateAntiForgeryTokenOnAllPosts]
    public class EmployeeController : Controller
    {

        public class UsersContext : DbContext
        {
            public UsersContext()
                : base("DefaultConnection")
            {
            }

            public DbSet<Employee> Employee { get; set; }
        }


        public ActionResult Insert()
        {
            return View();
        }


        public ActionResult SaveData(string name, float salary)
        {
            UsersContext usrContext = new UsersContext();
            Employee emp = new Employee();
            emp.Name = name;
            emp.Salary = salary;
            usrContext.Employee.Add(emp);
            usrContext.SaveChanges();
            return Json("Successfull", JsonRequestBehavior.AllowGet);
        }

    }
}
