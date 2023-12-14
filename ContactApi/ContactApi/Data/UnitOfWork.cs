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
        }

        public IContactRepository Contacts { get; private set; }

        public int Commit()
        {
            // MJI todo
            return 1;
        }

        public void Dispose()
        {
            _dbContext = null;
        }
    }
}
