using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using PEV.Models;

namespace PEV.Controllers
{
    public class PaardenraceController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public PaardenraceController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int inzet, string paard)
        {

            using (var db = new ApplicationDbContext())
            {
                Paardenrace race = new Paardenrace
                {
                    userid = _userManager.GetUserId(HttpContext.User),
                    gameid = 1,
                    inzet = inzet,
                    paard = paard
                };
                db.Paardenraces.Add(race);

                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return Content(e.Message);
                }
            }

            return Content("Success!");
        }
       
    }
}