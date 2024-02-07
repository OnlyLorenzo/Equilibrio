using System.ComponentModel.DataAnnotations;

namespace Equilibrio.Model
{
    public class Country
    {
        [Key]
        public Guid CountryId { get; set; }        
        [Required, MaxLength(256)]
        public string Name { get; set; }
        [Required, MaxLength(20)]
        public string ShortName { get; set; }
        [Required, MaxLength(10)]
        public string InternationalPrefix { get; set; }
        [Required, MaxLength(51200)]
        public string FlagBase64 { get; set; }
    }
}