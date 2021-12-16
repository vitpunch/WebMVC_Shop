using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Parent { get; set; }
        public int Ordering { get; set; }
        public int Level { get; set; }
        public List<Product> Products { get; set; }
    }
}
