using CQRS_Project.Models;
using CQRS_Project.Repositories.Interface;
using MediatR;

namespace CQRS_Project.Features.Product.Queries.GetProductById
{
    public class GetProductByIdHandler : IRequestHandler<GetProductById, product>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByIdHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<product> Handle(GetProductById request, CancellationToken cancellationToken)
        {
           var result = _productRepository.GetProductById(request.Id);
            return Task.FromResult(result);
        }
    }
}
