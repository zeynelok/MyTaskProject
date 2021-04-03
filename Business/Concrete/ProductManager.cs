using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;

        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }
        public IResult Add(Product product)
        {
            product.CreateDate = DateTime.Now;
            _productDal.Add(product);
            return new Result(true,"Ürün Eklendi");
        }

        public IResult Delete(int id)
        {
            _productDal.Delete(x=>x.Id==id);
            return new Result(true, "Ürün Silindi");
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new DataResult<List<Product>>(_productDal.GetAll(),true, "Ürünler Listelendi");
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            var category = _categoryService.GetById(id).Data;
            var products = _productDal.GetAll(x => x.CategoryId == id);
            return new CategoryDataResult<List<Product>>(category,products, true, "Bu Kategorideki Ürünler Listelendi");
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new DataResult<Product>(_productDal.Get(x => x.Id == productId), true, "Seçili Ürün listelendi");
        }

       

        public IResult Update(Product product)
        {
            product.CreateDate = DateTime.Now;
            _productDal.Update(product);
            return new Result(true, "Ürün Güncellendi");
        }
    }
}
