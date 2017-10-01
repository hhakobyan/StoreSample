namespace StoreSample.ServiceInterfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using StoreSample.DomainEntities;

    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();
    }
}