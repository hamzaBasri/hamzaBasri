using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class ProductTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public static List<ProductTypeViewModel> FromModels(IEnumerable<ProductType> productTypes)
           => productTypes.Select(FromModel).ToList();
        public static ProductTypeViewModel FromModel(ProductType pt) => new ProductTypeViewModel
        {
            Id = pt.Id,
            Name = pt.Name,
            Image = pt.Image
        };
        public ProductType ToModel() => new ProductType
        {
            Id = Id,
            Name = Name,
            Image = Image
        };
    }
}
