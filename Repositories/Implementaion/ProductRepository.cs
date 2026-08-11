using CQRS_Project.Models;
using CQRS_Project.Repositories.Interface;

namespace CQRS_Project.Repositories.Implementaion
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<product> _products =
            [
                new product
        {
            Id = 1,
            Name = "Laptop",
        },
        new product
        {
            Id = 2,
            Name = "Mouse",
        }
            ];

        public product CreateProduct(product product)
        {
            _products.Add(product);
            return product;
        }

        public bool DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
                return true;
            }
            return false;
        }

        public List<product> GetAllProducts()
        {
            return _products;
        }

        public product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public product UpdateProduct(product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
            }
            return existingProduct;
        }
    }
}
