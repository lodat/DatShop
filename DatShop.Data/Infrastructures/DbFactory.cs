namespace DatShop.Data.Infrastructures
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DatShopDbContext dbContext;

        public DatShopDbContext Init()
        {
            return dbContext ?? (dbContext = new DatShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
