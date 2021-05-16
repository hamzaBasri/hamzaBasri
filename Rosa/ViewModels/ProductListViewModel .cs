using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public string ProductTypeName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreationDate { get; set; }
        


        public static List<ProductListViewModel> FromModels(IEnumerable<Product> products)
            => products.Select(FromModel).ToList();

        public static ProductListViewModel FromModel(Product p) => new ProductListViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,            
            CreationDate = p.CreationDate,
            ImageUrl = p.Image,
            ProductTypeName = p.Type?.Name
        };
        
    }
}
