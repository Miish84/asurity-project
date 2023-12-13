﻿namespace ContactApi.Data
{
    public class Contact
    {
        public Contact(int id, string firstName, string lastName, string email, string street, string city, string state, int zip) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Street = street;
            City = city;
            State = state;
            Zip = zip;
            Uuid = new Guid();
        }

        public int Id { get; }
        public Guid Uuid { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public int Zip { get; }
    }
}
