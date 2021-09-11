using System.Collections.Generic;

namespace WebMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
        public List<Image> Images { get; set; }

    }
}