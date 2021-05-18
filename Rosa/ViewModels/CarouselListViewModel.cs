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
        public bool IsCreateMode => Id <= 0;

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
                Description = c.Description

            };
        }
        public Carousel ToModel() => new Carousel
        {

            Id = Id,
            ImageUrl = ImageUrl,
            IsActive = IsActive,
            Title = Title,
            Description = Description

        };
    }
}
