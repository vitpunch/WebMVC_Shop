using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Copiright { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string UrlMiniature { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
        public Product? Product { get; set; }
        public int ProductId { get; set; }
    }
}
