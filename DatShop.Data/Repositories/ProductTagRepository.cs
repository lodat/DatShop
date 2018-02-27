using DatShop.Data.Infrastructures;
using DatShop.Model.Models;

namespace DatShop.Data.Repostitories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {

    }
   public class ProductTagRepository:RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
