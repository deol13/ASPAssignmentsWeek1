using Microsoft.AspNetCore.Mvc;
using ASPAssignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Http;

namespace ASPAssignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            ContactInfo me = new ContactInfo();
            me.Name = "Eric Husman";
            me.PhoneNumber = "079812341";
            me.Email = "fluffutyr.num@gmail.com";

            return View(me);
        }
        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult GuessingGame()
        {
            Random rand = new Random();

            HttpContext.Session.SetInt32("Rnd", rand.Next(1, 101));

            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            int hiddenNumber = (int)HttpContext.Session.GetInt32("Rnd");

            if(guess > 100 || guess < 1)
            {
                ViewData["Message"] = "Error: Your guess isn't valid, only the numbers 1 through 100 is valid!";
            }
            else if(guess == hiddenNumber)
            {
                ViewData["Message"] = "Congratulations you guessed correctly!";
                HttpContext.Session.Clear();

                Random rand = new Random();
                HttpContext.Session.SetInt32("Rnd", rand.Next(1, 101));
            }
            else if(guess > hiddenNumber)
            {
                ViewData["Message"] = "You guessed too high!";
            }
            else
            {
                ViewData["Message"] = "You guessed too low!";
            }

            return View();
        }
    }
}
