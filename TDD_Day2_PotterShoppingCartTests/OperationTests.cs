using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Day2_PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Day2_PotterShoppingCart.Tests
{
    [TestClass()]
    public class OperationTests
    {
        [TestMethod]
        public void Test_只買第一集()
        {
            //Arrange
            Operation target = new Operation();
            int expected = 100;

            //Act
            var Cart = new List<Book>();
            Cart.Add(new Book { StortName = "Harry Potter_Episode1", Quantity = 1, Price = 100 });

            var actual = target.CalcBook(Cart);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}