using System;
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
            int result = 0;
            while (this._books.Count > 0)
            {
                List<PotterBook> booksForCharge = this._books.GroupBy(x => x.Episode).Select(x => x.First()).ToList();
                int partResult = booksForCharge.Count * 100;
                double discount = GetDiscountByCount(booksForCharge.Count);
                result += Convert.ToInt32(partResult * discount);

                foreach (var book in booksForCharge)
                {
                    this._books.Remove(book);
                }
            }
            return result;
        }
        
        private double GetDiscountByCount(int count)
        {
            double discount = 1.00;
            switch (count)
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