namespace StoreSample.Services
{
    using StoreSample.DomainEntities;
    using StoreSample.ServiceInterfaces;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class CategoryService : WebApiService, ICategoryService
    {
        public CategoryService()
            : base("Categories")
        {
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var result = await this.Client.GetAsync(string.Empty);
            return await result.HandleError().Content.ReadAsAsync<List<Category>>();
        }
    }
}