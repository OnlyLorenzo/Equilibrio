using System.ComponentModel.DataAnnotations;

namespace Equilibrio.Model
{
    public class State
    {
        [Key]
        public Guid StateId { get; set; }
        [Required]
        public Guid CountryId { get; set; }
        [Required, MaxLength(60)]
        public string Name { get; set; }
        [Required, MaxLength(8)]
        public string ShortName { get; set; }        
        public Country Country { get; set; }
    }
}