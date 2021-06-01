using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public string ProductTypeName { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public DateTime CreationDate { get; set; }
        public List<SelectListItem> TypesSelectItems { get; set; }
        public List<ProductPropertyViewModel> Properties { get; set; } = new List<ProductPropertyViewModel>();
    }
}
