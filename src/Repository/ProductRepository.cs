using WebApplicationMediatR.Domain;
using WebApplicationMediatR.Domain.Entity;

namespace WebApplicationMediatR.Repository
{
    public class ProductRepository : IProductRepository
    {
        public async Task CreateProduct(Product product, CancellationToken cancellationToken)
        {
            await Task.Delay(1000);
        }

        public async Task<IEnumerable<Product>> GetProduct(CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Test",
                },
                new Product() {

                        Id = 2,
                        Name = "Test_2"

                }
            });
        }

        public async Task<Product> GetProduct(int productId, CancellationToken cancellationToken)
        {
            return await Task.Run(() => new Product()
            {
                Id = productId,
                Name = "test"
            });
        }
    }
}
