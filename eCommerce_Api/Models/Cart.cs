using System;
using System.Collections.Generic;

namespace eCommerce_Api.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public decimal? Price { get; set; }
    }
}
