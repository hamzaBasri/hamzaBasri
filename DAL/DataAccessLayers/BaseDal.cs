
using DAL.DataAccessLayers.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.DataAccessLayers
{
    public class BaseDal<T>:IBaseDal<T> where T : class
    {
        protected readonly DB _db;
        public BaseDal(DB db)
        {
            _db = db;
        }

        public void Create(T entity)
        {
            DbSet.Add(entity);
            SaveChanges();
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
            SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet.AsNoTracking();
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
            SaveChanges();
            
        }
        
        protected DbSet<T> DbSet => _db.Set<T>();

        //Identical to the top one
        //protected DbSet<T> DbSet
        //{
        //    get
        //    {
        //        return _db.Set<T>(); 
        //    }
        //}
       
        protected void SaveChanges() 
        {
            _db.SaveChanges();
        }
    }
}
