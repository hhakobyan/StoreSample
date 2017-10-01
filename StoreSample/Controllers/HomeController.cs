namespace StoreSample.Controllers
{
    using StoreSample.ServiceInterfaces;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;

        public HomeController(ICategoryService categoryService, IProductService productService)
        {
            this.categoryService = categoryService;
            this.productService = productService;
        }

        public async Task<ActionResult> Index(int? categoryId)
        {
            this.ViewBag.Categories = await this.categoryService.GetCategoriesAsync();
            return this.View(await this.productService.GetProductsAsync(categoryId));
        }

        public async Task<ActionResult> ProductDetails(int id)
        {
            return this.View(await this.productService.GetProductAsync(id));
        }
    }
}