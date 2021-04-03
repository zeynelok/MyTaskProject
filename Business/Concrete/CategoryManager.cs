using Business.Abstract;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new Result(true, "Kategori Eklendi");
        }

        public IResult Delete(int id)
        {
            if (_categoryDal.Get(x => x.Id == id) != null)
            {
                _categoryDal.Delete(x => x.Id == id);
                return new Result(true, "Kategori Silindi");
            }

            return new Result(false, "Kategori Bulunamadı!");
        }

        public IDataResult<List<Category>> GetAll()
        {

            return new DataResult<List<Category>>(_categoryDal.GetAll(), true, "Kategoriler Listelendi");
        }


        public IDataResult<Category> GetById(int categoryId)
        {
            return new DataResult<Category>(_categoryDal.Get(c => c.Id == categoryId), true);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new Result(true, "Kategori Güncellendi");
        }
    }
}
