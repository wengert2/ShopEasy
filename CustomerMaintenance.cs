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
            // Gets the customer discount based on customer name
            using ShopEasyContext context = new ShopEasyContext();
            var custDiscount = context.Customers
                .Where(c => c.Name == name)
                .Select(c => c.Discount)
                .FirstOrDefault();

            return custDiscount;
        }
        public decimal GetSalesTax(string discount)
        {
            // Gets the sales tax based on the customer discont
            if (discount.Equals("Senior") || discount.Equals("Veteran"))
            {
                return 0;
            }
            return 0.055m;
        }
        public int GetCustomerID(string name)
        {
            // Gets the customer id associated with the customer name
            // will return the first match or a default value if none found
            using ShopEasyContext context = new ShopEasyContext();
            int cust = context.Customers
                .Where(c => c.Name == name)
                .Select(c => c.CustomerId)
                .FirstOrDefault();
            
            // check that the customer id is not the admin or invalid
            if (cust <= 1)
            {
                return -1;
            }
            return cust;
        }
        public bool IsValidUser(string username, string password)
        {
            // Checks that the user login is valid
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
            // checks that the product exists
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
            // checks that the product exists based on product id
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
            // checks that the customer exists based on name
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
            // returns the product id based on the product name
            // will return a default value if no match
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
