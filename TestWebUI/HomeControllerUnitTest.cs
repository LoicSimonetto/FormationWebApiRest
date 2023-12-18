using jeudontonestlehero.Web.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestWebUI
{
    [TestClass]
    public class HomeControllerUnitTest
    {
        [TestMethod]
        public void TestIndexIsOk()
        {

            HomeController controller = new HomeController();
            var result = controller.Index();

            Assert.IsInstanceOfType(result, typeof(ViewResult));

            ViewResult viewResult= (ViewResult)result;

            Assert.IsNotNull(viewResult.ViewData["Title"]);
            Assert.IsTrue(viewResult.ViewData["Title"]?.ToString() == "mon titre");
        }
    }
}