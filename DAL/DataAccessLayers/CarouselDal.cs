using DAL.DataAccessLayers.Interfaces;
using Models;

namespace DAL.DataAccessLayers
{
    public class CarouselDal : BaseDal<Carousel>, ICarouselDal
    {
        public CarouselDal(DB db) : base(db)
        {
        }

        public void DeleteById(int id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

        public Carousel GetById(int id) => DbSet.Find(id);
    }
}
