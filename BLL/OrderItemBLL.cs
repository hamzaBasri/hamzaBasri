using BLL.Interfaces;
using DAL.DataAccessLayers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class OrderItemBLL :IOrderItemBLL
    {
        private IOrderItemDal _orderItemDal;

        public OrderItemBLL(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }
    }
}
