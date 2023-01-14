using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
