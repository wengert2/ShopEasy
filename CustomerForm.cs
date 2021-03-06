using ShopEasy.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ShopEasy
{
    public partial class CustomerForm : Form
    {
        // name is passed from the login form 
        public CustomerForm(string name)
        {
            InitializeComponent();
            this.User = name;
            welcomeToLbl.Text = $"Welcome: {name}!";
        }
        public CustomerForm()
        {
            InitializeComponent();
        }
        // name of user
        private string User { get; set; }
        // KeyValuePair List to store products for invoice
        private List<KeyValuePair<int, int>> orders = new List<KeyValuePair<int, int>>();
        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void populateProductList()
        {
            // adds products to the product list box for the user to see
            using ShopEasyContext context = new ShopEasyContext();
            // gets all product names and prices as a string
            var prods = context.Products
                .Select(p => p.Name + "\t\t\t $" + p.Price).ToList();
            // loops through the query result and adds them to the list box
            foreach(string p in prods)
            {
                productListBox.Items.Add(p);
            }

        }
        private void populateProductName()
        {
            // Gets the product names and adds them to the product name combo box
            using ShopEasyContext context = new ShopEasyContext();
            List<Products> prodList = context.Products.ToList();
            productNameComboBox.DataSource = prodList;
            productNameComboBox.ValueMember = nameof(Products.ProductId);
            productNameComboBox.DisplayMember = nameof(Products.Name);

        }
        private void populateInvoices()
        {
            // Gets the user's past invoices and displays them
            using ShopEasyContext context = new ShopEasyContext();
            var invoices = context.Invoices
                .Where(i => i.CustomerId == GetCustomerID(User))
                .Select(i => i.Date.ToString() + "\t $" + i.TotalPayment.ToString()).ToList();
            foreach (string invoice in invoices)
            {
                customerInvoicesListBox.Items.Add(invoice);
            }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // populates the boxes on form load
            populateInvoices();
            populateProductList();
            populateProductName();
        }

        private void productPriceListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerProductSearchGroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void productNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();
            CustomerMaintenance customerMaintenance = new CustomerMaintenance();
            // get the product name
            string prodName = productNameTextbox.Text;
            // search for the product
            var prod = context.Products
                .Where(p => p.Name == prodName)
                .FirstOrDefault();
            // if there is a match display it
            if (prod is Products)
            {
                if (customerMaintenance.IsValidProduct(prod.ProductId))
                {
                    MessageBox.Show($"Product Found:\n Name: {prod.Name}\n Price: ${prod.Price}\n Category: {prod.Category}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else 
                {
                    MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();
            int uId = GetCustomerID(User);
            var invoices = context.Invoices
                .Where(i => i.CustomerId == uId)
                .Select(i => i.Date.ToString() + " \t " + i.Customer.Name + "\t $" + i.TotalPayment.ToString()).ToList();

            foreach (string invoice in invoices)
            {
                customerInvoicesListBox.Items.Add(invoice);
            }


        }
        private void welcomeToLbl_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productQuantityComboBox_ValueChanged(object sender, EventArgs e)
        {

        }
        private int GetProductID(string prodName)
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
            MessageBox.Show("Invalid Product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
        private string GetCustomerDiscount(string name)
        {
            using ShopEasyContext context = new ShopEasyContext();
            string custDiscount = context.Customers
                .Where(c => c.Name == name)
                .Select(c => c.Discount)
                .FirstOrDefault();
            return custDiscount;
        }
        private int GetCustomerID(string name)
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
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();
            string prodName = productNameComboBox.Text;
            int prodID = GetProductID(prodName);
            string discount = GetCustomerDiscount(this.User);
            int quant = (int)productQtyUpDwn.Value;
            orders.Add(new KeyValuePair<int, int>(prodID, quant));
        }
        private decimal GetSalesTax(string discount)
        {
            if (discount.Equals("Senior") || discount.Equals("Veteran"))
            {
                return 0;
            }
            return 0.055m;
        }

        private void generateInvoiceBtn_Click(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();

            // Get the customer name, ID, and discount
            string custName = this.User;
            int custId = GetCustomerID(custName);
            string discount = GetCustomerDiscount(custName);
            decimal salesTax = GetSalesTax(discount);

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
                if (prod is Products)
                {
                    // If the customer is a teacher and the product is a book calculate discount
                    if (prod.Category.Equals("Book") && discount.Equals("Teacher "))
                    {
                        totalPrice += (prod.Price * quant) * 0.9m;
                    }
                    else
                    {
                        totalPrice += prod.Price * quant;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Get and apply other discounts
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

            // After all items are added, update the invoice total
            var record = context.Invoices
            .Where(r => r.InvoiceId == invoiceId)
            .FirstOrDefault();
            if (record is Invoices)
            {
                record.TotalPayment = totalPrice;
            }
            else
            {
                MessageBox.Show("Could not proccess transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            context.SaveChanges();
            MessageBox.Show($"Invoice: {invoiceId}\n Total: ${totalPrice}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customerInvoicesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
