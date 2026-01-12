using GestionaleErboristeria.Application.Interfaces;
using GestionaleErboristeria.Domain.Entities;
using GestionaleErboristeria.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GestionaleErboristeria.Infrastructure.Repositories
{
    /// <summary>
    /// Provides methods for managing and accessing batch entities in the data store.
    /// </summary>
    /// <remarks>The BatchRepository implements the IBatchRepository interface to support common operations
    /// such as retrieving, adding, and updating batches. This class is typically used in data access layers to
    /// encapsulate batch-related persistence logic.</remarks>
    public class BatchRepository : IBatchRepository
    {
        private readonly AppDbContext _context;

        public BatchRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Batch>> GetByProductIdAsync(int productId)
        {
            return await _context.Batches
                .Where(b => b.ProductId == productId)
                .ToListAsync();
        }

        public async Task AddBatchAsync(Batch batch)
        {
            await _context.Batches.AddAsync(batch);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBatchAsync(Batch batch)
        {
            _context.Batches.Update(batch);
            await _context.SaveChangesAsync();
        }
    }
}
