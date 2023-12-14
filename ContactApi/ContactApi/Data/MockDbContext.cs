using ContactApi.Data.Models;

namespace ContactApi.Data
{
    public class MockDbContext
    {
        private static IQueryable<Contact> _contacts = new List<Contact> {
            new(1, Guid.NewGuid(), "Tim", "Early", "tim.early@gmail.com", "111 Apple Rd", "Knoxville", "Tennessee", 37922),
            new(2, Guid.NewGuid(), "Emil", "Abrhams", "emil.abrahms@gmail.com", "858 Count Ct", "Nashville", "Tennessee", 37828),
            new(3, Guid.NewGuid(), "Lisa", "Early", "lisa.early@gmail.com", "111 Apple Rd", "Knoxville", "Tennessee", 37922),
            new(4, Guid.NewGuid(), "Ned", "Baker", "ned.baker@gmail.com", "8288 Squire Cir", "Birmingham", "Alabama", 35210),
        }.AsQueryable();

        private static IQueryable<Contact> _queuedChanges;

        public IQueryable<Contact> Contacts { get { return _contacts.Select(item => (Contact)item.Clone()); } private set { _contacts = value; } }

        public void QueueChanges(IEnumerable<Contact> updatedContacts)
        {
            _queuedChanges = updatedContacts.AsQueryable();
        }

        public bool Save()  
        {
            _contacts = _queuedChanges;
            return true;
        }
    }
}
