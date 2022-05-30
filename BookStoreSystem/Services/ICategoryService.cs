using BookStoreSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public interface ICategoryService
    {
        void insert(Category category);
        List<Category> loadAll();
        void delete(int id);
        Category edit(int id);
        void update(Category category);
    }
}
