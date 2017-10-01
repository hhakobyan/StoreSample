namespace StoreSample.Api
{
    using StoreSample.DomainEntities;
    using StoreSample.DomainInterfaces;
    using System.Web.Http;

    public class OrdersController : ApiController
    {
        private readonly IOrderRepository repo;

        public OrdersController(IOrderRepository repo)
        {
            this.repo = repo;
        }

        public void Post([FromBody]Order order)
        {
            this.repo.Add(order);
        }
    }
}
