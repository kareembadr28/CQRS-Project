
using CQRS_Project.Features.Product.Commands.CreateProduct;
using CQRS_Project.Features.Product.Commands.DeleteProduct;
using CQRS_Project.Features.Product.Commands.UpdateProduct;
using CQRS_Project.Features.Product.Queries.GetAllProducts;
using CQRS_Project.Features.Product.Queries.GetProductById;
using CQRS_Project.Repositories.Implementaion;
using CQRS_Project.Repositories.Interface;

namespace CQRS_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

            builder.Services.AddSingleton<IProductRepository, ProductRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapCreateProductEndPoint();
            app.MapDeleteProductEndPoint();
            app.MapUpdateProductCommandEndpoint();
            app.MapGetProductByIdEndPoint();
            app.MapGetAllProductsEndPoint();

            app.Run();
        }
    }
}
