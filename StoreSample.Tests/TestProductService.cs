namespace StoreSample.Tests
{
    using StoreSample.ServiceInterfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using StoreSample.DomainEntities;
    internal class TestProductService : IProductService
    {
        public Task<Product> GetProductAsync(int id)
        {
            return Task.FromResult(new Product { Name = "Product 1" });
        }

        public Task<List<Product>> GetProductsAsync(int? categoryId)
        {
            return Task.FromResult(new List<Product> {
                new Product { Name = "Product 1" },
                new Product { Name = "Product 2" }
            });
        }
    }
}
