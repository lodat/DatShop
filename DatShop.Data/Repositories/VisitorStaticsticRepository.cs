using DatShop.Data.Infrastructures;
using DatShop.Model.Models;

namespace DatShop.Data.Repostitories
{
    public interface IVisitorStaticsticRepository : IRepository<VisitorStatistic>
    {

    }
    public class VisitorStaticsticRepository : RepositoryBase<VisitorStatistic>, IVisitorStaticsticRepository
    {
        public VisitorStaticsticRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
