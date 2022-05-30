using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Data
{
    public class Category
    {
        public int id { get; set; }
        [Required]
        public string Category_Code { get; set; }
        [Required]
        public string Category_Name { get; set; }
        public List<Book> liBook { get; set; }
    }
}
