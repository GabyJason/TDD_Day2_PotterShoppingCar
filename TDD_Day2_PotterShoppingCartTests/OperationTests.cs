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
        [TestMethod]
        public void Test_第一集跟第二集各買一本()
        {
            //Arrange
            Operation target = new Operation();
            int expected = 190;

            //Atc
            var Cart = new List<Book>();
            Cart.Add(new Book { StortName = "Harry Potter_Episode1", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode2", Quantity = 1, Price = 100 });


            int actual = target.CalcBook(Cart);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_一二三集各買一本()
        {
            //Arrange
            Operation target = new Operation();
            int expected = 270;

            //Act
            var Cart = new List<Book>();
            Cart.Add(new Book { StortName = "Harry Potter_Episode1", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode2", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode3", Quantity = 1, Price = 100 });

            var actual = target.CalcBook(Cart);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_一二三四集各買一本()
        {
            //Arrange
            Operation target = new Operation();
            int expected = 320;

            //Act
            var Cart = new List<Book>();
            Cart.Add(new Book { StortName = "Harry Potter_Episode1", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode2", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode3", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode4", Quantity = 1, Price = 100 });

            var actual = target.CalcBook(Cart);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_一二三四五集各買一本()
        {
            //Arrange
            Operation target = new Operation();
            int expected = 375;

            //Act
            var Cart = new List<Book>();
            Cart.Add(new Book { StortName = "Harry Potter_Episode1", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode2", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode3", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode4", Quantity = 1, Price = 100 });
            Cart.Add(new Book { StortName = "Harry Potter_Episode5", Quantity = 1, Price = 100 });

            var actual = target.CalcBook(Cart);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}