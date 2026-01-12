using GestionaleErboristeria.Application.Services;
using GestionaleErboristeria.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestionaleErboristeria.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        private readonly IBatchService _batchService;

        public BatchController(IBatchService batchService)
        {
            _batchService = batchService;
        }

        [HttpPost]
        public async Task<IActionResult> AddBatch([FromBody] Batch batch)
        {
            await _batchService.AddBatchAsync(batch);
            return Ok();
        }
    }
}
