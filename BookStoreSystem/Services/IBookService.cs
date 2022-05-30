using BookStoreSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public interface IBookService
    {
        List<Authors> LoadAuther();
        List<Category> LoadCategory();
        List<Book> LoadBook();
        void insert(Book book);
        void delete(int id);
        Book edit(int id);
        void update(Book book);
    }
}
