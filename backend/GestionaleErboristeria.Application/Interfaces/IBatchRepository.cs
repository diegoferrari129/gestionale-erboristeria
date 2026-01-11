using GestionaleErboristeria.Domain.Entities;

namespace GestionaleErboristeria.Application.Interfaces
{

    /// <summary>
    /// Defines methods for managing and retrieving batch records associated with products in a data store.
    /// </summary>
    /// <remarks>Implementations of this interface are responsible for providing asynchronous operations to
    /// add, update, and retrieve batches by product identifier.</remarks>

    public interface IBatchRepository
    {
        Task<IEnumerable<Batch>> GetByProductIdAsync(int productId);
        Task AddBatchAsync(Batch batch);
        Task UpdateBatchAsync(Batch batch);
    }

}
