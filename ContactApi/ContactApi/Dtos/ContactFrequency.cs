namespace ContactApi.Dtos
{
    public class ContactFrequency
    {
        public ContactFrequency(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }

        public static IQueryable<ContactFrequency> ContactFrequencies { get { return _frequencies; } }

        private static IQueryable<ContactFrequency> _frequencies = new List<ContactFrequency>
        {
            new ContactFrequency(1, "Contact only about account information"),
            new ContactFrequency(2, "OK to contact with marketing information"),
            new ContactFrequency(3, "OK to contact with third-party marketing information"),
        }.AsQueryable();
    }
}
