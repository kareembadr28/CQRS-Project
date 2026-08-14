using CQRS_Project.Models;
using CQRS_Project.Repositories.Interface;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, Result<List<product>>>
    {
        private readonly IProductRepository _productRepository;
        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<Result<List<product>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var result = _productRepository.GetAllProducts();
            return Task.FromResult(Result<List<product>>.Success(result));
        }
    }
}
