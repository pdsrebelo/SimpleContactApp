namespace Contact.Data
{
    public class DbFactory : IDbFactory
    {
        private StoreEntities _dbContext;

        public StoreEntities Init()
        {
            return _dbContext ?? (_dbContext = new StoreEntities());
        }
    }
}
