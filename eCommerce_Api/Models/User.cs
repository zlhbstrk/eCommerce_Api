using System;
using System.Collections.Generic;

namespace eCommerce_Api.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string County { get; set; }
        public string Password { get; set; }
    }
}
