using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Equilibrio.Model
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; } = new Guid();
        [MaxLength(256)]
        public string? Address1 { get; set; }
        [MaxLength(256)]
        public string? Address2 { get; set; }
        [MaxLength(256)]
        public string? Address3 { get; set; }
        [MaxLength(256)]
        public string? City { get; set; }
        [MaxLength(20)]
        public string? Zip { get; set; }
        [MaxLength(50)]
        public string? State { get; set; }
        [MaxLength(50)]
        public string? Country { get; set; }
        [JsonIgnore]
        public ICollection<User>? Users { get; set; }
        public Address Clone()
        {
            return new Address()
            {
                Address1 = Address1,
                Address2 = Address2,
                Address3 = Address3,
                City = City,
                Zip = Zip,
                State = State,
                Country = Country
            };
        }

        public void Set(Address address)
        {
            Address1 = address.Address1;
            Address2 = address.Address2;
            Address3 = address.Address3;
            City = address.City;
            Zip = address.Zip;
            State = address.State;
            Country = address.Country;
        }
    }
}