namespace GestionaleErboristeria.Domain.Entities
{
    public class Batch : BaseEntity
    {
        public int ProductId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public DateTime ReceivedAt { get; set; } = DateTime.UtcNow;
    }
}
