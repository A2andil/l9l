using l9l.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Data.ViewModels
{
    public class CartViewModel
    {
        public List<CartItemViewModel> items { get; set; }

        public double TotalPrice { get; set; }

        public int UserId { get; set; }

        public CartViewModel()
        {
            items = new List<CartItemViewModel>();
        }
    }
}
