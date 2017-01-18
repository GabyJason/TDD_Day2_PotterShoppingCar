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
               
            return Convert.ToInt32(books.Sum(o=>o.Price)*CalcPrice(books.Count()));
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
