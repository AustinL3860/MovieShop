using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class Controller1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
