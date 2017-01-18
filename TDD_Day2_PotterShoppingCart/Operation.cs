using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Day2_PotterShoppingCart
{
    public class Operation
    {
        public int CalcBook(IEnumerable<Book> books)
        {
            int Price = 0;
            var _books = new List<Book>();

            //Quantity本數至少大於一本
            while (books.Any(x => x.Quantity > 0))
            {
                foreach (var book in books)
                {
                    //算出折扣金額
                    Price += Convert.ToInt32(book.Price * CalcPrice(books.Count()));

                    book.Quantity = book.Quantity - 1;
                    //如果Quantity不只一本，將加入book原價
                    if (book.Quantity > 0)
                    {
                        _books.Add(book);
                    }
                    Price += CalcBook(_books);
                }
            }
            return Price;
        }
        /// <summary>
        /// 依不同級別折扣
        /// </summary>
        /// <param name="CalcPrice"></param>
        /// <returns></returns>
        private double CalcPrice(int Quantity)
        {

            if (Quantity == 2)
            {
                return 0.95;
            }
            else if (Quantity==3)
            {
                return 0.9;
            }
            else if (Quantity == 4)
            {
                return 0.8;
            }
            else if (Quantity >=5)
            {
                return 0.75;
            }        
            return 1;

        }
    }
}
