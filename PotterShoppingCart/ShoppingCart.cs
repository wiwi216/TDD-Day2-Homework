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
            if (this._books.Count > 1)
                return Convert.ToInt32(result * 0.95);
            else
                return result;
        }

        public void AddToCart(IEnumerable<PotterBook> books)
        {
            this._books.AddRange(books);
        }
    }
}