using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IProductPropertyBLL
    {
        IEnumerable<Property> GetAll();
        void Save(Property productProperty);
    }
}
