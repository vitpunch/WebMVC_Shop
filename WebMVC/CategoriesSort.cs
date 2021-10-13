using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC
{
    public class CategoriesSort
    {
        public List<Category> PrimarySort(List<Category> categories)
        {
            foreach (var category in categories)
            {
                if (category.Ordering != 0)
                {
                    categories.Sort(delegate(Category x, Category y)
                    {
                        return x.Ordering.CompareTo(y.Ordering);
                    });
                    return categories;
                }
            }

            List<Category> newCategoryList=new();
            foreach (var category in categories)
            {
                if (category.Parent == null)
                {
                    newCategoryList.Add(category);
                    newCategoryList.AddRange(FindChildren(categories,category.Id));
                }
            }

            return newCategoryList;
        }
        List<Category> FindChildren(List<Category> categories, int parent)
        {
            List<Category> children = new();
            foreach (var category in categories)
            {
                if(category.Parent==null)
                    continue;
                if (category.Parent.Id == parent)
                {
                    children.Add(category);
                    children.AddRange(FindChildren(categories,category.Id));
                }
            }
            return children;
        }
    }
}