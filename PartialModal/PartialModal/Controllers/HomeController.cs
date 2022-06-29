using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialModal.Models;
namespace PartialModal.Controllers
{
    public class HomeController : Controller
    {
        List<Pokemon> Pokemons = new List<Pokemon>() {
            new Pokemon() { PName = "Charizard",PLevel = 60, PType = "Fire Flying" },
            new Pokemon() { PName = "Blastoise",PLevel = 60, PType = "Water" },
            new Pokemon() { PName = "Venusaur",PLevel = 60, PType = "Grass Poison" }
        };
        public ActionResult Main()
        {
            return View(Pokemons);
        }

        public ActionResult Main_1()
        {
            return PartialView();
        }
        public ActionResult Main_2()
        {
            return PartialView();
        }
    }
}