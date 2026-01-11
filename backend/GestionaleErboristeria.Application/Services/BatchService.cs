using GestionaleErboristeria.Domain.Entities;
using GestionaleErboristeria.Application.Interfaces;

namespace GestionaleErboristeria.Application.Services
{
    /// <summary>
    /// Provides operations for managing batches.
    /// </summary>
    public class BatchService : IBatchService
    {
        private readonly IBatchRepository _batchRepository;
        private readonly IProductRepository _productRepository;

        public BatchService(IBatchRepository batchRepository, IProductRepository productRepository)
        {
            _batchRepository = batchRepository;
            _productRepository = productRepository;
        }

        public async Task AddBatchAsync(Batch batch)
        {
            var product = await _productRepository.GetProductAsync(batch.ProductId);
            if (product == null)
            {
                throw new ArgumentException($"Product with ID {batch.ProductId} does not exist.");
            }
            await _batchRepository.AddBatchAsync(batch);
        }
    }
}
