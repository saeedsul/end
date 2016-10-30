using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderingApplication.Controllers
{
    public class OrderController : Controller
    {
        // GET: /<controller>/
        public IActionResult NewOrder()
        {
            var newOrder = new Order();
            newOrder.Products = new List<OrderProduct>()
            {
                new OrderProduct() { Id = 1, Name = "Hoodie", Quantity = 2 },
                new OrderProduct() { Id = 1, Name = "T-Shirt", Quantity = 3 },
                new OrderProduct() { Id = 1, Name = "Banner" }
            };
            return View(newOrder);
        }

        [HttpPost]
        public IActionResult NewOrder(Order newOrder)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
