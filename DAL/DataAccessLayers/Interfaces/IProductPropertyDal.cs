using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataAccessLayers.Interfaces
{
    public interface IProductPropertyDal :IBaseDal<Property>
    {
        Property GetById(int id);
    }
}
