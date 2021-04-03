using System.Collections.Generic;
using TaskProjectWebApp.Entities.Concrete;
using TaskProjectWebApp.Models;

namespace TaskProjectWebApp.Business.Abstract
{
    public interface IProductService
    {
        ProductListViewModel GetAll();

        ProductViewModel GetById(int id);

        ProductListViewModel GetByCategoryId(int id);

        
        bool UpdateProduct(ProductViewModel product);

        bool AddProduct(ProductViewModel product);
        void DeleteById(int id);
    }
}
