using Microsoft.AspNetCore.Mvc;
using ASPAssignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment1.Controllers
{
    public class DoctorController : Controller
    {
        private static string msg = "";
        private static bool reset = true;

        public IActionResult Index()
        {
            if(reset)
            {
                msg = "";
            }

            ViewData["Message"] = msg;
            reset = true;

            return View();
        }

        public IActionResult CheckMyFever(int temp)
        {
            msg = "";
            

            if(temp != 0)
            {
                msg = FeverCheck.CheckForFever(temp);
                reset = false;
            }
            else
            {
                reset = true;
            }

            return RedirectToAction("Index");
        }
    }
}
