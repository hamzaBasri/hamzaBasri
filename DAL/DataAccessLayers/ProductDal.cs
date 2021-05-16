using DAL.DataAccessLayers.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DataAccessLayers
{
    public class ProductDal : BaseDal<Product>, IProductDal
    {
        public ProductDal(DB db) : base(db)
        {
        }


        public Product GetById(int id) => DbSet.AsNoTracking().FirstOrDefault(p => p.Id == id);
        public void DeleteById(int id) {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

    }
}
