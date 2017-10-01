namespace StoreSample.ServiceInterfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using StoreSample.DomainEntities;

    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync(int? categoryId);

        Task<Product> GetProductAsync(int id);
    }
}