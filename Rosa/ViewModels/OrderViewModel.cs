using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        
        public decimal Price { get; set; }
        public string CustumerEmail { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string RequestedImageUrl { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }

        public static List<OrderViewModel> FromModels(IEnumerable<Order> orders)
            => orders.Select(FromModel).ToList();

        public static OrderViewModel FromModel(Order o) => new OrderViewModel
        {
            Id = o.Id,           
            Price = o.Price,
            CustumerEmail = o.CustumerEmail,
            Description = o.Description,
            OrderDate = o.OrderDate,
            Address = o.Address,
           
            //Status = o.Status
        };

        public Order ToModel() => new Order
        {
            Id = Id,           
            Price = Price,
            CustumerEmail = CustumerEmail,
            Description = Description,
            OrderDate = OrderDate,
            Address = Address
        };
    }
}
