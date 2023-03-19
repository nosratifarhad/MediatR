using MediatR;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Application.Queries.Products.GetProduct
{
    public class GetProductQuery : IRequest<IEnumerable<ProductVM>>
    {
        public int ProductId { get; set; }
    }
}
