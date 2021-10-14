using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC
{
    public  class Comparer : IComparer<Category>
    {
        public int Compare(Category a, Category b)
        {
            int result=a.Ordering.CompareTo(b.Ordering);
            if (result == 0)
                result = a.Name.CompareTo(b.Name);
            return result;
        }


    }
}