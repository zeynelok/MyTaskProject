using System;
using System.Collections.Generic;
using System.Text;
using TaskProjectWebApp.Entities.Concrete;

namespace TaskProjectWebApp.Entities.JsonResults
{
    public class CategoryListResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Category[] Data { get; set; }
    }
}
