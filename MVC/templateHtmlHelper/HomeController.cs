using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using TemplateHtmlHelper.Models;

namespace TemplateHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                EmployeeName = "Sohanur Rahman",
                EmployeeId = 21303125,
                EmployeeEmail = "Sohanurr791@gmail.com",
                DateOfBirth = DateTime.Now,
                IsOnline = true
            };
            return View(emp);
            //return View();
        }
        public ViewResult Edit()
        {
            return View();
        }
        //must need to override the function
        [HttpPost] // it convert the edit method to showing the input data
        public ViewResult Edit(Employee emp)
        {
            return View(emp);
        }

    }
}
