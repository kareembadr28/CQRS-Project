using CQRS_Project.Models;

namespace CQRS_Project.Repositories.Interface
{
    public interface IProductRepository
    {
        List<product> GetAllProducts();
        product? GetProductById(int id);
        product CreateProduct(product product);
        product UpdateProduct(product product);
        bool DeleteProduct(int id);
    }
}
