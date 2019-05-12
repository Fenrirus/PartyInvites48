namespace PartyInvites48.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using PartyInvites48.Models;

    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczów";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
    }
}