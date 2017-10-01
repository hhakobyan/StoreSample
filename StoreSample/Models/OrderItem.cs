namespace StoreSample.Models
{
    using StoreSample.DomainEntities;

    public class OrderViewModel
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}