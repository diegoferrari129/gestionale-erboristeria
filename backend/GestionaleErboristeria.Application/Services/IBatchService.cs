using GestionaleErboristeria.Domain.Entities;

namespace GestionaleErboristeria.Application.Services
{
    /// <summary>
    /// Defines a service for adding batch operations asynchronously.
    /// </summary>
    public interface IBatchService
    {
        Task AddBatchAsync(Batch batch);
    }
}
