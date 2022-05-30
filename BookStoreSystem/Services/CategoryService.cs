using BookStoreSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public class CategoryService: ICategoryService
    {
        BookContext context;
        public CategoryService(BookContext _context)
        {
            context = _context;

        }
        public void insert(Category category)
        {
            context.category.Add(category);
            context.SaveChanges();

        }
        public List<Category> loadAll()
        {
            List<Category> licatigory = new List<Category>();
            licatigory = context.category.ToList();
            return licatigory;
        }
        public void delete(int id)
        {
            Category ctgr = new Category();
            ctgr = context.category.Find(id);
            context.category.Remove(ctgr);
            context.SaveChanges();
        }
        public Category edit(int id)
        {
            Category ctgr = new Category();
            ctgr = context.category.Find(id);
            return ctgr;

        }
        public void update(Category category)
        {
            context.category.Attach(category);
            context.Entry(category).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
