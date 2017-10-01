namespace StoreSample.Infrastructure
{
    using StoreSample.DomainInterfaces;
    using StoreSample.Entities;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductRepository : IProductRepository
    {
        private readonly StoreEntities db = new StoreEntities();

        public IEnumerable<DomainEntities.Product> Get(int? categoryId)
        {
            var products = this.db.Products.AsQueryable();
            if (categoryId != null)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value);
            }

            return products.Select(c => new DomainEntities.Product
            {
                Id = c.Id,
                Name = c.Name,
                CategoryId = c.CategoryId,
                Description = c.Description,
                ImageUrl = c.ImageUrl,
                Price = c.Price,
                CategoryName = c.Category.Name
            });
        }

        public DomainEntities.Product GetById(int id)
        {
            return this.db.Products.Select(c => new DomainEntities.Product
            {
                Id = c.Id,
                Name = c.Name,
                CategoryId = c.CategoryId,
                Description = c.Description,
                ImageUrl = c.ImageUrl,
                Price = c.Price,
                CategoryName = c.Category.Name
            }).SingleOrDefault(c => c.Id == id);
        }
    }
}