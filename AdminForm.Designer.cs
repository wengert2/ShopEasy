
using System;

namespace ShopEasy
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.customerPhoneTextbox = new System.Windows.Forms.TextBox();
            this.customerEmailTextbox = new System.Windows.Forms.TextBox();
            this.custNameRegLabel = new System.Windows.Forms.Label();
            this.custPhoneRegLabel = new System.Windows.Forms.Label();
            this.custEmailRegLabel = new System.Windows.Forms.Label();
            this.custRegGroupbox = new System.Windows.Forms.GroupBox();
            this.customerUsernameTextbox = new System.Windows.Forms.TextBox();
            this.custUsernameLabel = new System.Windows.Forms.Label();
            this.custRegSubmitButton = new System.Windows.Forms.Button();
            this.custRegPasswordTextbox = new System.Windows.Forms.TextBox();
            this.custRegPasswordLabel = new System.Windows.Forms.Label();
            this.custRegDiscountLabel = new System.Windows.Forms.Label();
            this.custRegDiscountBox = new System.Windows.Forms.CheckedListBox();
            this.customerSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editDiscountLabel = new System.Windows.Forms.Label();
            this.custDiscountEditBox = new System.Windows.Forms.CheckedListBox();
            this.custNewEmailTextbox = new System.Windows.Forms.TextBox();
            this.custNewPhoneTextbox = new System.Windows.Forms.TextBox();
            this.custNewNameTextbox = new System.Windows.Forms.TextBox();
            this.custNewEmailLabel = new System.Windows.Forms.Label();
            this.custNewPhoneLabel = new System.Windows.Forms.Label();
            this.custNewFirstNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.customerSearchButton = new System.Windows.Forms.Button();
            this.customerNameSearchTextbox = new System.Windows.Forms.TextBox();
            this.custFnameSearchLabel = new System.Windows.Forms.Label();
            this.customerCheckoutGroupbox = new System.Windows.Forms.GroupBox();
            this.viewPastInvoicesBtn = new System.Windows.Forms.Button();
            this.viewInvoicesLabel = new System.Windows.Forms.Label();
            this.productCheckoutComboBox = new System.Windows.Forms.ComboBox();
            this.custCheckoutComboBox = new System.Windows.Forms.ComboBox();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.productSelectionLabel = new System.Windows.Forms.Label();
            this.customerCheckoutSelectionLabel = new System.Windows.Forms.Label();
            this.generateInvoiceBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.productQuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.searchProductGroupbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productCategoryTxtbx = new System.Windows.Forms.TextBox();
            this.productPriceTxtbx = new System.Windows.Forms.TextBox();
            this.productPricelabel = new System.Windows.Forms.Label();
            this.productEditBtn = new System.Windows.Forms.Button();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.productNameSearchTxtbx = new System.Windows.Forms.TextBox();
            this.productNameSearchLabel = new System.Windows.Forms.Label();
            this.custRegGroupbox.SuspendLayout();
            this.customerSearchGroupBox.SuspendLayout();
            this.customerCheckoutGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityUpDown)).BeginInit();
            this.searchProductGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Location = new System.Drawing.Point(73, 20);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(100, 23);
            this.customerNameTextbox.TabIndex = 1;
            this.customerNameTextbox.TextChanged += new System.EventHandler(this.customerNameTextbox_TextChanged);
            // 
            // customerPhoneTextbox
            // 
            this.customerPhoneTextbox.Location = new System.Drawing.Point(72, 52);
            this.customerPhoneTextbox.Name = "customerPhoneTextbox";
            this.customerPhoneTextbox.Size = new System.Drawing.Size(100, 23);
            this.customerPhoneTextbox.TabIndex = 2;
            // 
            // customerEmailTextbox
            // 
            this.customerEmailTextbox.Location = new System.Drawing.Point(72, 81);
            this.customerEmailTextbox.Name = "customerEmailTextbox";
            this.customerEmailTextbox.Size = new System.Drawing.Size(100, 23);
            this.customerEmailTextbox.TabIndex = 3;
            // 
            // custNameRegLabel
            // 
            this.custNameRegLabel.AutoSize = true;
            this.custNameRegLabel.Location = new System.Drawing.Point(12, 27);
            this.custNameRegLabel.Name = "custNameRegLabel";
            this.custNameRegLabel.Size = new System.Drawing.Size(42, 15);
            this.custNameRegLabel.TabIndex = 5;
            this.custNameRegLabel.Text = "Name:";
            // 
            // custPhoneRegLabel
            // 
            this.custPhoneRegLabel.AutoSize = true;
            this.custPhoneRegLabel.Location = new System.Drawing.Point(12, 62);
            this.custPhoneRegLabel.Name = "custPhoneRegLabel";
            this.custPhoneRegLabel.Size = new System.Drawing.Size(44, 15);
            this.custPhoneRegLabel.TabIndex = 7;
            this.custPhoneRegLabel.Text = "Phone:";
            // 
            // custEmailRegLabel
            // 
            this.custEmailRegLabel.AutoSize = true;
            this.custEmailRegLabel.Location = new System.Drawing.Point(17, 91);
            this.custEmailRegLabel.Name = "custEmailRegLabel";
            this.custEmailRegLabel.Size = new System.Drawing.Size(39, 15);
            this.custEmailRegLabel.TabIndex = 8;
            this.custEmailRegLabel.Text = "Email:";
            // 
            // custRegGroupbox
            // 
            this.custRegGroupbox.Controls.Add(this.customerUsernameTextbox);
            this.custRegGroupbox.Controls.Add(this.custUsernameLabel);
            this.custRegGroupbox.Controls.Add(this.custRegSubmitButton);
            this.custRegGroupbox.Controls.Add(this.custRegPasswordTextbox);
            this.custRegGroupbox.Controls.Add(this.custRegPasswordLabel);
            this.custRegGroupbox.Controls.Add(this.custRegDiscountLabel);
            this.custRegGroupbox.Controls.Add(this.custRegDiscountBox);
            this.custRegGroupbox.Controls.Add(this.customerNameTextbox);
            this.custRegGroupbox.Controls.Add(this.custEmailRegLabel);
            this.custRegGroupbox.Controls.Add(this.custNameRegLabel);
            this.custRegGroupbox.Controls.Add(this.customerEmailTextbox);
            this.custRegGroupbox.Controls.Add(this.custPhoneRegLabel);
            this.custRegGroupbox.Controls.Add(this.customerPhoneTextbox);
            this.custRegGroupbox.Location = new System.Drawing.Point(12, 12);
            this.custRegGroupbox.Name = "custRegGroupbox";
            this.custRegGroupbox.Size = new System.Drawing.Size(305, 207);
            this.custRegGroupbox.TabIndex = 9;
            this.custRegGroupbox.TabStop = false;
            this.custRegGroupbox.Text = "Register a new customer";
            this.custRegGroupbox.Enter += new System.EventHandler(this.custRegGroupbox_Enter);
            // 
            // customerUsernameTextbox
            // 
            this.customerUsernameTextbox.Location = new System.Drawing.Point(72, 110);
            this.customerUsernameTextbox.Name = "customerUsernameTextbox";
            this.customerUsernameTextbox.Size = new System.Drawing.Size(100, 23);
            this.customerUsernameTextbox.TabIndex = 5;
            this.customerUsernameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // custUsernameLabel
            // 
            this.custUsernameLabel.AutoSize = true;
            this.custUsernameLabel.Location = new System.Drawing.Point(3, 120);
            this.custUsernameLabel.Name = "custUsernameLabel";
            this.custUsernameLabel.Size = new System.Drawing.Size(63, 15);
            this.custUsernameLabel.TabIndex = 12;
            this.custUsernameLabel.Text = "Username:";
            this.custUsernameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // custRegSubmitButton
            // 
            this.custRegSubmitButton.Location = new System.Drawing.Point(77, 178);
            this.custRegSubmitButton.Name = "custRegSubmitButton";
            this.custRegSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.custRegSubmitButton.TabIndex = 7;
            this.custRegSubmitButton.Text = "Create";
            this.custRegSubmitButton.UseVisualStyleBackColor = true;
            this.custRegSubmitButton.Click += new System.EventHandler(this.custRegSubmitButton_Click);
            // 
            // custRegPasswordTextbox
            // 
            this.custRegPasswordTextbox.Location = new System.Drawing.Point(72, 139);
            this.custRegPasswordTextbox.Name = "custRegPasswordTextbox";
            this.custRegPasswordTextbox.Size = new System.Drawing.Size(100, 23);
            this.custRegPasswordTextbox.TabIndex = 6;
            this.custRegPasswordTextbox.TextChanged += new System.EventHandler(this.custRegPasswordTextbox_TextChanged);
            // 
            // custRegPasswordLabel
            // 
            this.custRegPasswordLabel.AutoSize = true;
            this.custRegPasswordLabel.Location = new System.Drawing.Point(3, 147);
            this.custRegPasswordLabel.Name = "custRegPasswordLabel";
            this.custRegPasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.custRegPasswordLabel.TabIndex = 10;
            this.custRegPasswordLabel.Text = "Password:";
            // 
            // custRegDiscountLabel
            // 
            this.custRegDiscountLabel.AutoSize = true;
            this.custRegDiscountLabel.Location = new System.Drawing.Point(208, 25);
            this.custRegDiscountLabel.Name = "custRegDiscountLabel";
            this.custRegDiscountLabel.Size = new System.Drawing.Size(91, 15);
            this.custRegDiscountLabel.TabIndex = 10;
            this.custRegDiscountLabel.Text = "Select Discount:";
            // 
            // custRegDiscountBox
            // 
            this.custRegDiscountBox.FormattingEnabled = true;
            this.custRegDiscountBox.Items.AddRange(new object[] {
            "Veteran",
            "Senior",
            "Teacher",
            "None"});
            this.custRegDiscountBox.Location = new System.Drawing.Point(208, 54);
            this.custRegDiscountBox.Name = "custRegDiscountBox";
            this.custRegDiscountBox.Size = new System.Drawing.Size(75, 76);
            this.custRegDiscountBox.TabIndex = 4;
            // 
            // customerSearchGroupBox
            // 
            this.customerSearchGroupBox.Controls.Add(this.label4);
            this.customerSearchGroupBox.Controls.Add(this.editDiscountLabel);
            this.customerSearchGroupBox.Controls.Add(this.custDiscountEditBox);
            this.customerSearchGroupBox.Controls.Add(this.custNewEmailTextbox);
            this.customerSearchGroupBox.Controls.Add(this.custNewPhoneTextbox);
            this.customerSearchGroupBox.Controls.Add(this.custNewNameTextbox);
            this.customerSearchGroupBox.Controls.Add(this.custNewEmailLabel);
            this.customerSearchGroupBox.Controls.Add(this.custNewPhoneLabel);
            this.customerSearchGroupBox.Controls.Add(this.custNewFirstNameLabel);
            this.customerSearchGroupBox.Controls.Add(this.label2);
            this.customerSearchGroupBox.Controls.Add(this.label1);
            this.customerSearchGroupBox.Controls.Add(this.deleteCustomerBtn);
            this.customerSearchGroupBox.Controls.Add(this.editCustomerBtn);
            this.customerSearchGroupBox.Controls.Add(this.customerSearchButton);
            this.customerSearchGroupBox.Controls.Add(this.customerNameSearchTextbox);
            this.customerSearchGroupBox.Controls.Add(this.custFnameSearchLabel);
            this.customerSearchGroupBox.Location = new System.Drawing.Point(323, 12);
            this.customerSearchGroupBox.Name = "customerSearchGroupBox";
            this.customerSearchGroupBox.Size = new System.Drawing.Size(465, 207);
            this.customerSearchGroupBox.TabIndex = 10;
            this.customerSearchGroupBox.TabStop = false;
            this.customerSearchGroupBox.Text = "Customer Search and Edit";
            this.customerSearchGroupBox.Enter += new System.EventHandler(this.customerSearchGroupBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "A customer must be searched for before they can be edited";
            // 
            // editDiscountLabel
            // 
            this.editDiscountLabel.AutoSize = true;
            this.editDiscountLabel.Location = new System.Drawing.Point(366, 27);
            this.editDiscountLabel.Name = "editDiscountLabel";
            this.editDiscountLabel.Size = new System.Drawing.Size(91, 15);
            this.editDiscountLabel.TabIndex = 23;
            this.editDiscountLabel.Text = "Select Discount:";
            // 
            // custDiscountEditBox
            // 
            this.custDiscountEditBox.FormattingEnabled = true;
            this.custDiscountEditBox.Items.AddRange(new object[] {
            "Veteran",
            "Senior",
            "Teacher",
            "None"});
            this.custDiscountEditBox.Location = new System.Drawing.Point(382, 59);
            this.custDiscountEditBox.Name = "custDiscountEditBox";
            this.custDiscountEditBox.Size = new System.Drawing.Size(75, 76);
            this.custDiscountEditBox.TabIndex = 9;
            // 
            // custNewEmailTextbox
            // 
            this.custNewEmailTextbox.Location = new System.Drawing.Point(254, 94);
            this.custNewEmailTextbox.Name = "custNewEmailTextbox";
            this.custNewEmailTextbox.Size = new System.Drawing.Size(100, 23);
            this.custNewEmailTextbox.TabIndex = 8;
            this.custNewEmailTextbox.TextChanged += new System.EventHandler(this.custNewEmailTextbox_TextChanged);
            // 
            // custNewPhoneTextbox
            // 
            this.custNewPhoneTextbox.Location = new System.Drawing.Point(254, 65);
            this.custNewPhoneTextbox.Name = "custNewPhoneTextbox";
            this.custNewPhoneTextbox.Size = new System.Drawing.Size(100, 23);
            this.custNewPhoneTextbox.TabIndex = 7;
            this.custNewPhoneTextbox.TextChanged += new System.EventHandler(this.custNewPhoneTextbox_TextChanged);
            // 
            // custNewNameTextbox
            // 
            this.custNewNameTextbox.Location = new System.Drawing.Point(254, 36);
            this.custNewNameTextbox.Name = "custNewNameTextbox";
            this.custNewNameTextbox.Size = new System.Drawing.Size(100, 23);
            this.custNewNameTextbox.TabIndex = 5;
            // 
            // custNewEmailLabel
            // 
            this.custNewEmailLabel.AutoSize = true;
            this.custNewEmailLabel.Location = new System.Drawing.Point(209, 102);
            this.custNewEmailLabel.Name = "custNewEmailLabel";
            this.custNewEmailLabel.Size = new System.Drawing.Size(39, 15);
            this.custNewEmailLabel.TabIndex = 18;
            this.custNewEmailLabel.Text = "Email:";
            // 
            // custNewPhoneLabel
            // 
            this.custNewPhoneLabel.AutoSize = true;
            this.custNewPhoneLabel.Location = new System.Drawing.Point(204, 73);
            this.custNewPhoneLabel.Name = "custNewPhoneLabel";
            this.custNewPhoneLabel.Size = new System.Drawing.Size(44, 15);
            this.custNewPhoneLabel.TabIndex = 17;
            this.custNewPhoneLabel.Text = "Phone:";
            // 
            // custNewFirstNameLabel
            // 
            this.custNewFirstNameLabel.AutoSize = true;
            this.custNewFirstNameLabel.Location = new System.Drawing.Point(206, 44);
            this.custNewFirstNameLabel.Name = "custNewFirstNameLabel";
            this.custNewFirstNameLabel.Size = new System.Drawing.Size(42, 15);
            this.custNewFirstNameLabel.TabIndex = 15;
            this.custNewFirstNameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(104, 107);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteCustomerBtn.TabIndex = 4;
            this.deleteCustomerBtn.Text = "Delete";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click_1);
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.Location = new System.Drawing.Point(265, 123);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.editCustomerBtn.TabIndex = 10;
            this.editCustomerBtn.Text = "Edit";
            this.editCustomerBtn.UseVisualStyleBackColor = true;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.Location = new System.Drawing.Point(9, 107);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new System.Drawing.Size(75, 23);
            this.customerSearchButton.TabIndex = 3;
            this.customerSearchButton.Text = "Search";
            this.customerSearchButton.UseVisualStyleBackColor = true;
            this.customerSearchButton.Click += new System.EventHandler(this.customerSearchButton_Click_1);
            // 
            // customerNameSearchTextbox
            // 
            this.customerNameSearchTextbox.Location = new System.Drawing.Point(57, 62);
            this.customerNameSearchTextbox.Name = "customerNameSearchTextbox";
            this.customerNameSearchTextbox.Size = new System.Drawing.Size(100, 23);
            this.customerNameSearchTextbox.TabIndex = 1;
            // 
            // custFnameSearchLabel
            // 
            this.custFnameSearchLabel.AutoSize = true;
            this.custFnameSearchLabel.Location = new System.Drawing.Point(9, 70);
            this.custFnameSearchLabel.Name = "custFnameSearchLabel";
            this.custFnameSearchLabel.Size = new System.Drawing.Size(42, 15);
            this.custFnameSearchLabel.TabIndex = 0;
            this.custFnameSearchLabel.Text = "Name:";
            // 
            // customerCheckoutGroupbox
            // 
            this.customerCheckoutGroupbox.Controls.Add(this.viewPastInvoicesBtn);
            this.customerCheckoutGroupbox.Controls.Add(this.viewInvoicesLabel);
            this.customerCheckoutGroupbox.Controls.Add(this.productCheckoutComboBox);
            this.customerCheckoutGroupbox.Controls.Add(this.custCheckoutComboBox);
            this.customerCheckoutGroupbox.Controls.Add(this.quantitylabel);
            this.customerCheckoutGroupbox.Controls.Add(this.productSelectionLabel);
            this.customerCheckoutGroupbox.Controls.Add(this.customerCheckoutSelectionLabel);
            this.customerCheckoutGroupbox.Controls.Add(this.generateInvoiceBtn);
            this.customerCheckoutGroupbox.Controls.Add(this.addItemBtn);
            this.customerCheckoutGroupbox.Controls.Add(this.productQuantityUpDown);
            this.customerCheckoutGroupbox.Location = new System.Drawing.Point(323, 233);
            this.customerCheckoutGroupbox.Name = "customerCheckoutGroupbox";
            this.customerCheckoutGroupbox.Size = new System.Drawing.Size(465, 167);
            this.customerCheckoutGroupbox.TabIndex = 11;
            this.customerCheckoutGroupbox.TabStop = false;
            this.customerCheckoutGroupbox.Text = "Customer Checkout";
            this.customerCheckoutGroupbox.Enter += new System.EventHandler(this.customerCheckoutGroupbox_Enter);
            // 
            // viewPastInvoicesBtn
            // 
            this.viewPastInvoicesBtn.Location = new System.Drawing.Point(301, 61);
            this.viewPastInvoicesBtn.Name = "viewPastInvoicesBtn";
            this.viewPastInvoicesBtn.Size = new System.Drawing.Size(158, 23);
            this.viewPastInvoicesBtn.TabIndex = 16;
            this.viewPastInvoicesBtn.Text = "View Past Invoices";
            this.viewPastInvoicesBtn.UseVisualStyleBackColor = true;
            this.viewPastInvoicesBtn.Click += new System.EventHandler(this.viewPastInvoicesBtn_Click);
            // 
            // viewInvoicesLabel
            // 
            this.viewInvoicesLabel.AutoSize = true;
            this.viewInvoicesLabel.Location = new System.Drawing.Point(327, 33);
            this.viewInvoicesLabel.Name = "viewInvoicesLabel";
            this.viewInvoicesLabel.Size = new System.Drawing.Size(103, 15);
            this.viewInvoicesLabel.TabIndex = 14;
            this.viewInvoicesLabel.Text = "View Past Invoices";
            // 
            // productCheckoutComboBox
            // 
            this.productCheckoutComboBox.FormattingEnabled = true;
            this.productCheckoutComboBox.Location = new System.Drawing.Point(118, 62);
            this.productCheckoutComboBox.Name = "productCheckoutComboBox";
            this.productCheckoutComboBox.Size = new System.Drawing.Size(121, 23);
            this.productCheckoutComboBox.TabIndex = 13;
            this.productCheckoutComboBox.SelectedIndexChanged += new System.EventHandler(this.productCheckoutComboBox_SelectedIndexChanged);
            // 
            // custCheckoutComboBox
            // 
            this.custCheckoutComboBox.FormattingEnabled = true;
            this.custCheckoutComboBox.Location = new System.Drawing.Point(118, 31);
            this.custCheckoutComboBox.Name = "custCheckoutComboBox";
            this.custCheckoutComboBox.Size = new System.Drawing.Size(121, 23);
            this.custCheckoutComboBox.TabIndex = 9;
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Location = new System.Drawing.Point(123, 91);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(56, 15);
            this.quantitylabel.TabIndex = 8;
            this.quantitylabel.Text = "Quantity:";
            // 
            // productSelectionLabel
            // 
            this.productSelectionLabel.AutoSize = true;
            this.productSelectionLabel.Location = new System.Drawing.Point(12, 65);
            this.productSelectionLabel.Name = "productSelectionLabel";
            this.productSelectionLabel.Size = new System.Drawing.Size(95, 15);
            this.productSelectionLabel.TabIndex = 7;
            this.productSelectionLabel.Text = "Select a product:";
            // 
            // customerCheckoutSelectionLabel
            // 
            this.customerCheckoutSelectionLabel.AutoSize = true;
            this.customerCheckoutSelectionLabel.Location = new System.Drawing.Point(9, 34);
            this.customerCheckoutSelectionLabel.Name = "customerCheckoutSelectionLabel";
            this.customerCheckoutSelectionLabel.Size = new System.Drawing.Size(103, 15);
            this.customerCheckoutSelectionLabel.TabIndex = 6;
            this.customerCheckoutSelectionLabel.Text = "Select a customer:";
            // 
            // generateInvoiceBtn
            // 
            this.generateInvoiceBtn.Location = new System.Drawing.Point(12, 138);
            this.generateInvoiceBtn.Name = "generateInvoiceBtn";
            this.generateInvoiceBtn.Size = new System.Drawing.Size(151, 23);
            this.generateInvoiceBtn.TabIndex = 6;
            this.generateInvoiceBtn.Text = "Create Invoice";
            this.generateInvoiceBtn.UseVisualStyleBackColor = true;
            this.generateInvoiceBtn.Click += new System.EventHandler(this.generateInvoiceBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(32, 91);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 5;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // productQuantityUpDown
            // 
            this.productQuantityUpDown.Location = new System.Drawing.Point(185, 91);
            this.productQuantityUpDown.Name = "productQuantityUpDown";
            this.productQuantityUpDown.Size = new System.Drawing.Size(54, 23);
            this.productQuantityUpDown.TabIndex = 4;
            this.productQuantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // searchProductGroupbox
            // 
            this.searchProductGroupbox.Controls.Add(this.label3);
            this.searchProductGroupbox.Controls.Add(this.deleteProductButton);
            this.searchProductGroupbox.Controls.Add(this.addProductButton);
            this.searchProductGroupbox.Controls.Add(this.productCategoryLabel);
            this.searchProductGroupbox.Controls.Add(this.productCategoryTxtbx);
            this.searchProductGroupbox.Controls.Add(this.productPriceTxtbx);
            this.searchProductGroupbox.Controls.Add(this.productPricelabel);
            this.searchProductGroupbox.Controls.Add(this.productEditBtn);
            this.searchProductGroupbox.Controls.Add(this.productSearchButton);
            this.searchProductGroupbox.Controls.Add(this.productNameSearchTxtbx);
            this.searchProductGroupbox.Controls.Add(this.productNameSearchLabel);
            this.searchProductGroupbox.Location = new System.Drawing.Point(6, 233);
            this.searchProductGroupbox.Name = "searchProductGroupbox";
            this.searchProductGroupbox.Size = new System.Drawing.Size(311, 167);
            this.searchProductGroupbox.TabIndex = 12;
            this.searchProductGroupbox.TabStop = false;
            this.searchProductGroupbox.Text = "Search Product";
            this.searchProductGroupbox.Enter += new System.EventHandler(this.searchProductGroupbox_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Products that have been purchased cannot be deleted";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(214, 124);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(73, 23);
            this.deleteProductButton.TabIndex = 22;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(118, 124);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(81, 23);
            this.addProductButton.TabIndex = 21;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Location = new System.Drawing.Point(35, 91);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(58, 15);
            this.productCategoryLabel.TabIndex = 20;
            this.productCategoryLabel.Text = "Category:";
            // 
            // productCategoryTxtbx
            // 
            this.productCategoryTxtbx.Location = new System.Drawing.Point(100, 83);
            this.productCategoryTxtbx.Name = "productCategoryTxtbx";
            this.productCategoryTxtbx.Size = new System.Drawing.Size(100, 23);
            this.productCategoryTxtbx.TabIndex = 4;
            // 
            // productPriceTxtbx
            // 
            this.productPriceTxtbx.Location = new System.Drawing.Point(99, 54);
            this.productPriceTxtbx.Name = "productPriceTxtbx";
            this.productPriceTxtbx.Size = new System.Drawing.Size(100, 23);
            this.productPriceTxtbx.TabIndex = 3;
            // 
            // productPricelabel
            // 
            this.productPricelabel.AutoSize = true;
            this.productPricelabel.Location = new System.Drawing.Point(57, 62);
            this.productPricelabel.Name = "productPricelabel";
            this.productPricelabel.Size = new System.Drawing.Size(36, 15);
            this.productPricelabel.TabIndex = 16;
            this.productPricelabel.Text = "Price:";
            // 
            // productEditBtn
            // 
            this.productEditBtn.Location = new System.Drawing.Point(16, 124);
            this.productEditBtn.Name = "productEditBtn";
            this.productEditBtn.Size = new System.Drawing.Size(77, 23);
            this.productEditBtn.TabIndex = 5;
            this.productEditBtn.Text = "Edit";
            this.productEditBtn.UseVisualStyleBackColor = true;
            this.productEditBtn.Click += new System.EventHandler(this.ProductEditBtn_Click);
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(214, 27);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productSearchButton.TabIndex = 2;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.ProductSearchButton_Click);
            // 
            // productNameSearchTxtbx
            // 
            this.productNameSearchTxtbx.Location = new System.Drawing.Point(99, 25);
            this.productNameSearchTxtbx.Name = "productNameSearchTxtbx";
            this.productNameSearchTxtbx.Size = new System.Drawing.Size(100, 23);
            this.productNameSearchTxtbx.TabIndex = 1;
            // 
            // productNameSearchLabel
            // 
            this.productNameSearchLabel.AutoSize = true;
            this.productNameSearchLabel.Location = new System.Drawing.Point(6, 31);
            this.productNameSearchLabel.Name = "productNameSearchLabel";
            this.productNameSearchLabel.Size = new System.Drawing.Size(87, 15);
            this.productNameSearchLabel.TabIndex = 13;
            this.productNameSearchLabel.Text = "Product Name:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.searchProductGroupbox);
            this.Controls.Add(this.customerCheckoutGroupbox);
            this.Controls.Add(this.customerSearchGroupBox);
            this.Controls.Add(this.custRegGroupbox);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.custRegGroupbox.ResumeLayout(false);
            this.custRegGroupbox.PerformLayout();
            this.customerSearchGroupBox.ResumeLayout(false);
            this.customerSearchGroupBox.PerformLayout();
            this.customerCheckoutGroupbox.ResumeLayout(false);
            this.customerCheckoutGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityUpDown)).EndInit();
            this.searchProductGroupbox.ResumeLayout(false);
            this.searchProductGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        private void customerCheckoutGroupbox_Enter(object sender, EventArgs e)
        {
        }

        private void customerSearchGroupBox_Enter(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.TextBox customerPhoneTextbox;
        private System.Windows.Forms.TextBox customerEmailTextbox;
        private System.Windows.Forms.Label custNameRegLabel;
        private System.Windows.Forms.Label custPhoneRegLabel;
        private System.Windows.Forms.Label custEmailRegLabel;
        private System.Windows.Forms.GroupBox custRegGroupbox;
        private System.Windows.Forms.Button custRegSubmitButton;
        private System.Windows.Forms.Label custRegPasswordLabel;
        private System.Windows.Forms.Label custRegDiscountLabel;
        private System.Windows.Forms.CheckedListBox custRegDiscountBox;
        private System.Windows.Forms.GroupBox customerSearchGroupBox;
        private System.Windows.Forms.Button customerSearchButton;
        private System.Windows.Forms.TextBox customerNameSearchTextbox;
        private System.Windows.Forms.Label custFnameSearchLabel;
        private System.Windows.Forms.GroupBox customerCheckoutGroupbox;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button editCustomerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custNewEmailTextbox;
        private System.Windows.Forms.TextBox custNewPhoneTextbox;
        private System.Windows.Forms.TextBox custNewNameTextbox;
        private System.Windows.Forms.Label custNewEmailLabel;
        private System.Windows.Forms.Label custNewPhoneLabel;
        private System.Windows.Forms.Label custNewFirstNameLabel;
        private System.Windows.Forms.Label editDiscountLabel;
        private System.Windows.Forms.CheckedListBox custDiscountEditBox;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.Label productSelectionLabel;
        private System.Windows.Forms.Label customerCheckoutSelectionLabel;
        private System.Windows.Forms.Button generateInvoiceBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.NumericUpDown productQuantityUpDown;
        private System.Windows.Forms.GroupBox searchProductGroupbox;
        private System.Windows.Forms.Label productNameSearchLabel;
        private System.Windows.Forms.TextBox productNameSearchTxtbx;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.Button productEditBtn;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.TextBox productCategoryTxtbx;
        private System.Windows.Forms.TextBox productPriceTxtbx;
        private System.Windows.Forms.Label productPricelabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.TextBox customerUsernameTextbox;
        private System.Windows.Forms.Label custUsernameLabel;
        private System.Windows.Forms.TextBox custRegPasswordTextbox;
        private System.Windows.Forms.ComboBox custCheckoutComboBox;
        private System.Windows.Forms.ComboBox productCheckoutComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label viewInvoicesLabel;
        private System.Windows.Forms.Button viewPastInvoicesBtn;
        private System.Windows.Forms.Label label4;
    }
}