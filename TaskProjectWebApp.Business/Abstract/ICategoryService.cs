using System;
using System.Collections.Generic;
using System.Text;
using TaskProjectWebApp.Entities.ViewModels;

namespace TaskProjectWebApp.Business.Abstract
{
    public interface ICategoryService
    {
        CategoryListViewModel GetAll();
        CategoryViewModel GetById(int id);
        bool AddCategory(CategoryViewModel categoryViewModel);
        bool UpdateCategory(CategoryViewModel categoryViewModel);
        bool Delete(int id);
    }
}
