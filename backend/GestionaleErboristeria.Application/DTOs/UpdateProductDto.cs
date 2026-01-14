using System;
using System.Collections.Generic;
using System.Text;

namespace GestionaleErboristeria.Application.DTOs
{
    public class UpdateProductDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
