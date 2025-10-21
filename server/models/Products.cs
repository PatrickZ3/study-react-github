using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Product
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Category { get; set; } = string.Empty;  
        [Required]
        public decimal Price { get; set; }
        public bool Stocked { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}