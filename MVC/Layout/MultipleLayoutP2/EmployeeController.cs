using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiLayout.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("Employees")]
        public ActionResult GetEmp()
        {
            //calling the _NewLayout
            return View("GetEmp","_NewLayout");
        }

        [Route("viewemp")]
        public ActionResult ShowEmp()
        {
            return View("ShowEmp","_Layout");
        }
    }
}
