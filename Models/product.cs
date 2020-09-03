using System;
using System.ComponentModel.DataAnnotations;

namespace Mercury.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
//id not Id