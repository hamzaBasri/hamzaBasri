using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataAccessLayers.Interfaces
{
    public interface IOrderItemDal : IBaseDal<OrderItem> 
    {
        OrderItem GetById(int Id);
    }
}
