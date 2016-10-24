﻿using System;
using System.Collections.Generic;
using System.Linq;

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
            int result = this._books.Select(x => x.Episode).Distinct().Count() * 100;
            double discount = GetDiscount();
            return Convert.ToInt32(result * discount + (this._books.Count - this._books.Select(x => x.Episode).Distinct().Count()) * 100);
        }

        private double GetDiscount()
        {
            double discount = 1.00;
            switch (this._books.Select(x => x.Episode).Distinct().Count())
            {
                case 2:
                    discount = 0.95;
                    break;
                case 3:
                    discount = 0.9;
                    break;
                case 4:
                    discount = 0.8;
                    break;
                case 5:
                    discount = 0.75;
                    break;
                default:
                    break;
            }

            return discount;
        }

        public void AddToCart(IEnumerable<PotterBook> books)
        {
            this._books.AddRange(books);
        }
    }
}