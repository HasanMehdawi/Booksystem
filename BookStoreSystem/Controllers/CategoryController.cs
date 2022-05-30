using BookStoreSystem.Data;
using BookStoreSystem.Models;
using BookStoreSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
       
            ICategoryService categoryService;
            public CategoryController(ICategoryService _categoryService)
            {
                categoryService = _categoryService;
            }
            public IActionResult Index()
            {


                ViewData["index"] = true;
                vmCategory vm = new vmCategory();
                vm.licategory = categoryService.loadAll();
                return View("category", vm);
            }
            public IActionResult save(vmCategory vm)
            {
                categoryService.insert(vm.category);

                ViewData["index"] = true;
                vm.licategory = categoryService.loadAll();
                return View("category", vm);
            }
            public IActionResult delete(int id)
            {

                ViewData["index"] = true;
                categoryService.delete(id);
                vmCategory vm = new vmCategory();
                vm.licategory = categoryService.loadAll();
                return View("category", vm);
            }
            public IActionResult edit(int id)
            {
                Category ctgr = new Category();
                ctgr = categoryService.edit(id);
                return Json(ctgr);

            }
            public IActionResult Update(vmCategory vm)
            {
                categoryService.update(vm.category);
                ViewData["index"] = true;
                vm.licategory = categoryService.loadAll();
                return View("category", vm);
            }
        }
}
