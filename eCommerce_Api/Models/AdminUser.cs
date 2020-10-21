using System;
using System.Collections.Generic;

namespace eCommerce_Api.Models
{
    public partial class AdminUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
    }
}
