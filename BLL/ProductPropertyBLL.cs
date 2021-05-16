
using BLL.Interfaces;
using DAL.DataAccessLayers.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class ProductPropertyBLL : IProductPropertyBLL
    {
        private IProductPropertyDal _productPropertyDal;
        public ProductPropertyBLL(IProductPropertyDal productPropertyDal)
        {
            _productPropertyDal = productPropertyDal;
        }

        public IEnumerable<Property> GetAll()
        {
            return _productPropertyDal.GetAll().Include(p => p.ProductType).ToList();
        }

        public void Save(Property productProperty)
        {
            if(productProperty.ShoudBeCreated)
            _productPropertyDal.Create(productProperty);
            else
            _productPropertyDal.Update(productProperty);
            
        }
    }
}
