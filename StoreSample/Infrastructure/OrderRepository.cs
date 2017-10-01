namespace StoreSample.Infrastructure
{
    using StoreSample.DomainInterfaces;
    using StoreSample.Entities;
    using System;
    using System.Linq;
    public class OrderRepository : IOrderRepository
    {
        private readonly StoreEntities db = new StoreEntities();

        public void Add(DomainEntities.Order order)
        {
            this.db.Orders.Add(new Order
            {
                Address = order.Address,
                City = order.City,
                Country = order.Country,
                Email = order.Email,
                FirstName = order.FirstName,
                LastName = order.LastName,
                OrderDate = DateTime.UtcNow,
                Phone = order.Phone,
                PostalCode = order.PostalCode,
                State = order.State,
                OrderProducts = order.Products
                    .GroupBy(p => p.ProductId)
                    .Select(g => new OrderProduct { ProductId = g.Key, Quantity = g.Sum(p => p.Quantity) })
                    .ToList()
            });

            this.db.SaveChanges();
        }
    }
}