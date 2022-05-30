using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Data
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string Year { get; set; }
        public double Price { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }
        public int Stock { get; set; }
        public Authors authors { get; set; }
        [ForeignKey("authors")]
        public int authors_ID { get; set; }
        public Category category { get; set; }
        [ForeignKey("category")]
        public int category_Id { get; set; }
    }
}
