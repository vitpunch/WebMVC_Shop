using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC.Helpers
{
    public class CategoriesSort
    {
        private readonly Comparer _comparer = new();
        public List<Category> HierarchyListSort(List<Category> categories)
        {
            List<Category> resultList = new();
            resultList.AddRange(FindChildren(categories, 0));
            return resultList;
        }
        IEnumerable<Category> FindChildren(List<Category> categories, int parent)
        {
            List<Category> children = new();
            List<Category> result = new();
            foreach (var category in categories)
            {
                if (category.Parent == null)
                {
                    if(parent==0)
                        children.Add(category);
                    continue;
                }
                if (category.Parent.Id == parent)
                {
                    children.Add(category);
                }
            }
            children.Sort(_comparer);
            foreach (var recurentChild in children)
            {
                result.Add(recurentChild);
                result.AddRange(FindChildren(categories,recurentChild.Id));
            }
            return result;
        }
    }
}