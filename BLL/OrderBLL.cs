using BLL.Interfaces;
using DAL.DataAccessLayers.Interfaces;
using Models;
using System.Collections.Generic;
using System.Linq;

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
            

                _orderDal.Update(order);

        }
    }
}
