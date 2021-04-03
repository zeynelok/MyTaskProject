using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskProjectWebApp.Entities.Concrete;

namespace TaskProjectWebApp.Entities.ViewModels
{
    public class CategoryListViewModel
    {
        public string Message { get; set; }
        public IList<Category> Data { get; set; }

        public CategoryListViewModel()
        {
            Data = new List<Category>();
        }
    }
}
