﻿using MediatR;
using WebApplicationMediatR.Domain.Entity;
using WebApplicationMediatR.Domain;
using WebApplicationMediatR.ViewModels.ProductViewModels;

namespace WebApplicationMediatR.Application.Features.Queries.Products.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductVM>
    {
        #region Fields

        private readonly IProductRepository _productService;
        #endregion Fields

        #region Ctor

        public GetProductByIdQueryHandler(IProductRepository productService)
        {
            this._productService = productService;
        }

        #endregion Ctor

        #region Handle


        public async Task<ProductVM> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetProduct(request.ProductId, cancellationToken).ConfigureAwait(false);

            var productVM = CreateProductVM(product);

            return productVM;
        }

        #endregion

        #region Private

        private ProductVM CreateProductVM(Product products)
            => new ProductVM();


        #endregion Private

    }
}
