using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers.Admin
{
    public class ImagesController : Controller
    {
        MobileContext db;
        public ImagesController(MobileContext context)
        {
            db = context;
        }
        // GET
        public IActionResult List()
        {
            return View(db.Images.ToList());
        }
    }
}