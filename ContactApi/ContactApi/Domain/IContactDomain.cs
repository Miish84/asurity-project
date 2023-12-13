namespace ContactApi.Domain
{
    public interface IContactDomain
    {
        public IEnumerable<Models.Contact> Get();
    }
}
