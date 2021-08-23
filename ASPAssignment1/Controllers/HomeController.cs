using Microsoft.AspNetCore.Mvc;
using ASPAssignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

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
    }
}
