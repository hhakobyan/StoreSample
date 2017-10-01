namespace StoreSample.Services
{
    using StoreSample.DomainEntities;
    using StoreSample.ServiceInterfaces;
    using System.Net.Http;
    using System.Threading.Tasks;
    public class OrderService : WebApiService, IOrderService
    {
        public OrderService()
            : base("Orders")
        {
        }

        public async Task AddOrderAsync(Order order)
        {
            var result = await this.Client.PostAsJsonAsync(string.Empty, order);
            result.HandleError();
        }
    }
}