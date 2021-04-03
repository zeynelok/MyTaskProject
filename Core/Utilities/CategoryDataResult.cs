using Entities.Concrete;

namespace Core.Utilities
{
    public class CategoryDataResult<T> : Result, IDataResult<T>
    {
        public Category Category { get; }
        public T Data { get; }
        public CategoryDataResult(Category category,T data, bool success, string message = null) : base(success, message)
        {
            Data = data;
            Category = category;
        }

    }
}
