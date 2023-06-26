using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagAndViewData.Models;
namespace ViewBagAndViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()// all about ViewBag
        {
            // diclaeartions about ViewBag
            ViewBag.MyCustomPropert = "Sohanur Rahman";
            ViewBag.MyList = new List<string>() { "john","shon","kohn"};
            int[] arr = {1 , 2 , 4};
            ViewBag.Myarry= arr;

            // list for the employee model
            List<Employee> empList = new List<Employee>()
            {
                new Employee(){EmployeeName = "jon", EmployeeId=1, EmployeeEmail="S@gmail.com"},
                new Employee(){EmployeeName = "jodfsdfn", EmployeeId=2, EmployeeEmail="a@gmail.com"},
                new Employee(){EmployeeName = "jonaf", EmployeeId=3, EmployeeEmail="gds@gmail.com"},
                new Employee(){EmployeeName = "jo23rn", EmployeeId=4, EmployeeEmail="Sgagk@gmail.com"}
            };
            ViewBag.MyEmpList = empList;

            return View();
        }
   
        public ActionResult About() // all about ViewData
        {
            //way to diclaer ViewData
            ViewData["MyKey"] = "This is value for My key";
            ViewData["MyList"] = new List<string>() { "john", "shon", "kohn" };
            return View();
        }
    }
}
