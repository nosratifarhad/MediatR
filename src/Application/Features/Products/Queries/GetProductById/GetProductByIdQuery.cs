﻿using MediatR;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Application.Features.Products.Queries.GetProductById;

public class GetProductByIdQuery : IRequest<ProductVM>
{
    public int ProductId { get; set; }

}
