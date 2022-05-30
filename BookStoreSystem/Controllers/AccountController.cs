using BookStoreSystem.Models;
using BookStoreSystem.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Controllers
{
    public class AccountController : Controller
    {
        IAccountService accountService;
        public AccountController(IAccountService _accountService)
        {
            accountService = _accountService;
        }
        public IActionResult Index()
        {
            vmsignup vm = new vmsignup();
            List<IdentityRole> li = accountService.GetRoles();
            vm.lirole = li;
            return View("Signup", vm); ;
        }
        public async Task<IActionResult> createAccount(SignupModel signup)
        {
            vmsignup vm = new vmsignup();
            List<IdentityRole> li = accountService.GetRoles();
            vm.lirole = li;
            var Result = await accountService.CreateUser(signup);
            return View("Signup", vm);
        }
        public IActionResult login()
        {
            return View();
        }
        public async Task<IActionResult> checkPassword(SignInModel signIn)
        {
            var Result = await accountService.CheckPassword(signIn);
            if (Result.Succeeded)
            {
                return RedirectToAction("index", "category");
            }
            else
            {
                return View();

            }
        }
        public IActionResult NewRole()
        {

            return View();
        }
        public async Task<IActionResult> SaveRole(RoleModel roleModel)
        {
            var Result = await accountService.newRole(roleModel);
            return View("NewRole");
        }
        public async Task<IActionResult> LogOut()
        {
            await accountService.LogOut();
            return View("login");
        }
    }
}
