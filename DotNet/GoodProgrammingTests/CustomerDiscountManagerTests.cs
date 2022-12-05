using Microsoft.VisualStudio.TestTools.UnitTesting;
using BadProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;

namespace BadProgramming.Tests
{
    [TestClass()]
    public class CustomerDiscountManagerTests
    {
        [TestMethod()]
        public void CalculateCustomerPriceTest_NormalTier()
        {
            CustomerDiscountManager discount = new();
            double result = discount.CalculateCustomerPrice(500, 1, 0);
            double expected = 500.0;

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CalculateCustomerPriceTest_SilverTier()
        {
            CustomerDiscountManager discount = new();
            double result = discount.CalculateCustomerPrice(100, 2, 0);
            double expected = 90.0;

            Assert.AreEqual(expected, result);
        }
    }
}