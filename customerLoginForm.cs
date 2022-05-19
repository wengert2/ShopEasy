using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ShopEasy.Models.DataLayer;

namespace ShopEasy
{
    public partial class customerLoginForm : Form
    {
        public customerLoginForm()
        {
            InitializeComponent();
           
        }
        
        private void customerLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void customerLoginSubmitButton_Click(object sender, EventArgs e)
        {
            // Get the inputs
            string username = customerUsernameTextbox.Text;
            string password = customerPasswordTextbox.Text;

            // Check that inputs are not empty
            if (!String.IsNullOrEmpty(password) && !String.IsNullOrWhiteSpace(username))
            {
                // check that the user exists, if their credentials match display the customer form
                if (IsvalidCustomer(username, password))
                {
                    CustomerForm customerForm = new CustomerForm(GetCustomerName(username, password));
                    customerForm.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter both username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsvalidCustomer(string username, string password)
        {
            // Checks that there is an entry for the username and password 
            using ShopEasyContext context = new ShopEasyContext();
            var custLogin = from login in context.Logins
                                where login.Username == username
                                && login.Password == password
                                select login;
            if (custLogin.Any())
            {
                return true;
            }
            return false;
        }
        private string GetCustomerName(string username, string password)
        {
            // given the username and password this function finds the 
            // customerid assocaiated with the login and then gets
            // the customer name to be used in the customer form
            using ShopEasyContext context = new ShopEasyContext();
            var custId = context.Logins
                .Where(c => c.Username == username && c.Password == password)
                .FirstOrDefault();
            var cust = context.Customers
                .Where(c => c.CustomerId == custId.Id)
                .FirstOrDefault();
            if(cust is Customers)
            {
                return cust.Name;
            }
            else
            {
                MessageBox.Show("Unable to find customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "null";
            
        }
    }
}
