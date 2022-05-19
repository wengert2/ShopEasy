using ShopEasy.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopEasy
{
    class CustomerMaintenance
    {
        public string GetCustomerDiscount(string name)
        {
            using ShopEasyContext context = new ShopEasyContext();
            var custDiscount = context.Customers
                .Where(c => c.Name == name)
                .Select(c => c.Discount)
                .FirstOrDefault();

            return custDiscount;
        }
        public decimal GetSalesTax(string discount)
        {
            if (discount.Equals("Senior") || discount.Equals("Veteran"))
            {
                return 0;
            }
            return 0.055m;
        }
        public int GetCustomerID(string name)
        {
            using ShopEasyContext context = new ShopEasyContext();
            int cust = context.Customers
                .Where(c => c.Name == name)
                .Select(c => c.CustomerId)
                .SingleOrDefault();

            if (cust.Equals(0) || cust.Equals(1))
            {
                return -1;
            }
            return cust;
        }
        public bool IsValidUser(string username, string password)
        {
            using ShopEasyContext context = new ShopEasyContext();
            var customerLogin = from customer in context.Logins
                                where customer.Username == username
                                && customer.Password == password
                                select customer;
            if (customerLogin.Any())
            {
                return true;
            }
            return false;
        }
        public bool IsValidProduct(string productName)
        {
            using ShopEasyContext context = new ShopEasyContext();
            var prod = from p in context.Products
                       where p.Name == productName
                       select p;
            if (prod.Any())
            {
                return true;
            }
            return false;
        }
        public bool IsValidProduct(int prodID)
        {
            using ShopEasyContext context = new ShopEasyContext();
            var prod = from p in context.Products
                       where p.ProductId == prodID
                       select p;
            if (prod.Any())
            {
                return true;
            }
            return false;
        }
        public bool IsValidCustomer(string name)
        {
            using ShopEasyContext context = new ShopEasyContext();
            var custName = context.Customers
                .Where(c => c.Name == name)
                .Select(c => c.Name)
                .FirstOrDefault();
            if (!(custName == null) && custName.Equals(name))
            {
                return true;
            }
            return false;

        }
        public int GetProductID(string prodName)
        {
            using ShopEasyContext context = new ShopEasyContext();
            int prodID = context.Products
                       .Where(p => p.Name == prodName)
                       .Select(p => p.ProductId)
                       .FirstOrDefault();
            if (!(prodID <= 0))
            {
                return prodID;
            }
            return -1;
        }
    }
}
