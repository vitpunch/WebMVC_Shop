using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class CategoriesController : Controller
    {
        private MobileContext db;

        public CategoriesController(MobileContext context)
        {
            db = context;
        }

        public ActionResult List()
        {
            return View(db.Categories.ToList());
        }
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View();
        }
        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create Category";
            return View();
        }
        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.id = id;
            return View();
        }
        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
