using GestionaleErboristeria.Application.DTOs;
using GestionaleErboristeria.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionaleErboristeria.Api.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto dto)
        {
            await _productService.CreateProductAsync(dto);
            return CreatedAtAction(nameof(CreateProduct), new { name = dto.Name }, dto);
        }
    }
}
