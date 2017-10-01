namespace StoreSample.Controllers
{
    using StoreSample.DomainEntities;
    using StoreSample.Models;
    using StoreSample.ServiceInterfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    public class PaymentController : Controller
    {
        private readonly IOrderService orderService;

        public PaymentController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        private List<OrderViewModel> ShoppingCard
        {
            get
            {
                return this.Session["ShoppingCard"] as List<OrderViewModel> ?? new List<OrderViewModel>();
            }
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Order model)
        {
            if (!this.ShoppingCard.Any())
            {
                this.ModelState.AddModelError(string.Empty, "Shopping card is empty.");
            }

            if (!this.ModelState.IsValid)
            {
                return View();
            }

            model.Products = this.ShoppingCard
                .Select(p => new OrderProduct { ProductId = p.Product.Id, Quantity = p.Quantity })
                .ToList();

            await this.orderService.AddOrderAsync(model);
            this.Session.Remove("ShoppingCard");
            return this.RedirectToAction("Index", "Home");
        }
    }
}