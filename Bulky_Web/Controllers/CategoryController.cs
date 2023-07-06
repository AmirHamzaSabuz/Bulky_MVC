using Microsoft.AspNetCore.Mvc;

namespace Bulky_Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
