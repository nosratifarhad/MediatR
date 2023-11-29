using MediatR;
using WebApplicationMediatR.Domain.Entity;
using WebApplicationMediatR.Domain;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Application.Features.Products.Queries.Products.GetProduct;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, IEnumerable<ProductVM>>
{
    #region Fields

    private readonly IProductRepository _productService;
    #endregion Fields

    #region Ctor

    public GetProductQueryHandler(IProductRepository productService)
    {
        _productService = productService;
    }

    #endregion Ctor

    #region Handle

    public async Task<IEnumerable<ProductVM>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var products = await _productService.GetProduct(cancellationToken).ConfigureAwait(false);

        var productVMs = CreateProductVM(products);

        return productVMs;
    }

    #endregion

    #region Private

    private IEnumerable<ProductVM> CreateProductVM(IEnumerable<Product> products)
    {
        IEnumerable<ProductVM> productVMs = new List<ProductVM>();
        foreach (var product in products)
            new List<ProductVM>();

        return productVMs;
    }

    #endregion Private
}
