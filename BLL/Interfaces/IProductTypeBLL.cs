using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IProductTypeBLL
    {
        IEnumerable<ProductType> GetAll();
        void Save(ProductType productType);
    }
}
