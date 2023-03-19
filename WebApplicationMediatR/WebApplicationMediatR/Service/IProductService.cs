using WebApplicationMediatR.Dtos;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Service
{
    public interface IProductService
    {
        Task CreateProduct(CreateProductDto createProductDto);

        Task<IEnumerable<ProductVM>> GetProduct();
    }
}
