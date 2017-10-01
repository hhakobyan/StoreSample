namespace StoreSample.Api
{
    using System.Collections.Generic;
    using System.Web.Http;

    using StoreSample.DomainEntities;
    using StoreSample.DomainInterfaces;

    public class CategoriesController : ApiController
    {
        private readonly ICategoryRepository repo;

        public CategoriesController(ICategoryRepository repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Category> Get()
        {
            return this.repo.Get();
        }
    }
}