using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Error()
        {
            return View("Error");
        }

        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
