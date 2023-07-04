using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassDataViewToController.Models;
namespace PassDataViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //value will come from the view as paremeter
        //1st way-data pass using perimitter
        public string PostUsingPerimiter(string FirstName, string LastName)
        {
            //it will return on on the next page
                             //Note: speling must match with view paremeter
            return "From paremeters - "+FirstName+" "+LastName;
        }
        [HttpPost]
        //2nd way - data pass with request
        public string PostUsingRequest()
        {
            string FirstName = Request["FirstName"];//speling
            string LastName = Request["LastName"];
            return "From UsingRequest - " + FirstName+" "+LastName;
        }
        [HttpPost]
        //3rd way - data pass using FormCollection
        public string PostUsingFormCollection(FormCollection form)
        {
            string FirstName = form["FirstName"];
            string LastName = form["LastName"];
            return "From FormCollection - " +FirstName +" "+LastName;
        }
        //4th way - data pass using StronglyBinding
        [HttpPost]
        public string PostUsingBinding(Employee emp)
        {
            return "From FormBinding - " + emp.FirstName +" "+emp.LastName;
        }
    }
}
