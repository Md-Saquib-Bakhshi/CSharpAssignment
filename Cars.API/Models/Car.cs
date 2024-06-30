using System.ComponentModel.DataAnnotations;

namespace Cars.API.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(20, ErrorMessage = "\n!!!Length of name must be less than 20 characters.!!!")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "\n!!!Length of category must be less than 50 characters.")]
        public string Category { get; set; }
        [Required]
        [Range(0, 9999999999, ErrorMessage = "\n!!!Length of price must be less than 10 digits.!!!")]
        public int Price { get; set; }
    }
}
