using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Models
{
    public class Order
    {
        public string ClientId { get; set; }
        public string CompanyName { get; set; }
        public string OrderDate { get; set; }
        public string Priority { get; set; }
        public List<OrderProductVM> Products { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderInstructions { get; set; }
        public string Notes { get; set; }
    }

    public class OrderProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
    }
}
