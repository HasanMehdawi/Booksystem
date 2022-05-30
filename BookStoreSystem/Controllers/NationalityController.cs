using BookStoreSystem.Data;
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
    public class NationalityController : Controller
    {
        INationalityService nationality;
        public NationalityController(INationalityService _nationality)
        {
            nationality = _nationality;
        }
        public IActionResult Index()
        {
            return View("Nationality");
        }
        public IActionResult save(Nationality national)
        {
            nationality.save(national);
            return View("Nationality");
        }
    }
}
