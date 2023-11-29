using MediatR;
using WebApplicationMediatR.Domain;
using WebApplicationMediatR.Domain.Entity;

namespace WebApplicationMediatR.Application.Features.Products.Commands.ProductCommands.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    #region Fields

    private readonly IProductRepository _productRepository;
    #endregion Fields

    #region Ctor

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    #endregion Ctor

    #region Handle

    public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var createProduct = GenereateCreateProductFromaCommand(request);

        await _productRepository.CreateProduct(createProduct, cancellationToken).ConfigureAwait(false);

        return Unit.Value;
    }

    #endregion

    #region Private

    private Product GenereateCreateProductFromaCommand(CreateProductCommand command)
        => new Product()
        {
            //Map
        };

    #endregion Private

}
