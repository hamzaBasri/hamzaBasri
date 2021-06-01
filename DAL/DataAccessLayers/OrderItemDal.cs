using DAL.DataAccessLayers.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DataAccessLayers
{
    public class OrderItemDal : BaseDal<OrderItem>, IOrderItemDal
    {
        public OrderItemDal(DB db) : base(db)
        {
        }
        public OrderItem GetById(int id) => DbSet.AsNoTracking().FirstOrDefault(p => p.Id == id);

        
    }
}
