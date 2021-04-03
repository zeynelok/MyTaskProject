using System;
using System.Collections.Generic;
using System.Text;
using TaskProjectWebApp.Entities.Concrete;

namespace TaskProjectWebApp.Entities.JsonResults
{
    public class ProductListResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public Product[] Data { get; set; }
        public Category Category { get; set; }
    }
}
