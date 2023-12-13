using ContactApi.Repositories;

namespace ContactApi.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        // Would inject DbContext here
        public UnitOfWork() {
            // New up repositories with injected context
            Contacts = new ContactRepository();
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
