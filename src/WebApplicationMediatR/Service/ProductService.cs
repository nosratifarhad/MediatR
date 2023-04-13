using WebApplicationMediatR.Dtos;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Service
{
    public class ProductService : IProductService
    {
        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            await Task.Delay(1000);
        }

        public async Task<IEnumerable<ProductVM>> GetProduct()
        {
            return await Task.FromResult(new List<ProductVM>());
        }
    }
}
