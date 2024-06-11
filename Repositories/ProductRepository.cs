using ProductList.Interfaces;
using ProductList.Models;

namespace ProductList.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _product;
        public ProductRepository()
        {
            _product = new List<Product>()
            {
                new Product {Id = 1, Name = "CocaCola", Price = 2500.00M},
                new Product {Id = 2, Name = "Indomie Noodles", Price = 14500.00M},
                new Product { Id = 3, Name = "Hollandia Yoghurt", Price = 2000M}
            };
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _product;
        }

        public Product GetProductById(int id)
        {
            return _product.FirstOrDefault(p => p.Id == id);
        }
    }
}
