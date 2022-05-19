using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopEasy;
namespace ShopEasyTester
{
    [TestClass]
    public class ShopEasyTester
    {
        [TestMethod]
        public void GetCustomerDiscountWhenNameIsEmpty()
        {
            string testName = "";
            CustomerMaintenance test = new ShopEasy.CustomerMaintenance();
            string expected = "None";
            string actual = test.GetCustomerDiscount(testName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetCustomerDiscountWhenNameIsInvalid()
        {
            string testName = "'";
            CustomerMaintenance test = new ShopEasy.CustomerMaintenance();
            string expected = "None";
            string actual = test.GetCustomerDiscount(testName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetSalesTaxWhenDiscountIsInvalid()
        {
            string testName = "'";
            CustomerMaintenance test = new ShopEasy.CustomerMaintenance();
            decimal expected = 0.055m;
            decimal actual = test.GetSalesTax(testName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetSalesTaxWhenDiscountIsValid()
        {
            string testName = "Senior";
            CustomerMaintenance test = new ShopEasy.CustomerMaintenance();
            decimal expected = 0;
            decimal actual = test.GetSalesTax(testName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetSalesTaxWhenDiscountWithSpaceAfter()
        {
            string testName = "Veteran ";
            CustomerMaintenance test = new ShopEasy.CustomerMaintenance();
            decimal expected = 0;
            decimal actual = test.GetSalesTax(testName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetCustomerIDWithAdmin()
        {
            string testName = "Admin";
            CustomerMaintenance test = new ShopEasy.CustomerMaintenance();
            int expected = -1;
            int actual = test.GetCustomerID(testName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsValidUserWhitespace()
        {
            string testuser = " ";
            string testpass = " ";
            CustomerMaintenance test = new ShopEasy.CustomerMaintenance();
            bool expected = true;
            bool actual = test.IsValidUser(testuser, testpass);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void IsValidProduct()
        {
            string testprod = "apple";
            CustomerMaintenance test = new ShopEasy.CustomerMaintenance();
            bool expected = true;
            bool actual = test.IsValidProduct(testprod);
            Assert.AreEqual(expected, actual);
        }
    }
}
