using DAL.DataAccessLayers.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace DAL.DataAccessLayers
{
    public class ProductPropertyDal : BaseDal<Property>, IProductPropertyDal
    {
        public ProductPropertyDal(DB db) : base(db)
        {
        }
        public Property GetById(int id) => DbSet.AsNoTracking().FirstOrDefault(p => p.Id == id);
    }
}
