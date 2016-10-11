using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderingApplication.Controllers
{
    public class ClientController : Controller
    {
        // GET: /<controller>/
        public IActionResult NewClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewClient(Client newClient)
        {
            if (ModelState.IsValid)
            {
                // Save updated data to Database

                return RedirectToAction("Index", "Home");
            } else
            {
                return View(newClient);
            }
        }

        public IActionResult VerifyEmail(string email)
        {
            var emailList = new List<string>()
            {
                "test@example.com",
                "hello@example.com",
                "world@example.com"
            };

            if (emailList.Contains(email))
            {
                return Json("Email is already taken");
            }

            return Json(true);
        }
    }
}
