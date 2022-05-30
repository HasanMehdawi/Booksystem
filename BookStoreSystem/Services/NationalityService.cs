using BookStoreSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public class NationalityService:INationalityService
    {
        BookContext context;
        public NationalityService(BookContext _context)
        {
            context = _context;
        }
        public void save(Nationality national)
        {
            context.nationality.Add(national);
            context.SaveChanges();
        }
    }
}
