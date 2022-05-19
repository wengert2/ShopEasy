﻿using System.Windows.Forms;
using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using ShopEasy.Models.DataLayer;

namespace ShopEasy
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            using ShopEasyContext context = new ShopEasyContext();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            populateCustomerCheckoutComboBox();
            populateProductCheckkoutComboBox();
        }

        private List<KeyValuePair<int, int>> orders = new List<KeyValuePair<int, int>>();
        private string GetEditDiscount()
        {
            string discount = "";
            if (custDiscountEditBox.CheckedItems.Count != 0)
            {
                foreach (string s in custDiscountEditBox.CheckedItems)
                {
                    discount += s;
                }
                if (String.IsNullOrEmpty(discount) || String.IsNullOrWhiteSpace(discount) || discount.Equals(""))
                {
                    discount = "None";
                }

            }
            else
            {
                MessageBox.Show("Discount not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                discount = "None";
            }
            return discount;
        }
        private string GetDiscount()
        {
            string discount = "";
            if (custRegDiscountBox.CheckedItems.Count != 0)
            {
                foreach (string s in custRegDiscountBox.CheckedItems)
                {
                    discount += s;
                }
                if (String.IsNullOrEmpty(discount) || String.IsNullOrWhiteSpace(discount) || discount.Equals(""))
                {
                    discount = "None";
                }

            }
            else
            {
                MessageBox.Show("Discount not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                discount = "None";
            }
            return discount;
        }
        private void customerNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void custRegPasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void DeleteCustomer(string name)
        {
            ShopEasyContext context = new ShopEasyContext();
            var delCust = context.Customers
                        .Where(c => c.Name == name)
                        .FirstOrDefault();
            if (delCust is Customers)
            {
                context.Remove(delCust);
                MessageBox.Show("Customer deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Unable to delete Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // SqlException: The DELETE statement conflicted with the
            // REFERENCE constraint "FK_CustomerId_Customers".
            // The conflict occurred in database "ShopEasy", table "dbo.Invoices", column 'CustomerId'.
            context.SaveChanges();
        }

        private string GetCustRegName()
        {
            if (String.IsNullOrEmpty(customerNameTextbox.Text) || String.IsNullOrWhiteSpace(customerNameTextbox.Text))
            {
                MessageBox.Show("Customer name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            return customerNameTextbox.Text;
        }
        private void customerSearchButton_Click_1(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();

            // Get the textbox input
            string name = customerNameSearchTextbox.Text;
            // Check if there is input
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please input a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Search the database for a matching customer
                var searchCust = (from c in context.Customers
                                  where c.Name == name
                                  select c);
                // If a match is not found notify the user
                if (!searchCust.Any())
                {
                    MessageBox.Show("No matching customer found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Otherwise display the match to the user
                else
                {
                    var cust = (from c in context.Customers
                                where c.Name == name
                                select c).FirstOrDefault();
                    MessageBox.Show($"Name: {cust.Name}\nPhone: {cust.Phone} \nEmail: {cust.Email}",
                        "Customer Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            ShopEasyContext context = new ShopEasyContext();
            string prodName = productNameSearchTxtbx.Text;
            var delProd = context.Products
                        .Where(p => p.Name == prodName)
                        .FirstOrDefault();
            if (delProd is Products)
            {
                context.Remove(delProd);
                MessageBox.Show("Product deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Unable to delete Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            context.SaveChanges();
        }
        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            ShopEasyContext context = new ShopEasyContext();
            string prodName = productNameSearchTxtbx.Text;
            var prod = context.Products
                .Where(p => p.Name == prodName)
                .SingleOrDefault();
            if (prod is Products)
            {
                MessageBox.Show($"Product found:\n Name: {prod.Name} \n Price: ${prod.Price} \n Category: {prod.Category}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProductEditBtn_Click(object sender, EventArgs e)
        {
            ShopEasyContext context = new ShopEasyContext();
            string prodName = productNameSearchTxtbx.Text;
            string category = productCategoryTxtbx.Text;
            string priceString = productPriceTxtbx.Text;
            NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            decimal price;
            if (!(Decimal.TryParse(priceString, style, culture, out price)))
            {
                MessageBox.Show("Invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                price = Decimal.Parse(priceString);
            }
            var prod = context.Products
                .Where(p => p.Name == prodName)
                .FirstOrDefault();
            if (prod is Products)
            {
                var result = MessageBox.Show("Are you sure you want to update this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    prod.Price = price;
                    prod.Category = category;
                    prod.Name = prodName;
                    context.SaveChanges();
                }
                if (result == DialogResult.No)
                {
                    productCategoryTxtbx.Clear();
                    productNameSearchTxtbx.Clear();
                    productPriceTxtbx.Clear();
                }
            }
            else
            {
                MessageBox.Show("Unable to edit product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ShopEasyContext context = new ShopEasyContext();
            CustomerMaintenance customerMaintenance = new CustomerMaintenance();
            string prodName = productNameSearchTxtbx.Text;
            string prodCategory = productCategoryTxtbx.Text;
            string priceString = productPriceTxtbx.Text;
            decimal price;

            // Test that product name is not empty and does not already exist
            if (String.IsNullOrEmpty(prodName) || String.IsNullOrWhiteSpace(prodName))
            {
                MessageBox.Show("Product must have a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (customerMaintenance.IsValidProduct(prodName))
            {
                MessageBox.Show("A product with the same name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(priceString) || String.IsNullOrWhiteSpace(priceString))
            {
                MessageBox.Show("Product must have a price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            int count = context.Products.Count();
            // Create try to convert the price string to a decimal and check if valid
            if (!(Decimal.TryParse(priceString, style, culture, out price)))
            {
                MessageBox.Show("Invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                price = Decimal.Parse(priceString);
            }
            if (price <= 0)
            {
                MessageBox.Show("Price cannot be less than or equal to zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Products product = new Products()
            {
                Name = prodName,
                Price = price,
                Category = prodCategory
            };
            context.Add(product);
            context.SaveChanges();
            if (context.Products.Count() > count)
            {
                MessageBox.Show("Product created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Product creation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();
            CustomerMaintenance customerMaintenance = new CustomerMaintenance();

            // Get the product name and ID
            string prodName = productCheckoutComboBox.Text;
            int prodID = customerMaintenance.GetProductID(prodName);

            // Check if the product ID is valid
            if (!(prodID >= 0))
            {
                MessageBox.Show("Invalid Product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string discount = customerMaintenance.GetCustomerDiscount(custCheckoutComboBox.Text);
            int quant = (int)productQuantityUpDown.Value;

            // Add the item to the orders KeyValuePair list
            orders.Add(new KeyValuePair<int, int>(prodID, quant));
        }
        private void generateInvoiceBtn_Click(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();
            CustomerMaintenance customerMaintenance = new CustomerMaintenance();

            // Get the customer name, ID, discount, and sales tax
            string custName = custCheckoutComboBox.Text;
            int custId = customerMaintenance.GetCustomerID(custName);
            string discount = customerMaintenance.GetCustomerDiscount(custName);
            decimal salesTax = customerMaintenance.GetSalesTax(discount);

            // Create invoiceId and totalprice to be used later
            int invoiceId;
            decimal totalPrice = 0.00m;

            // Create a new Invoice 
            Invoices invoices = new Invoices()
            {
                CustomerId = custId,
                Date = DateTime.Now,
                SalesTax = salesTax,
                TotalPayment = totalPrice
            };

            // Add the incomplete invoice to the database and save
            context.Invoices.Add(invoices);
            context.SaveChanges();
            invoiceId = invoices.InvoiceId;

            // Loop through the keyvalues list and add each product to
            // the invoiceitems table
            int prodId;
            int quant;
            foreach (var element in orders)
            {
                prodId = element.Key;
                quant = element.Value;

                // Create an InvoiceItem
                Guid myuuid = Guid.NewGuid();
                string myuuidAsString = myuuid.ToString();
                InvoiceItem invoiceitem = new InvoiceItem()
                {
                    Id = myuuidAsString,
                    InvoiceId = invoiceId,
                    ProductId = prodId,
                    Quantity = quant
                };
                context.InvoiceItem.Add(invoiceitem);
                context.SaveChanges();

                // Find the matching product
                var prod = context.Products
                    .Where(p => p.ProductId == prodId)
                    .FirstOrDefault();

                // check if product is found
                if (prod is Products)
                {
                    // If customer is a teacher and the product is a book calculate discount
                    if (prod.Category.Equals("Book") && (discount.Equals("Teacher ") || discount.Equals("Teacher")))
                    {
                        totalPrice += prod.Price * quant * 0.9m;
                    }
                    else
                    {
                        totalPrice += prod.Price * quant;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to find product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (discount.Equals("Senior"))
            {
                totalPrice -= totalPrice * 0.05m;
            }
            else if (discount.Equals("Veteran"))
            {
                totalPrice -= totalPrice * 0.10m;
            }
            else
            {
                totalPrice += totalPrice * .055m;
            }

            // After each item is added, update the invoice total
            var record = context.Invoices
            .Where(r => r.InvoiceId == invoiceId)
            .FirstOrDefault();

            if (record is Invoices)
            {
                record.TotalPayment = totalPrice;
            }
            context.SaveChanges();
            MessageBox.Show($"Invoice: {invoiceId}\n Total: ${totalPrice}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void custRegGroupbox_Enter(object sender, EventArgs e)
        {

        }
        private void populateCustomerCheckoutComboBox()
        {
            // Create a list of customers for the combobox 
            using ShopEasyContext context = new ShopEasyContext();
            List<Customers> custList = context.Customers.ToList();
            custCheckoutComboBox.DataSource = custList;
            custCheckoutComboBox.ValueMember = nameof(Customers.CustomerId);
            custCheckoutComboBox.DisplayMember = nameof(Customers.Name);
        }
        private void populateProductCheckkoutComboBox()
        {
            // Create a list of products for the combobox
            using ShopEasyContext context = new ShopEasyContext();
            List<Products> productsList = context.Products.ToList();
            productCheckoutComboBox.DataSource = productsList;
            productCheckoutComboBox.ValueMember = nameof(Products.ProductId);
            productCheckoutComboBox.DisplayMember = nameof(Products.Name);
        }

        private void custRegSubmitButton_Click(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();
            CustomerMaintenance customerMaintenance = new CustomerMaintenance();

            // Get the discount and name of the new customer
            string discount = GetDiscount();
            string name = GetCustRegName();
            if(String.IsNullOrEmpty(customerPhoneTextbox.Text) || String.IsNullOrWhiteSpace(customerPhoneTextbox.Text))
            {
                MessageBox.Show("Please input a valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(customerEmailTextbox.Text) || String.IsNullOrWhiteSpace(customerEmailTextbox.Text))
            {
                MessageBox.Show("Please input a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(customerUsernameTextbox.Text) || String.IsNullOrWhiteSpace(customerUsernameTextbox.Text))
            {
                MessageBox.Show("Please input a valid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(custRegPasswordTextbox.Text) || String.IsNullOrWhiteSpace(custRegPasswordTextbox.Text))
            {
                MessageBox.Show("Please input a valid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check that the customer name is valid
            if (!String.IsNullOrEmpty(name) || !String.IsNullOrWhiteSpace(name))
            {
                // Create a new customer 
                Customers newCustomer = new Customers()
                {
                    Name = customerNameTextbox.Text,
                    Phone = customerPhoneTextbox.Text,
                    Email = customerEmailTextbox.Text,
                    Discount = discount
                };
                // Add to and save database
                context.Customers.Add(newCustomer);
                context.SaveChanges();

                // Create a new login based on the customerID
                Logins newLogin = new Logins()
                {
                    Username = customerUsernameTextbox.Text,
                    Password = custRegPasswordTextbox.Text,
                    CustomerId = newCustomer.CustomerId
                };
                // Add to and save the database
                context.Logins.Add(newLogin);
                context.SaveChanges();

                // Check that the customer and login were created successfully
                if (customerMaintenance.IsValidUser(customerUsernameTextbox.Text, custRegPasswordTextbox.Text) && customerMaintenance.IsValidCustomer(name))
                {
                    MessageBox.Show("Customer Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    customerNameTextbox.Clear();
                    customerPhoneTextbox.Clear();
                    customerEmailTextbox.Clear();
                    customerUsernameTextbox.Clear();
                    custRegPasswordTextbox.Clear();
                    custRegDiscountBox.ClearSelected();
                    populateCustomerCheckoutComboBox();
                }
                else
                {
                    MessageBox.Show("Customer Creation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void productCheckoutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void searchProductGroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void viewInvoicesNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewPastInvoicesBtn_Click(object sender, EventArgs e)
        {
            CustomerInvoiceListForm customerInvoiceForm = new CustomerInvoiceListForm();
            customerInvoiceForm.ShowDialog();
        }

        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();
            CustomerMaintenance customerMaintenance = new CustomerMaintenance();
            // Get the user input
            string newCustName = custNewNameTextbox.Text;
            string custName = customerNameSearchTextbox.Text;
            string newPhone = custNewPhoneTextbox.Text;
            string newEmail = custNewEmailTextbox.Text;
            string newDiscount = GetEditDiscount();

            // Verify that fields are not empty
            if (String.IsNullOrEmpty(newCustName) || String.IsNullOrWhiteSpace(newCustName))
            {
                MessageBox.Show("Invalid New Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(custName) || String.IsNullOrWhiteSpace(custName))
            {
                MessageBox.Show("Invalid Old Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(String.IsNullOrEmpty(newPhone) || String.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show("Phone cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(newEmail) || String.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Email cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int customerId = customerMaintenance.GetCustomerID(custName);
            var cust = context.Customers
                .Where(c => c.CustomerId == customerId)
                .FirstOrDefault();
            if(cust is Customers)
            {
                cust.Name = newCustName;
                cust.Phone = newPhone;
                cust.Email = newEmail;
                cust.Discount = newDiscount;
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Customer edit failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void custNewPhoneTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void custNewEmailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteCustomerBtn_Click_1(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();
            string name = customerNameSearchTextbox.Text;
            var result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                DeleteCustomer(name);
            }
        }
    }
}