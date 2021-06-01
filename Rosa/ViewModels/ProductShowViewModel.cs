using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class ProductShowViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public string ProductTypeName { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public DateTime CreationDate { get; set; }
        public List<SelectListItem> TypesSelectItems { get; set; }
        public List<ProductPropertyViewModel> Properties { get; set; } = new List<ProductPropertyViewModel>();
        public static ProductShowViewModel FromModel(Product p) => new ProductShowViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            TypeId = p.TypeId,
            CreationDate = p.CreationDate,
            ImageUrl = p.Image,
            ProductTypeName = p.Type?.Name,

        };
      
    }
}
