using MediatR;
using WebApplicationMediatR.Dtos;
using WebApplicationMediatR.Service.Contracts;

namespace WebApplicationMediatR.Application.Commands.ProductCommands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        #region Fields

        private readonly IProductService _productService;
        #endregion Fields

        #region Ctor

        public CreateProductCommandHandler(IProductService productService)
        {
            this._productService = productService;
        }

        #endregion Ctor

        #region Handle

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var createProductDto = GenereateCreateProductDtoFromaCommand(request);

            await _productService.CreateProduct(createProductDto).ConfigureAwait(false);

            return Unit.Value;
        }
        #endregion

        #region Private

        private CreateProductDto GenereateCreateProductDtoFromaCommand(CreateProductCommand command)
            => new CreateProductDto()
            {
                //Map Prop
            };

        #endregion Private
    }
}
