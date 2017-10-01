namespace StoreSample.Services
{
    using StoreSample.DomainEntities;
    using StoreSample.ServiceInterfaces;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ProductService : WebApiService, IProductService
    {
        public ProductService()
            : base("Products")
        {
        }

        public async Task<List<Product>> GetProductsAsync(int? categoryId)
        {
            var result = await this.Client.GetAsync($"?categoryId={categoryId}");
            return await result.HandleError().Content.ReadAsAsync<List<Product>>();
        }

        public async Task<Product> GetProductAsync(int id)
        {
            var result = await this.Client.GetAsync($"{id}");
            return await result.HandleError().Content.ReadAsAsync<Product>();
        }
    }
}