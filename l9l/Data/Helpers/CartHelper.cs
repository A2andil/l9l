using l9l.Models;
using l9l.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace l9l.Data.Helpers
{
    public class CartHelper
    {
        public SortedSet<int> _carItemsProductId;
        public List<CartItem> _cartItems;
        public Dictionary<int, CartItemViewModel> Map;
        public CartViewModel Cart;

        public CartHelper()
        {
            _carItemsProductId = new SortedSet<int>();
            Map = new Dictionary<int, CartItemViewModel>();
            Cart = new CartViewModel();
        }

        public void StoreProductIds(List<CartItem> cartItems)
        {
            _cartItems = cartItems;
            foreach (var item in _cartItems)
                _carItemsProductId.Add(item.ProductId);
        }

        public bool Contains(int Id)
        {
            return _carItemsProductId.Contains(Id); ;
        }

        public void StoreProduct(IEnumerable<Product> Products)
        {
            foreach (var productItem in Products)
            {
                Map[productItem.Id] = new CartItemViewModel
                {
                    ProductId = productItem.Id,
                    Name = productItem.Name,
                    Price = productItem.Price,
                    Image = productItem.ImageUrl
                };
            }
        }

        public void StoreCount(List<CartItem> cartitems)
        {
            _cartItems = cartitems;
            for (int i = 0; i < _cartItems.Count; i++)
                Map[_cartItems[i].ProductId].Count = _cartItems[i].Count;
        }


        public void FillCart()
        {
            foreach (var item in Map)
            {
                Cart.items.Add(item.Value);
                Cart.TotalPrice
                    += item.Value.Count * item.Value.Price;
            }
        }
    }
}
