using BLL.Interfaces;
using DAL.DataAccessLayers.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CarouselBLL : ICarouselBLL
    {
        private readonly ICarouselDal _carouselDal;

        public CarouselBLL(ICarouselDal carouselBll)
        {
            _carouselDal = carouselBll;
        }
        public IEnumerable<Carousel> GetAll()
        {
            return _carouselDal.GetAll().OrderBy(c => c.Order);
        }
        public IEnumerable<Carousel> GetAllActive()
        {
            return _carouselDal.GetAll().Where(c => c.IsActive).OrderBy(c => c.Order);
        }
        public void Delete(Carousel carousel)
        {
            _carouselDal.Delete(carousel);
        }

        public Carousel GetByid(int id) => _carouselDal.GetById(id);

        public void ToggleIsActive(Carousel carousel)
        {
            carousel.IsActive = !carousel.IsActive;

            Save(carousel);
        }

        public void Save(Carousel carousel)
        {
            if (carousel.Id <= 0)
            {
                carousel.Order = GetLastOrder()+1;
                _carouselDal.Create(carousel);
            }
            else
               _carouselDal.Update(carousel);
        }

        private int GetLastOrder() => _carouselDal.GetAll().Max(c => c.Order);


    }
}
