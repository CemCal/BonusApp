using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BonusApp;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public Order order;
        [TestInitialize]
        public void Init()
        {
            order = new Order();
            order.AddProduct(new Product { Name = "Peanuts", Value = 7 });
            order.AddProduct(new Product { Name = "Apple", Value = 3 });
            order.AddProduct(new Product { Name = "Orange", Value = 4 });
        }


        [TestMethod]
        public void TenPercent_Test()
        {
            Assert.AreEqual(2, Bonuses.TenPercent(20));
            Assert.AreEqual(3.5, Bonuses.TenPercent(35));
        }

        [TestMethod]

        public void FlatTwoIfAmountMoreThanFive_Test()
        {
            Assert.AreEqual(2, Bonuses.FlatTwolfAmountMoreThanFive(6));
            Assert.AreEqual(2, Bonuses.FlatTwolfAmountMoreThanFive(5.5));
            Assert.AreEqual(0, Bonuses.FlatTwolfAmountMoreThanFive(4));
            Assert.AreEqual(0, Bonuses.FlatTwolfAmountMoreThanFive(5));
        }

        [TestMethod]
        public void GetValueOfProducts_Test()
        {
            Assert.AreEqual(14, order.GetValueOfProducts());

        
        }

        [TestMethod]
        public void GetBonus_Test()
        {
            order.Bonus = Bonuses.TenPercent;

            Assert.AreEqual(1.4d, order.GetBonus(), 0.01);

            order.Bonus = Bonuses.FlatTwolfAmountMoreThanFive;

            Assert.AreEqual(2, order.GetBonus());
        }

        [TestMethod]
        public void GetTotalPrice_Test()
        {
            order.Bonus = Bonuses.TenPercent;

            Assert.AreEqual(12.6, order.GetTotalPrice(), 0.01);

            order.Bonus = Bonuses.FlatTwolfAmountMoreThanFive;

            Assert.AreEqual(12, order.GetTotalPrice());
        }


    }
}
