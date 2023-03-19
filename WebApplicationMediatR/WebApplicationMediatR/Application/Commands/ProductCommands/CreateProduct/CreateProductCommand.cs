using MediatR;

namespace WebApplicationMediatR.Application.Commands.ProductCommands.CreateProduct
{
    public class CreateProductCommand : IRequest
    {
        public string ProductTitle { get; set; }

        public string ProductName { get; set; }
    }
}
