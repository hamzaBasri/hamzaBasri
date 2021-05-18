using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ICarouselBLL
    {
        IEnumerable<Carousel> GetAll();
        IEnumerable<Carousel> GetAllActive();
        Carousel GetByid(int id);
        void Delete(Carousel carousel);
        void Save(Carousel carousel);
        void ToggleIsActive(Carousel carousel);
    }
}
