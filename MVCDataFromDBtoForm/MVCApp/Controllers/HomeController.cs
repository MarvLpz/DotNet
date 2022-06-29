using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using DataLibrary_NonCore;
using static DataLibrary_NonCore.BusinessLogic.EmployeeProcessor; //to access static methods in EmployeeProcessor

//https://www.youtube.com/watch?v=bIiEv__QNxw&t=2635s
namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sign Up";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//what's this??
        public ActionResult SignUp(EmployeeModel model) {
            if (ModelState.IsValid) { //if it complies with the dataanotations attributes []

                int recordsCreated = CreateEmployee(model.EmployeeId,
                    model.FirstName,
                    model.LastName,
                    model.EmailAddress);
                    return RedirectToAction("Index");
            }
            return View();
        }
    }
}