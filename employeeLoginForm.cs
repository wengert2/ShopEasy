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

            string username = employeeIDLoginTextbox.Text;
            string password = employeePasswordLoginTextbox.Text;

            if (notEmpty(password) && notEmpty(username))
            {
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

        private bool notEmpty(string testString)
        {
            if (testString != string.Empty)
            {
                return true;
            }
            return false;
        }
        private bool IsAdmin(string username, string password)
        {
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
    }
}
