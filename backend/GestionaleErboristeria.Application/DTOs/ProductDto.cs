namespace GestionaleErboristeria.Application.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public decimal Price { get; set; }

        public CategoryDto Category { get; set; } = null!;
    }
}
