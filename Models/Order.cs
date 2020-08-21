using System;
using System.Collections.Generic;

namespace Mercury.Models
{
    public partial class Order
    {
        public int OId { get; set; }
        public int Id { get; set; }
        public int PId { get; set; }
        public int Quantity { get; set; }
    }
}
