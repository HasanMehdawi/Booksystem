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
    public class BookController : Controller
    {
        
      
            IBookService BService;
            public BookController(IBookService _BService)
            {
                BService = _BService;
            }
            public IActionResult Index()
            {
                vmbook vm = new vmbook();

            vm.liBook = BService.LoadBook();
            vm.liAuthors = BService.LoadAuther();
                vm.liCategory = BService.LoadCategory();
                return View("index", vm);
            }
            public IActionResult Save(Book book)
            {
                string name = Guid.NewGuid().ToString() + "." + book.Image.FileName.Split('.')[1];
                string P = Path.Combine(Directory.GetCurrentDirectory(), "Images", name);
                book.Image.CopyTo(new FileStream(P, FileMode.Create));
                book.ImagePath = "http://localhost/BookStoreSystem/staticPath/" + name;
                BService.insert(book);
                vmbook vm = new vmbook();
                vm.liAuthors = BService.LoadAuther();
                vm.liCategory = BService.LoadCategory();
                vm.liBook = BService.LoadBook();

                return View("index", vm);
            }
            public IActionResult delete(int id)
            {

                BService.delete(id);
                vmbook vm = new vmbook();
                vm.liAuthors = BService.LoadAuther();
                vm.liCategory = BService.LoadCategory();
                vm.liBook = BService.LoadBook();
                return View("index", vm);
            }
            public IActionResult edit(int id)
            {
                Book b = new Book();
                b= BService.edit(id);
            
                return Json(b);
            }
            public IActionResult update(Book book)
            {
                BService.update(book);
                vmbook vm = new vmbook();
                vm.liAuthors = BService.LoadAuther();
                vm.liCategory = BService.LoadCategory();
                vm.liBook = BService.LoadBook();
                return View("index", vm);
            }
        }
}
