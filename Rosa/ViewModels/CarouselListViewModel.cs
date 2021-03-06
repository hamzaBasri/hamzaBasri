using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class CarouselListViewModel
    {


        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public string Title { get; set; }
        public string Description { get; set; }       
        public int Order { get; set; }
        public bool IsFirst => Order == 0;
        public string SetClassForFirstItem(string className) => IsFirst ? className : "";
        
        public static List<CarouselListViewModel> FromModels(IEnumerable<Carousel> carousel)
           => carousel.Select(FromModel).ToList();
        public static CarouselListViewModel FromModel(Carousel c)
        {
            return new CarouselListViewModel
            {
                Id = c.Id,
                ImageUrl = c.ImageUrl,
                IsActive = c.IsActive,
                Title = c.Title,
                Description = c.Description,
                Order = c.Order
            };
        }
       
    }
}
