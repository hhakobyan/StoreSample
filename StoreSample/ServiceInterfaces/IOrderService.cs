namespace StoreSample.ServiceInterfaces
{
    using System.Threading.Tasks;
    using StoreSample.DomainEntities;

    public interface IOrderService
    {
        Task AddOrderAsync(Order order);
    }
}