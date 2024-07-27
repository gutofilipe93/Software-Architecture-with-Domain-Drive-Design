using Microsoft.AspNetCore.Mvc;

namespace IEvolveSystem.UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
