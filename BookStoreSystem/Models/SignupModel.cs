using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Models
{
    public class SignupModel
    {
        [Required]
        public String Name { get; set; }
        [Required]
        public String Email { get; set; }
        [Compare("ConfirmPassword")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string Role_id { get; set; }
    }
}
