using BLL;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.Controllers.api
{
    public class CarouselController : BaseApiController
    {
        private readonly ICarouselBLL _carouselBLL;
        public CarouselController(ICarouselBLL carouselBLL)
        {
            _carouselBLL = carouselBLL;
        }


        [HttpPost]
        public void SortOrders(int[] carsouselIds)
        {
            for(int i =0; i< carsouselIds.Length; i++)
            {
                var carousel = _carouselBLL.GetByid(carsouselIds [i]);
                carousel.Order = i;
                _carouselBLL.Save(carousel);
            }

        }
    }
}
