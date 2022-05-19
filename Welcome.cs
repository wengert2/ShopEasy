using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void customerWelcomeButton_Click(object sender, EventArgs e)
        {
            // Opens the customer login form
            customerLoginForm customerLogin = new customerLoginForm();
            customerLogin.ShowDialog();
        }

        private void employeeWelcomeButton_Click(object sender, EventArgs e)
        {
            // opens the employee login form
            employeeLoginForm employeeLogin = new employeeLoginForm();
            employeeLogin.ShowDialog();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
