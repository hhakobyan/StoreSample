namespace StoreSample.Api
{
    using System.Collections.Generic;
    using System.Web.Http;

    using StoreSample.DomainEntities;
    using StoreSample.DomainInterfaces;

    public class ProductsController : ApiController
    {
        private readonly IProductRepository repo;

        public ProductsController(IProductRepository repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Product> Get(int? categoryId = null)
        {
            return this.repo.Get(categoryId);
        }

        public Product Get(int id)
        {
            return this.repo.GetById(id);
        }
    }
}