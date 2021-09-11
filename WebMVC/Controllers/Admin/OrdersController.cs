using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using WebMVC.ViewModels;

namespace WebMVC.Controllers.Admin
{
    public class OrdersController : Controller
    {
        MobileContext db;
        public OrdersController(MobileContext context)
        {
            db = context;
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            OrderListViewModel orderlistview = new OrderListViewModel();
            orderlistview.orders = db.Orders.ToList();
            orderlistview.phones = db.Products.ToList();
            return View(orderlistview);
        }
    }
}