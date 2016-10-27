using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Components
{
    public class SurveyWidget : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = new List<SurveyProduct>()
            {
                new SurveyProduct() { Id = 1, Name = "Hoodies", VoteCount = 8 },
                new SurveyProduct() { Id = 2, Name = "Banners", VoteCount = 1 },
                new SurveyProduct() { Id = 3, Name = "Posters", VoteCount = 4 },
                new SurveyProduct() { Id = 4, Name = "T-Shirts", VoteCount = 2 },
            };

            return View(products);
        }
    }

    public class SurveyProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VoteCount { get; set; }
    }
}
