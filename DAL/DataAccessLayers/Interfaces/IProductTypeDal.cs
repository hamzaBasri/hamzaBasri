using Models;
namespace DAL.DataAccessLayers.Interfaces
{
    public interface IProductTypeDal : IBaseDal<ProductType>
    {
        ProductType GetById(int id);
    }
}
