using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IOrderBLL
    {
        IEnumerable<Order> GetAll();
        void Save(Order order);
    }
}
