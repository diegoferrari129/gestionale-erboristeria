using GestionaleErboristeria.Domain.Entities;

namespace GestionaleErboristeria.Application.Interfaces
{

    /// <summary>
    /// Defines methods for retrieving, adding, and updating product data in a repository.
    /// </summary>
    /// <remarks>Implementations of this interface are responsible for managing the persistence and retrieval
    /// of <see cref="Product"/> entities. Methods are asynchronous and may involve I/O operations such as database
    /// access.</remarks>

    public interface IProductRepository
    {
        //checking uniqueness of product code
        Task<bool> ProductIsUniqueAsync(string productCode);

        Task<Product?> GetProductAsync(int productId);
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int productId);
    }

}
