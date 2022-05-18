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
        private void populateInvoiceListBox()
        {

        }
        // TODO: FIX THIS
        private void CustomerInvoiceListForm_Load(object sender, EventArgs e)
        {
            using ShopEasyContext context = new ShopEasyContext();
            var customerInvoices = context.Customers
                .Join(context.Invoices,
                c => c.CustomerId,
                i => i.CustomerId,
                (c, i) => new { c.Name, i.Date, i.TotalPayment })
                .OrderBy(ci => ci.Date)
                .ThenByDescending(ci => ci.Name);

            invoiceListBox.DataSource = customerInvoices.ToList();
            invoiceListBox.DisplayMember = "Name";
            invoiceListBox.ValueMember = "CustomerId";
        }
    }
}
