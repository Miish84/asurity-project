﻿namespace ContactApi.Domain.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public Guid Uuid { get; set; }
        public   string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
        public int? Frequency { get; set; }
    }
}
