using System;
using System.Collections.Generic;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        private List<PotterBook> _books;

        public ShoppingCart()
        {
            this._books = new List<PotterBook>();
        }

        public void AddToCart(PotterBook book)
        {
            this._books.Add(book);
        }

        public int Billing()
        {
            int result = this._books.Count * 100;
            switch (this._books.Count)
            {
                case 1:
                    return result;
                case 2:
                    return Convert.ToInt32(result * 0.95);
                case 3:
                    return Convert.ToInt32(result * 0.9);
                case 4:
                    return Convert.ToInt32(result * 0.8);
                default:
                    return result;
            }
        }

        public void AddToCart(IEnumerable<PotterBook> books)
        {
            this._books.AddRange(books);
        }
    }
}