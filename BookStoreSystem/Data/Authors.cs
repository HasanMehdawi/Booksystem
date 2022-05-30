using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Data
{
    public class Authors
    {
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        public string LName { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }
        public Nationality national { get; set; }
        [ForeignKey("national")]
        public int National_Id { get; set; }
        public List<Book> liBook { get; set; }
    }
}
