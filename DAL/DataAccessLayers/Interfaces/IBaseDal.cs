using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DataAccessLayers.Interfaces
{
    public interface IBaseDal<T>
    {

        void Create(T entity);


        void Delete(T entity);


        IQueryable<T> GetAll();


        void Update(T entity);       
    }
}
