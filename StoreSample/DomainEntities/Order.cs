namespace StoreSample.DomainEntities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        [Display(Name = "First Name")]
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Display(Name = "E-mail")]
        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(50)]
        public string PostalCode { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        public List<OrderProduct> Products { get; set; }
    }

    public class OrderProduct
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}