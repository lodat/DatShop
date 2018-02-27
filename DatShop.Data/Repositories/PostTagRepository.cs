using DatShop.Data.Infrastructures;
using DatShop.Model.Models;

namespace DatShop.Data.Repostitories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {

    }
    public class PostTagRepository: RepositoryBase<PostTag>, IPostTagRepository 
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
