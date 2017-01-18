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
            return books.Sum(o=>o.Price);
        }
    }
}
