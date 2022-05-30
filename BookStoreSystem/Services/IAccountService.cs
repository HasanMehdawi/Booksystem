using BookStoreSystem.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUser(SignupModel signup);
        Task<SignInResult> CheckPassword(SignInModel signin);
        Task<IdentityResult> newRole(RoleModel role);
        List<IdentityRole> GetRoles();
        Task LogOut();
    }
}
