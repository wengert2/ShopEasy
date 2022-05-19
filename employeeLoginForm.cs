using ShopEasy.Models.DataLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class employeeLoginForm : Form
    {
        public employeeLoginForm()
        {
            InitializeComponent();
        }

        private void employeeLoginSubmitButton_Click(object sender, EventArgs e)
        {
            // gets the username and password input
            string username = employeeIDLoginTextbox.Text;
            string password = employeePasswordLoginTextbox.Text;

            // checks if inputs are empty, null, or contain whitespace
            if (String.IsNullOrEmpty(password) || String.IsNullOrWhiteSpace(username))
            {
                // Checks if the login credentials match the admin's 
                // currently they are the only employee in the database
                // this function would have to be changed in the future if more
                // employee logins are needed
                if (IsAdmin(username, password))
                {
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.ShowDialog();

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

        private void employeeLoginForm_Load(object sender, EventArgs e)
        {

        }
        private bool IsAdmin(string username, string password)
        {
            // checks to see if the login credentials match the admin's
            ShopEasyContext context = new ShopEasyContext();
            var adminLogin = from a in context.Logins
                                where a.Username == username
                                && a.Password == password && a.CustomerId == 1
                                select a;
            if (adminLogin.Any())
            {
                return true;
            }
            return false;
        }

        private void employeeLoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
