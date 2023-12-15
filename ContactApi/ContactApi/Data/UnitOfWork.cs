using ContactApi.Repositories;

namespace ContactApi.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private MockDbContext _dbContext;

        // Would inject DbContext here
        public UnitOfWork(MockDbContext dbContext) {
            // New up repositories with injected context
            _dbContext = dbContext;
            Contacts = new ContactRepository(dbContext);
            Lookups = new LookupRepository(dbContext);
        }

        public IContactRepository Contacts { get; private set; }
        public ILookupRepository Lookups { get; private set; }

        public int Commit()
        {
            _dbContext.Save();
            return 1;
        }

        public void Dispose()
        {
            _dbContext = null;
        }
    }
}
