using CQRS_Project.Features.Product.Events.CreateProduct;
using CQRS_Project.Models;
using CQRS_Project.Repositories.Interface;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Result<product>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;
        public CreateProductCommandHandler(IProductRepository productRepository, IMediator mediator)
        {
            _productRepository = productRepository;
            _mediator = mediator;
        }
        public Task<Result<product>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            if(string.IsNullOrEmpty(request.Name))
            {
                return Task.FromResult(Result<product>.Failure(Error.Validation("Name is required")));
            }
            var isExist = _productRepository.GetAllProducts().Any(p => p.Name == request.Name);
            if (isExist)
            {
                return Task.FromResult(Result<product>.Failure(Error.Conflict("product with the same name is Exist")));
            }
            var product =new product
            {
                Id = new Random().Next(1, 10000),
                Name = request.Name
            };
          var result= _productRepository.CreateProduct(product);
            _mediator.Publish(new CreateProductEvent (result.Id,result.Name), cancellationToken);
            return Task.FromResult(Result<product>.Success(result));


        }
    }
}
