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

        public object Billing()
        {
            return this._books.Count * 100;
        }

        public void AddToCart(List<PotterBook> books)
        {
            throw new NotImplementedException();
        }
    }
}