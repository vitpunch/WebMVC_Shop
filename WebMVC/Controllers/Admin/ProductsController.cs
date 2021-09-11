using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers.Admin
{
    public class Products : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}