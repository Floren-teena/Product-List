using ProductList.Models;

namespace ProductList.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
