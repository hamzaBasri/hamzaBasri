using BLL.Interfaces;
using DAL.DataAccessLayers.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BLL
{
    public class OrderBLL : IOrderBLL
    {
        private IOrderDal _orderDal;

        public OrderBLL(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderDal.GetAll().ToList();
        }
        public void Save(Order order)
        {
            if (order.ShoudBeCreated)

                _orderDal.Create(order);

            else

                _orderDal.Update(order);

        }
    }
}
