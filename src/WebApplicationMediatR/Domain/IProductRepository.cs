using WebApplicationMediatR.Domain.Entity;

namespace WebApplicationMediatR.Domain
{
    public interface IProductRepository
    {
        Task CreateProduct(Product product, CancellationToken cancellationToken);

        Task<IEnumerable<Product>> GetProduct(CancellationToken cancellationToken);
    }
}
