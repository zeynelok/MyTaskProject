using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskProjectWebApp.Entities.Concrete;
using TaskProjectWebApp.Entities.ViewModels;

namespace TaskProjectWebApp.Models
{
    public class ProductListViewModel
    {
        public string Message { get; set; }
        public IList<Product> Data { get; set; }

        public Category Category { get; set; }

        public ProductListViewModel()
        {
            Data = new List<Product>();
        }
    }
}
