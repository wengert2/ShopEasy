using Microsoft.Data.SqlClient;
using ShopEasy.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class CustomerInvoiceListForm : Form
    {
        public CustomerInvoiceListForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string GetCustomerName(int id)
        {
            using ShopEasyContext context = new ShopEasyContext();
            string cust = context.Customers
                .Where(c => c.CustomerId == id)
                .Select(c => c.Name)
                .FirstOrDefault();
            return cust;
        }
        private void populateInvoiceListBox()
        {
            using ShopEasyContext context = new ShopEasyContext();
            var invoices = context.Invoices
                .Select(i => i.Date.ToString() + " \t " + i.Customer.Name + "\t $" + i.TotalPayment.ToString()).ToList();
            
            foreach (string invoice in invoices)
            {
                invoiceListBox.Items.Add(invoice);
            }
        }
        private void CustomerInvoiceListForm_Load(object sender, EventArgs e)
        {
            populateInvoiceListBox();
        }
    }
}
