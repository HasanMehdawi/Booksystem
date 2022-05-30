using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Data
{
    public class BookContext:IdentityDbContext<Application>
    {
        IConfiguration config;
        public BookContext(IConfiguration _config)
        {
            config = _config;
        }
        public DbSet<Authors> authors { get; set; }
        public DbSet<Book> book { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Nationality> nationality { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("BookstoreConnecction"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
