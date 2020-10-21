using System;
using System.Collections.Generic;

namespace eCommerce_Api.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? RefId { get; set; }
    }
}
