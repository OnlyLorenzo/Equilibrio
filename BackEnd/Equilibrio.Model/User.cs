using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Transactions;

namespace Equilibrio.Model
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; } = new Guid();
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Surname { get; set; }
        public decimal balance { get; set; }
        [MaxLength(50)]
        public string? PhoneNumber { get; set; }
        [Required, MaxLength(256)]
        public string ImageUrl { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required, MaxLength(50), JsonIgnore]
        public string EncryptedPassword { get; set; } = Guid.Empty.ToString();
        [Required, JsonIgnore]
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.Now;
        public Address Address { get; set; }
        public ICollection<AccountTransaction> Transactions { get; set; }
        public ICollection<CardInvoice> CardInvoices { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Cards> Cards { get; set; }
    }
}
