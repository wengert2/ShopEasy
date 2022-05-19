using ShopEasy.Models.DataLayer;
using System;
using System.Data;
using System.Linq;
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
            // gets the invoices and adds them to the list box
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
            // fills the list box on form load
            populateInvoiceListBox();
        }
    }
}
