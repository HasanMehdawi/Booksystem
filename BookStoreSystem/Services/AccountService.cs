using BookStoreSystem.Data;
using BookStoreSystem.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public class AccountService : IAccountService
    {
        UserManager<Application> userManager;
        SignInManager<Application> signInmanager;
        RoleManager<IdentityRole> roleManager;
        public AccountService(UserManager<Application> _userManager, SignInManager<Application> _signin, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            signInmanager = _signin;
            roleManager = _roleManager;
        }
        public async Task<IdentityResult> CreateUser(SignupModel signup)
        {
            Application application = new Application();
            application.Name = signup.Name;
            application.Email = signup.Email;
            application.UserName = signup.Email;
            var Result = await userManager.CreateAsync(application, signup.Password);
            if (Result.Succeeded)
            {
                var rol = await roleManager.FindByIdAsync(signup.Role_id);
                Result = await userManager.AddToRoleAsync(application, rol.Name);

            }
            return Result;
        }
        public async Task<SignInResult> CheckPassword(SignInModel signin)
        {
            var Result = await signInmanager.PasswordSignInAsync(signin.userName, signin.password, signin.RememberMe, false);
            return Result;
        }
        public async Task<IdentityResult> newRole(RoleModel role)
        {
            IdentityRole identityRole = new IdentityRole();
            identityRole.Name = role.Name;
            var Result = await roleManager.CreateAsync(identityRole);
            return Result;
        }
        public List<IdentityRole> GetRoles()
        {
            List<IdentityRole> liRole = roleManager.Roles.ToList();
            return liRole;
        }
        public async Task LogOut()
        {
            await signInmanager.SignOutAsync();
        }
    }
}
