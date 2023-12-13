namespace ContactApi.Domain.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public Guid Uuid { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
    }
}
