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

        public IQueryable<Contact> Contacts { get { return _contacts; } }

        public static bool Save()
        {
            // Update or rollback Contacts
            return true;
        }
    }
}
