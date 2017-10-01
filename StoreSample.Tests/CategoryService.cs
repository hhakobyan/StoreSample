namespace StoreSample.Tests
{
    using StoreSample.ServiceInterfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using StoreSample.DomainEntities;

    internal class TestCategoryService : ICategoryService
    {
        public Task<List<Category>> GetCategoriesAsync()
        {
            return Task.FromResult(new List<Category> { new Category { Name = "Cat 1" } });
        }
    }
}
