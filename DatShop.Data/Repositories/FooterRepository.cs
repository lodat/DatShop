using DatShop.Model.Models;
using DatShop.Data.Infrastructures;

namespace DatShop.Data.Repostitories
{
    public interface IFooterRepository : IRepository<Footer>
    {

    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dpFactory) : base(dpFactory)
        {

        }
    }
}
