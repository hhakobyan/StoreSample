namespace StoreSample.Controllers
{
    using StoreSample.Models;
    using StoreSample.ServiceInterfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    public class ShoppingCardController : Controller
    {
        private readonly IProductService productService;

        public ShoppingCardController(IProductService productService)
        {
            this.productService = productService;
        }

        private List<OrderViewModel> ShoppingCard
        {
            get
            {
                return this.Session["ShoppingCard"] as List<OrderViewModel> ?? new List<OrderViewModel>();
            }

            set
            {
                this.Session["ShoppingCard"] = value;
            }
        }

        public ActionResult Index()
        {
            return this.View(this.ShoppingCard);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddToCard(int productId, int quantity)
        {
            var card = this.ShoppingCard;
            card.Add(new OrderViewModel
            {
                Product = await this.productService.GetProductAsync(productId),
                Quantity = quantity
            });

            this.ShoppingCard = card;
            return this.RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RemoveFromCard(int productId)
        {
            var card = this.ShoppingCard;
            card = card.Where(c => c.Product.Id != productId).ToList();
            this.ShoppingCard = card;
            return this.RedirectToAction("Index");
        }
    }
}