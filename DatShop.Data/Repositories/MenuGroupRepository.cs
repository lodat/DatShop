using DatShop.Data.Infrastructures;
using DatShop.Model.Models;

namespace DatShop.Data.Repostitories
{
    public interface IMenuGroupRepository : IRepository<MenuGroup>
    {
    }
    public class MenuGroupRepository : RepositoryBase<MenuGroup>
    {
        public MenuGroupRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
