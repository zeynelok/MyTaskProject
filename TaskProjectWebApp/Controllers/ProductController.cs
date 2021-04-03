using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskProjectWebApp.Business.Abstract;
using TaskProjectWebApp.Models;

namespace TaskProjectWebApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productManager;

        public ProductController(IProductService productManager)
        {

            _productManager = productManager;
        }


        [HttpGet]
        public IActionResult AddProduct(int categoryId)
        {
            var model = new ProductViewModel();
            model.CategoryId = categoryId;
            return View(model);

        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var isSuccessfull = _productManager.AddProduct(productViewModel);

                if (isSuccessfull)
                {
                    return RedirectToAction("GetAllByCategoryId", "Product", new { id = productViewModel.CategoryId });
                }

                ModelState.AddModelError("", "Bir hata oluştu!");
            }

            return View();
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _productManager.GetById(id);

            if (product != null)
            {
                return View(product);
            }

            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public IActionResult Update(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var isSuccessfull = _productManager.UpdateProduct(model);

                if (isSuccessfull)
                {
                    return RedirectToAction("GetAllByCategoryId", "Product", new { id = model.CategoryId });
                }

                ModelState.AddModelError("", "Bir hata oluştu!");
            }

            return View();
        }


        public IActionResult Delete(int id,int categoryId)
        {

            _productManager.DeleteById(id);

            return RedirectToAction("GetAllByCategoryId", "Product", new { id = categoryId });
        }

        public IActionResult GetAllByCategoryId(int id)
        {
            return View(_productManager.GetByCategoryId(id));
        }
    }
}
