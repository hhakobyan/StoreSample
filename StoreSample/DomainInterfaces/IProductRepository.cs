namespace StoreSample.DomainInterfaces
{
    using StoreSample.DomainEntities;
    using System.Collections.Generic;

    public interface IProductRepository
    {
        IEnumerable<Product> Get(int? categoryId);
        Product GetById(int id);
    }
}