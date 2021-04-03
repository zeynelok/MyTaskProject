using System;
using System.Collections.Generic;
using System.Text;
using TaskProjectWebApp.Entities.Concrete;

namespace TaskProjectWebApp.Entities.JsonResults
{
   public class ProductResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public Product Data { get; set; }
    }
}
