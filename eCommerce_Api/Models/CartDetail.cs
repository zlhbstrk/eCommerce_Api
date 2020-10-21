using System;
using System.Collections.Generic;

namespace eCommerce_Api.Models
{
    public partial class CartDetail
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
    }
}
