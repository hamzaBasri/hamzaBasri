using BLL.interfaces;
using DAL.DataAccessLayers.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BLL
{
    public class ProductBLL : IProductBLL
    {
        //field to hold ProductDAL
        private IProductDal _productDal;

        //the class constructor
        //dependency Ingection of the Classe ProductDal in ProductBLL
        public ProductBLL(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IEnumerable<Product> GetAll()
        {
            return _getAll.ToList();
        }


        public IEnumerable<Product> GetAllIncludingType() => _getAll.Include(p => p.Type).ToList();
        public Product GetByIdIncludingAll(int id) => _getAll.Include(p => p.Type).Include(p => p.ProductProperties).ThenInclude(pp => pp.Property).FirstOrDefault(p =>p.Id == id);



        private IQueryable<Product> _getAll => _productDal.GetAll();


        public void Save(Product product)
        {
            if (product.ShoudBeCreated)
                _productDal.Create(product);

            else
                _productDal.Update(product);

        }
        public void DeleteById(int id) => _productDal.DeleteById(id);
    }
}
