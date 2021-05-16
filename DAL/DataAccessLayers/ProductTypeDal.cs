using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DataAccessLayers.Interfaces;

namespace DAL.DataAccessLayers
{
    public class ProductTypeDal : BaseDal<ProductType>, IProductTypeDal
    {
        public ProductTypeDal(DB db) : base(db)
        {
        }

        public ProductType GetById(int id) => DbSet.AsNoTracking().FirstOrDefault(pt => pt.Id == id);
    }
}
