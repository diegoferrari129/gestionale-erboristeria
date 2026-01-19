namespace GestionaleErboristeria.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsActive { get; set; } = true;

        // foreign key
        public int CategoryId { get; set; }

        // navigation property
        public Category Category { get; set; } = null!;
    }
}
