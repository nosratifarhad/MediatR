using MediatR;
using WebApplicationMediatR.Service;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Application.Queries.Products.GetProduct
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, IEnumerable<ProductVM>>
    {
        #region Fields

        private readonly IProductService _productService;
        #endregion Fields

        #region Ctor

        public GetProductQueryHandler(IProductService productService)
        {
            this._productService = productService;
        }

        #endregion Ctor

        #region Handle

        public async Task<IEnumerable<ProductVM>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var productVMList = await _productService.GetProduct().ConfigureAwait(false);

            return productVMList;
        }

        #endregion
    }
}
