namespace StoreSample.DomainInterfaces
{
    using StoreSample.DomainEntities;
    using System.Collections.Generic;

    public interface ICategoryRepository
    {
        IEnumerable<Category> Get();
    }
}