using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataAccessLayers.Interfaces
{
    public interface IOrderDal : IBaseDal<Order>
    {
        Order GetById(int Id); 
    }
}
