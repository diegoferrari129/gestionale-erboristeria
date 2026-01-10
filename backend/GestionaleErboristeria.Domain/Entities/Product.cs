using System;
using System.Collections.Generic;
using System.Text;

namespace GestionaleErboristeria.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public decimal Price { get; set; }

        public bool IsActive { get; set; } = true;

        public int CategoryId { get; set; }
    }
}
