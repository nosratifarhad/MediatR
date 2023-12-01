using MediatR;

namespace WebApplicationMediatR.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommand : IRequest
{
    public string ProductTitle { get; set; }

    public string ProductName { get; set; }
}
