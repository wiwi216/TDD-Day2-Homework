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
            if (this._books.Count > 1)
                return Convert.ToInt32(this._books.Count * 100 * 0.95);
            else
                return this._books.Count * 100;
        }

        public void AddToCart(IEnumerable<PotterBook> books)
        {
            this._books.AddRange(books);
        }
    }
}