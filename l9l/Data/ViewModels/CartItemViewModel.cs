using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Data.ViewModels
{
    public class CartItemViewModel
    {
        public string Image { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

        public int ProductId { get; set; }
    }
}
