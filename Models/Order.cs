using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Price { get; set; }      
        public string CustumerEmail { get; set; }
        public OrderStatusEnum Status{ get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
