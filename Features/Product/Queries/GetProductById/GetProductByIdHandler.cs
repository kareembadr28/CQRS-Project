using CQRS_Project.Models;
using CQRS_Project.Repositories.Interface;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Queries.GetProductById
{
    public class GetProductByIdHandler : IRequestHandler<GetProductById, Result<product>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByIdHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<Result<product>> Handle(GetProductById request, CancellationToken cancellationToken)
        {
           var result = _productRepository.GetProductById(request.Id);
            if(result == null)
                return Task.FromResult(Result<product>.Failure(Error.NotFound("product not found")));
            return Task.FromResult(Result<product>.Success(result));
        }
    }
}
