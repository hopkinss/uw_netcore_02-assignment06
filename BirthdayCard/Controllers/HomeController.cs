using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BirthdayCard.Models;

namespace BirthdayCard.Controllers
{
    public class HomeController : Controller
    {
        private BdayCard bdayCard;
        public HomeController()
        {
            bdayCard = new BdayCard(); 
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BdayCard card)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("SendCard",card);                
            }
            return View(card);
        }

        public IActionResult SendCard(BdayCard card)
        {

            return View(card);
        }


    }
}
