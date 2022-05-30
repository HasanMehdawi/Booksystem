using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Models
{
    public class SignInModel
    {
        public string userName { get; set; }
        public string password { get; set; }
        public bool RememberMe { get; set; }
    }
}
