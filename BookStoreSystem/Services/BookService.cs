using BookStoreSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public class BookService : IBookService
    {
        BookContext context;
        public BookService(BookContext _context)
        {
            context = _context;
        }
        public List<Book> LoadBook()
        {
            List<Book> li = new List<Book>();
            li = context.book.Include("category").Include("authors").ToList() ;
            return li;

        }
        public List<Authors> LoadAuther()
        {
            List<Authors> li = new List<Authors>();
            li = context.authors.ToList();
            return li;

        }
        public List<Category> LoadCategory()
        {
            List<Category> li = new List<Category>();
            li = context.category.ToList();
            return li;

        }
        public void insert(Book book)
        {
            context.book.Add(book);
            context.SaveChanges();
        }
        public void delete(int id)
        {
            Book bk = new Book();
            bk = context.book.Find(id);
            context.book.Remove(bk);
        }
     
        public Book edit(int id)
        {
            Book book = new Book();
            book = context.book.Find(id);
            return book;
        }
        public void update(Book book)
        {
            context.book.Attach(book);
            context.Entry(book).State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
