using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace List10.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string? Name { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be larger than 0.")]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        [Display(Name = "Image")]
        public string? ImagePath { get; set; }
       // [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
    }
}
