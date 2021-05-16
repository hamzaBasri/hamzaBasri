using BLL.Interfaces;
using DAL.DataAccessLayers.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ProductTypeBLL: IProductTypeBLL
    {
        //field to hold ProductDAL
        private IProductTypeDal _productTypeDal;

        //the class constructor
        //dependency Ingection of the Classe ProductDal in ProductBLL
        public ProductTypeBLL(IProductTypeDal productTypeDal)
        {
            _productTypeDal = productTypeDal;
        }
        public IEnumerable<ProductType> GetAll()
        {
            return _productTypeDal.GetAll().ToList();
        }

        public void Save(ProductType productType)
        {
            if (productType.ShoudBeCreated)

                _productTypeDal.Create(productType);

            else

                _productTypeDal.Update(productType);

        }
    }
}
