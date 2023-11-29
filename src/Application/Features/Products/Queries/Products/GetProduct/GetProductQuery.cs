using MediatR;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Application.Features.Products.Queries.Products.GetProduct
{
    public class GetProductQuery : IRequest<IEnumerable<ProductVM>>
    {
    }
}
