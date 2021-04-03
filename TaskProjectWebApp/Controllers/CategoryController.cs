using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskProjectWebApp.Business.Abstract;
using TaskProjectWebApp.Entities.ViewModels;

namespace TaskProjectWebApp.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;
        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();          
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var isSuccessfull = _categoryManager.AddCategory(categoryViewModel);

                if (isSuccessfull)
                {
                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError("", "Bir hata oluştu!");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _categoryManager.GetById(id);

            if (category != null)
            {
                return View(category);
            }

            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public IActionResult Update(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var isSuccessfull = _categoryManager.UpdateCategory(model);

                if (isSuccessfull)
                {
                    return RedirectToAction("GetAllByCategoryId", "Product",new { id=model.Id});
                }

                ModelState.AddModelError("", "Bir hata oluştu!");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _categoryManager.Delete(id);
            return RedirectToAction("index", "Home");
        }

    }
}
