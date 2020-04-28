using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        public int UserId { get; set; }
    }
}
