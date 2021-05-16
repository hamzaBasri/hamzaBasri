using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class ProductEditViewModel
    {
        public ProductEditViewModel()
        {
            CreationDate = DateTime.Now;
        }

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
        public bool IsCreateMode => Id <= 0;
       

        public static ProductEditViewModel FromModel(Product p, IEnumerable<ProductType> productTypes)
        {


            var productVM = p != null ? new ProductEditViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                TypeId = p.TypeId,
                CreationDate = p.CreationDate,
                ImageUrl = p.Image,
                ProductTypeName = p.Type?.Name,
                Properties = p.ProductProperties.Select(pp => new ProductPropertyViewModel
                {
                    //Cost = pp.Cost,
                    PropertyId = pp.PropertyId,
                    PropertyName = pp.Property.Name
                    //PropertyValue = pp.Value
                }
            ).ToList()
        }: new ProductEditViewModel();


            productVM.TypesSelectItems = productTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = pt.Id.ToString()
            }).ToList();

          

            return productVM;

        }

        public Product ToModel() => new Product
        {

            Id = Id,
            Name = Name,
            Description = Description,
            TypeId = TypeId,
            CreationDate = CreationDate,
            Image = ImageUrl
        };


    }
}
