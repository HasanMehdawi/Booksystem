using BookStoreSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public class AutherService : IAutherService
    {
        BookContext context;
        public AutherService(BookContext _context)
        {
            context = _context;
        }
        public void insert(Authors authors)
        {
            context.authors.Add(authors);
            context.SaveChanges();
        }
        public List<Nationality> loadNationality()
        {
            List<Nationality> li = new List<Nationality>();
            li = context.nationality.ToList();
            return li;
        }
        public List<Authors> LoadAll()
        {
            List<Authors> li = new List<Authors>();
            li = context.authors.ToList();
            return li;

        }
        public void delete(int id)
        {
            Authors author = new Authors();
            author = context.authors.Find(id);
            context.authors.Remove(author);
            context.SaveChanges();
        }
        public Authors edit(int id)
        {
            Authors author = new Authors();
            author = context.authors.Find(id);
            return author;
        }
        public void update(Authors author)
        {
            context.authors.Attach(author);
            context.Entry(author).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
