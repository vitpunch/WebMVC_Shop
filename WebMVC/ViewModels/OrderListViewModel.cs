using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Routing.Matching;
using WebMVC.Models;

namespace WebMVC.ViewModels
{
    public class OrderListViewModel
    {
        public List<Product> phones { get; set; }
        public List<Order> orders { get; set; }
    }
}