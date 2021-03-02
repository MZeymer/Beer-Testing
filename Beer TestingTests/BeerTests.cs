using Microsoft.VisualStudio.TestTools.UnitTesting;
using Beer_Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beer_Testing.Tests
{
    [TestClass()]
    public class BeerTests
    {
        private Beer beer;

        [TestInitialize]
        public void Init()
        {
            beer = new Beer(1, "Carlsberg", 25, 4.7);
        }


        [TestMethod()]
        public void NameTest()
        {
            Assert.AreEqual("Carlsberg", beer.Name);
            Assert.ThrowsException<ArgumentException>(() => beer.Name = "Car");
            Assert.ThrowsException<ArgumentNullException>(() => beer.Name = null);
            
        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.AreEqual(25, beer.Price);
            Assert.ThrowsException<ArgumentException>(() => beer.Price = 0);
        }

        [TestMethod()]
        public void AbvTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = 110);
            beer.Abv = 5;
            Assert.AreEqual(5, beer.Abv);
            beer.Abv = 100;
            Assert.AreEqual(100, beer.Abv);
            
        }
    }
}