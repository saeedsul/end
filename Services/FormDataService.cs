using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrderingApplication.Models;

namespace OrderingApplication.Services
{
    public class FormDataService : IFormDataService
    {
        public List<SelectListItem> GetLocations()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Northeast", Value = "1" },
                new SelectListItem() { Text = "West", Value = "2" },
                new SelectListItem() { Text = "Downtown", Value = "3" },
                new SelectListItem() { Text = "Township", Value = "4" }
            };
        }

        public List<SelectListItem> GetClientTypes()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Small Business" },
                new SelectListItem() { Text = "Individual" },
                new SelectListItem() { Text = "Corporation" }
            };
        }

        public List<OrderProduct> GetProducts()
        {

            return new List<OrderProduct>()
            {
                new OrderProduct() { Id = 1, Name = "Hoodie" },
                new OrderProduct() { Id = 1, Name = "T-Shirt" },
                new OrderProduct() { Id = 1, Name = "Banner" },
                new OrderProduct() { Id = 1, Name = "Table Cloth" },
                new OrderProduct() { Id = 1, Name = "Streamers" }
            };
        }
    }
}
