using ContactApi.Repositories;

namespace ContactApi.Data
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        IContactRepository Contacts { get; }
        ILookupRepository Lookups { get; }
    }
}
