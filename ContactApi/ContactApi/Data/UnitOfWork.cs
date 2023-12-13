using ContactApi.Repositories;

namespace ContactApi.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MockDbContext _dbContext;

        // Would inject DbContext here
        public UnitOfWork(MockDbContext dbContext) {
            // New up repositories with injected context
            _dbContext = dbContext;
            Contacts = new ContactRepository(dbContext);
        }

        public IContactRepository Contacts { get; private set; }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
