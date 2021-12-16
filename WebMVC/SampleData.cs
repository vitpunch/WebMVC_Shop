using System.Collections.Generic;
using System.Linq;
using WebMVC.Models;

namespace WebMVC
{
    public class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Category smartphones = new Category { Name = "Смартфоны" };
            Category lopats =new Category{Name = "Лопаты"};
            context.Categories.AddRange(smartphones,lopats);
            context.SaveChanges();

            Product samsung = new Product { Name = "samsung", Categories = new List<Category>{ lopats, smartphones } };
            Product huawey = new Product { Name = "Huawei", Categories = new List<Category> { smartphones } };
            Product vivo = new Product { Name = "vivo", Price = 2500, Categories = new List<Category> { lopats } };
            context.Products.AddRange(huawey,samsung,vivo);
            context.SaveChanges();



        }
    }
}