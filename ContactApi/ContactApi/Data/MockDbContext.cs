using ContactApi.Data.Models;

namespace ContactApi.Data
{
    public class MockDbContext
    {
        private static IQueryable<Contact> _contacts = new List<Contact> {
            new(1, "Tim", "Early", "tim.early@gmail.com", "111 Apple Rd", "Knoxville", "Tennessee", 37922),
            new(2, "Emil", "Abrhams", "emil.abrahms@gmail.com", "858 Count Ct", "Nashville", "Tennessee", 37828),
            new(3, "Lisa", "Early", "lisa.early@gmail.com", "111 Apple Rd", "Knoxville", "Tennessee", 37922),
            new(4, "Ned", "Baker", "ned.baker@gmail.com", "8288 Squire Cir", "Birmingham", "Alabama", 35210),
        }.AsQueryable();

        public IQueryable<Contact> Contacts { get { return _contacts.Select(item => (Contact)item.Clone()); } private set { _contacts = value; } }

        public bool Save(IQueryable<Contact> updatedContacts)
        {
            _contacts = updatedContacts;
            return true;
        }
    }
}
