using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataAccessLayers.Interfaces
{
    public interface ICarouselDal : IBaseDal<Carousel>
    {
        Carousel GetById(int id);
      
        void DeleteById(int id);
    }
}
