namespace StoreSample.DomainInterfaces
{
    using StoreSample.DomainEntities;

    public interface IOrderRepository
    {
        void Add(Order order);
    }
}