using CQRS_Project.Models;
using CQRS_Project.Repositories.Interface;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Result<product>>
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<Result<product>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var isExist = _productRepository.GetAllProducts().Any(p => p.Id == request.Id);
            if (!isExist) {
                return Task.FromResult(Result<product>.Failure(Error.NotFound("product not found")));
            }
            var product = new product
            {
                Id = request.Id,
                Name = request.Name
            };
            var result = _productRepository.UpdateProduct(product);
            return Task.FromResult(Result<product>.Success(result));
        }
    }
}
