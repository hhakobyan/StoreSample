namespace StoreSample.Tests.Controllers
{
    using System.Web.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StoreSample.Controllers;

    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(new TestCategoryService(), new TestProductService());

            // Act
            ViewResult result = controller.Index(null).Result as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductDetails()
        {
            // Arrange
            HomeController controller = new HomeController(new TestCategoryService(), new TestProductService());

            // Act
            ViewResult result = controller.ProductDetails(1).Result as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
