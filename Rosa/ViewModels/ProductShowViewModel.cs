using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }
        public List<SelectListItem> TypesSelectItems { get; set; }
        public List<PropertyViewModel> Properties { get; set; } = new List<PropertyViewModel>();
        public static ProductShowViewModel FromModel(Product p) => new ProductShowViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            TypeId = p.TypeId,
            CreationDate = p.CreationDate,
            ImageUrl = p.Image,
            ProductTypeName = p.Type?.Name,
            Price = p.Price,
            Properties = p.Type.Properties.Select(p => new PropertyViewModel
            {

            }).ToList()
        };
      
    }
}
