using Microsoft.AspNetCore.Mvc;

namespace IEvolveSystem.UI.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
