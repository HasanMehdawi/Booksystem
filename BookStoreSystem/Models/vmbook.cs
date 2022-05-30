using BookStoreSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Models
{
    public class vmbook
    {
        public List<Book> liBook { get; set; }
        public Book book { get; set; }
        public List<Authors> liAuthors { get; set; }
        public List<Category> liCategory { get; set; }
    }
}
