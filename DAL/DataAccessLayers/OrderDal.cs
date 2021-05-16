using DAL.DataAccessLayers.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DataAccessLayers
{
    public class OrderDal :BaseDal<Order>, IOrderDal
    {
        public OrderDal(DB db) : base(db)
        {
                
        }
        public Order GetById(int id) => DbSet.AsNoTracking().FirstOrDefault(p => p.Id == id);

    }
}
