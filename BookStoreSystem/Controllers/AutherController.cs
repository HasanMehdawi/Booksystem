using BookStoreSystem.Data;
using BookStoreSystem.Models;
using BookStoreSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AutherController : Controller
    {
        IAutherService autherService;
        public AutherController(IAutherService _autherService)
        {
            autherService = _autherService;

        }
        public IActionResult Index()
        {
            vmAuther vm = new vmAuther();
            vm.liauther = autherService.LoadAll();
            vm.linationality = autherService.loadNationality();
            return View("Auther", vm);
        }
        public IActionResult save(vmAuther vm)
        {
            string name = Guid.NewGuid().ToString() + "." + vm.authors.Image.FileName.Split('.')[1];
            string P = Path.Combine(Directory.GetCurrentDirectory(),"Images",name);
            vm.authors.Image.CopyTo(new FileStream(P, FileMode.Create));
            vm.authors.ImagePath = "http://localhost/BookStoreSystem/staticPath/" + name;
            autherService.insert(vm.authors);
            vm.liauther = autherService.LoadAll();
            vm.linationality = autherService.loadNationality();
            return View("Auther", vm);
        }
        public IActionResult edit(int id)
        {
            Authors authors = new Authors();
            authors = autherService.edit(id);
            return Json(authors);
        }
        public IActionResult delete(int id)
        {
            autherService.delete(id);
            vmAuther vm = new vmAuther();
            vm.liauther = autherService.LoadAll();
            vm.linationality = autherService.loadNationality();
            return View("Auther", vm);
        }
        public IActionResult update(vmAuther vm)
        {
           
            autherService.update(vm.authors);
            vm.liauther = autherService.LoadAll();

            vm.linationality = autherService.loadNationality();
            return View("Auther", vm);
        }
    }
}
