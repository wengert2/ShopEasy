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
            string username = customerUsernameTextbox.Text;
            string password = customerPasswordTextbox.Text;

            if (NotEmpty(password) && NotEmpty(username))
            {
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
        private bool NotEmpty(string testString)
        {
            if (testString != string.Empty)
            {
                return true;
            }
            return false;
        }
        private string GetCustomerName(string username, string password)
        {
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
