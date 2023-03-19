using WebApplicationMediatR.Dtos;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Service
{
    public class ProductService : IProductService
    {
        public Task CreateProduct(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductVM>> GetProduct()
        {
            throw new NotImplementedException();
        }
    }
}
