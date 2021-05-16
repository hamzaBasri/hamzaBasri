using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataAccessLayers.Interfaces
{
    public interface IProductDal : IBaseDal<Product>
    {
        Product GetById(int id);
        void DeleteById(int id);
    }
}
