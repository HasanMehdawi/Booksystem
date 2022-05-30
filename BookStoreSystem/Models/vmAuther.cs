using BookStoreSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Models
{
    public class vmAuther
    {

        public List<Authors> liauther { get; set; }
        public Authors authors { get; set; }
        public List<Nationality> linationality { get; set; }
    }
}
