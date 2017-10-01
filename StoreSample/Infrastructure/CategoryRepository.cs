namespace StoreSample.Infrastructure
{
    using StoreSample.DomainInterfaces;
    using StoreSample.Entities;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreEntities db = new StoreEntities();

        public IEnumerable<DomainEntities.Category> Get()
        {
            return this.db.Categories.Select(c => new DomainEntities.Category { Id = c.Id, Name = c.Name });
        }
    }
}