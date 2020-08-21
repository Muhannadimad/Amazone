using System;
using System.Collections.Generic;

namespace Mercury.Models
{
    public partial class Product
    {
        public int PId { get; set; }
        public int PPrice { get; set; }
        public int PQuantity { get; set; }
        public string PDescription { get; set; }
        public string PImage { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
