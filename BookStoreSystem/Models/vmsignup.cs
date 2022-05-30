using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Models
{
    public class vmsignup
    {
        public SignupModel signup { get; set; }
        public List<IdentityRole> lirole { get; set; }
    }
}
