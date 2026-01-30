using System.ComponentModel.DataAnnotations;

namespace GestionaleErboristeria.Application.DTOs
{
    public class CreateProductDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string ProductCode { get; set; } = null!;

        [Range(0.01, 10000, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
