using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Components
{
    public class InventoryWidget : ViewComponent
    {
        private IInventoryService _inventoryService;

        public InventoryWidget(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int threshold = 10)
        {
            var inventory = _inventoryService.GetInventoryLevels(threshold);

            return View(inventory);
        }
    }

    public class InventoryItem
    {
        public InventoryItem()
        {
        }

        public int Count { get; set; }
        public string Name { get; set; }
    }
}
