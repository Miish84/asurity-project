using Newtonsoft.Json;

namespace ContactApi.Data.Models
{
    public class Contact : ICloneable
    {
        public Contact(int id, Guid uuid, string firstName, string lastName, string email, string street, string city, string state, int? zip, int? frequency)
        {
            Id = id;
            Uuid = uuid;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Street = street;
            City = city;
            State = state;
            Zip = zip;
            Uuid = uuid;
            Frequency = frequency;
        }

        public int Id { get; }
        public Guid Uuid { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public int? Zip { get; }
        public int? Frequency { get; }

        public object Clone()
        {
            var serialized = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Contact>(serialized);

        }
    }
}
