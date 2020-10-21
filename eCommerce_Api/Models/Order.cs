using System;
using System.Collections.Generic;

namespace eCommerce_Api.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CartId { get; set; }
        public int? Price { get; set; }
        public string Note { get; set; }
        public DateTime? Date { get; set; }
    }
}
