using MediatR;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Application.Features.Products.Queries.GetProduct
{
    public class GetProductQuery : IRequest<IEnumerable<ProductVM>>
    {
    }
}
