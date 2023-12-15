using ContactApi.Data.Models;

namespace ContactApi.Repositories
{
    public interface ILookupRepository
    {
        IEnumerable<ContactFrequency> GetContactFrequencies();
        IEnumerable<State> GetStates();
    }
}