using ContactApi.Data;
using ContactApi.Data.Models;

namespace ContactApi.Repositories
{
    public class LookupRepository : ILookupRepository
    {
        private readonly MockDbContext dbContext;

        public LookupRepository(MockDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<State> GetStates()
        {
            return dbContext.States.ToList();
        }

        public IEnumerable<ContactFrequency> GetContactFrequencies()
        {
            return dbContext.ContactFrequencies.ToList();
        }
    }
}
