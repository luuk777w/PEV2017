using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PEV.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //paardenrace radvanfortuin

        public IActionResult Roulette()
        {
            return View();
        }

        public IActionResult Radvanfortuin()
        {
            return View();
        }

        public IActionResult Paardenrace()
        {
            return View();
        }
    }
}