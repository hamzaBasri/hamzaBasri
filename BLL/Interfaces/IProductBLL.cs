using Models;
using System;
using System.Collections.Generic;

namespace BLL.interfaces
{
    public interface IProductBLL
    {
        IEnumerable<Product> GetAll();

        void Save(Product product);
        void DeleteById(int id);
        IEnumerable<Product> GetAllIncludingType();
        Product GetByIdIncludingAll(int id);
    }
}