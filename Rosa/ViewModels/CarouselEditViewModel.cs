using Microsoft.AspNetCore.Http;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class CarouselEditViewModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public bool IsActive { get; set; } = true;
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool IsCreateMode => Id <= 0;
        public static CarouselEditViewModel FromModel(Carousel c)
        {
            return new CarouselEditViewModel
            {
                Id = c.Id,
                ImageUrl = c.ImageUrl,
                IsActive = c.IsActive,
                Title = c.Title,
                Description = c.Description,
                Order = c.Order
            };
        }
        public Carousel ToModel() => new Carousel
        {
            Id = Id,
            ImageUrl = ImageUrl,
            IsActive = IsActive,
            Title = Title,
            Description = Description,
            Order = Order

        };
    }
}
