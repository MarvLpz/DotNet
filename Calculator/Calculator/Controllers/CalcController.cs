using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    //https://www.youtube.com/watch?v=oQV1LYXwahM
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }
        [HttpPost]
        public ActionResult Index(calc c, string calculate)
        {
            if (calculate == "add")
            {
                c.total = c.no1 + c.no2;
            }
            else if (calculate == "min")
            {
                c.total = c.no1 - c.no2;
            }
            else if (calculate == "sub")
            {
                c.total = c.no1 * c.no2;
            }
            else if (calculate == "divv")
            {
                c.total = c.no1 / c.no2;
            }
            return View(c);
        }
    }
}