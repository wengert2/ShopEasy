
namespace ShopEasy
{
    partial class CustomerForm
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
            this.productsListGroupbox = new System.Windows.Forms.GroupBox();
            this.productPriceListbox = new System.Windows.Forms.ListBox();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.customerTransactionsGroupbox = new System.Windows.Forms.GroupBox();
            this.customerInvoicesListBox = new System.Windows.Forms.ListBox();
            this.customerProductSearchGroupbox = new System.Windows.Forms.GroupBox();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.productNameTextbox = new System.Windows.Forms.TextBox();
            this.prodSearchLabel = new System.Windows.Forms.Label();
            this.welcomeToLbl = new System.Windows.Forms.Label();
            this.customerPurchaseGrpBx = new System.Windows.Forms.GroupBox();
            this.generateInvoiceBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.productQtyUpDwn = new System.Windows.Forms.NumericUpDown();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.productsListGroupbox.SuspendLayout();
            this.customerTransactionsGroupbox.SuspendLayout();
            this.customerProductSearchGroupbox.SuspendLayout();
            this.customerPurchaseGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQtyUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // productsListGroupbox
            // 
            this.productsListGroupbox.Controls.Add(this.productPriceListbox);
            this.productsListGroupbox.Controls.Add(this.productListBox);
            this.productsListGroupbox.Location = new System.Drawing.Point(0, 27);
            this.productsListGroupbox.Name = "productsListGroupbox";
            this.productsListGroupbox.Size = new System.Drawing.Size(354, 199);
            this.productsListGroupbox.TabIndex = 0;
            this.productsListGroupbox.TabStop = false;
            this.productsListGroupbox.Text = "Inventory";
            // 
            // productPriceListbox
            // 
            this.productPriceListbox.FormattingEnabled = true;
            this.productPriceListbox.ItemHeight = 15;
            this.productPriceListbox.Location = new System.Drawing.Point(271, 22);
            this.productPriceListbox.Name = "productPriceListbox";
            this.productPriceListbox.Size = new System.Drawing.Size(64, 169);
            this.productPriceListbox.TabIndex = 1;
            this.productPriceListbox.SelectedIndexChanged += new System.EventHandler(this.productPriceListbox_SelectedIndexChanged);
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 15;
            this.productListBox.Location = new System.Drawing.Point(12, 22);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(253, 169);
            this.productListBox.TabIndex = 0;
            this.productListBox.SelectedIndexChanged += new System.EventHandler(this.productListBox_SelectedIndexChanged);
            // 
            // customerTransactionsGroupbox
            // 
            this.customerTransactionsGroupbox.Controls.Add(this.customerInvoicesListBox);
            this.customerTransactionsGroupbox.Location = new System.Drawing.Point(361, 27);
            this.customerTransactionsGroupbox.Name = "customerTransactionsGroupbox";
            this.customerTransactionsGroupbox.Size = new System.Drawing.Size(427, 199);
            this.customerTransactionsGroupbox.TabIndex = 1;
            this.customerTransactionsGroupbox.TabStop = false;
            this.customerTransactionsGroupbox.Text = "Past Transactions";
            // 
            // customerInvoicesListBox
            // 
            this.customerInvoicesListBox.FormattingEnabled = true;
            this.customerInvoicesListBox.ItemHeight = 15;
            this.customerInvoicesListBox.Location = new System.Drawing.Point(6, 22);
            this.customerInvoicesListBox.Name = "customerInvoicesListBox";
            this.customerInvoicesListBox.Size = new System.Drawing.Size(411, 169);
            this.customerInvoicesListBox.TabIndex = 0;
            this.customerInvoicesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // customerProductSearchGroupbox
            // 
            this.customerProductSearchGroupbox.Controls.Add(this.productSearchBtn);
            this.customerProductSearchGroupbox.Controls.Add(this.productNameTextbox);
            this.customerProductSearchGroupbox.Controls.Add(this.prodSearchLabel);
            this.customerProductSearchGroupbox.Location = new System.Drawing.Point(0, 232);
            this.customerProductSearchGroupbox.Name = "customerProductSearchGroupbox";
            this.customerProductSearchGroupbox.Size = new System.Drawing.Size(354, 162);
            this.customerProductSearchGroupbox.TabIndex = 2;
            this.customerProductSearchGroupbox.TabStop = false;
            this.customerProductSearchGroupbox.Text = "Product Search";
            this.customerProductSearchGroupbox.Enter += new System.EventHandler(this.customerProductSearchGroupbox_Enter);
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Location = new System.Drawing.Point(260, 27);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.productSearchBtn.TabIndex = 4;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // productNameTextbox
            // 
            this.productNameTextbox.Location = new System.Drawing.Point(105, 27);
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Size = new System.Drawing.Size(100, 23);
            this.productNameTextbox.TabIndex = 3;
            this.productNameTextbox.TextChanged += new System.EventHandler(this.productNameTextbox_TextChanged);
            // 
            // prodSearchLabel
            // 
            this.prodSearchLabel.AutoSize = true;
            this.prodSearchLabel.Location = new System.Drawing.Point(12, 30);
            this.prodSearchLabel.Name = "prodSearchLabel";
            this.prodSearchLabel.Size = new System.Drawing.Size(87, 15);
            this.prodSearchLabel.TabIndex = 3;
            this.prodSearchLabel.Text = "Product Name:";
            // 
            // welcomeToLbl
            // 
            this.welcomeToLbl.AutoSize = true;
            this.welcomeToLbl.Location = new System.Drawing.Point(12, 9);
            this.welcomeToLbl.Name = "welcomeToLbl";
            this.welcomeToLbl.Size = new System.Drawing.Size(20, 15);
            this.welcomeToLbl.TabIndex = 3;
            this.welcomeToLbl.Text = "lbl";
            this.welcomeToLbl.Click += new System.EventHandler(this.welcomeToLbl_Click);
            // 
            // customerPurchaseGrpBx
            // 
            this.customerPurchaseGrpBx.Controls.Add(this.generateInvoiceBtn);
            this.customerPurchaseGrpBx.Controls.Add(this.addProductBtn);
            this.customerPurchaseGrpBx.Controls.Add(this.productQtyUpDwn);
            this.customerPurchaseGrpBx.Controls.Add(this.productNameComboBox);
            this.customerPurchaseGrpBx.Location = new System.Drawing.Point(367, 232);
            this.customerPurchaseGrpBx.Name = "customerPurchaseGrpBx";
            this.customerPurchaseGrpBx.Size = new System.Drawing.Size(421, 162);
            this.customerPurchaseGrpBx.TabIndex = 4;
            this.customerPurchaseGrpBx.TabStop = false;
            this.customerPurchaseGrpBx.Text = "Purchase";
            this.customerPurchaseGrpBx.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // generateInvoiceBtn
            // 
            this.generateInvoiceBtn.Location = new System.Drawing.Point(140, 133);
            this.generateInvoiceBtn.Name = "generateInvoiceBtn";
            this.generateInvoiceBtn.Size = new System.Drawing.Size(135, 23);
            this.generateInvoiceBtn.TabIndex = 3;
            this.generateInvoiceBtn.Text = "Complete Transaction";
            this.generateInvoiceBtn.UseVisualStyleBackColor = true;
            this.generateInvoiceBtn.Click += new System.EventHandler(this.generateInvoiceBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(220, 40);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(92, 23);
            this.addProductBtn.TabIndex = 2;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // productQtyUpDwn
            // 
            this.productQtyUpDwn.Location = new System.Drawing.Point(160, 40);
            this.productQtyUpDwn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productQtyUpDwn.Name = "productQtyUpDwn";
            this.productQtyUpDwn.Size = new System.Drawing.Size(54, 23);
            this.productQtyUpDwn.TabIndex = 1;
            this.productQtyUpDwn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productQtyUpDwn.ValueChanged += new System.EventHandler(this.productQuantityComboBox_ValueChanged);
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(33, 40);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.productNameComboBox.TabIndex = 0;
            this.productNameComboBox.SelectedIndexChanged += new System.EventHandler(this.productNameComboBox_SelectedIndexChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.customerPurchaseGrpBx);
            this.Controls.Add(this.welcomeToLbl);
            this.Controls.Add(this.customerProductSearchGroupbox);
            this.Controls.Add(this.customerTransactionsGroupbox);
            this.Controls.Add(this.productsListGroupbox);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.productsListGroupbox.ResumeLayout(false);
            this.customerTransactionsGroupbox.ResumeLayout(false);
            this.customerProductSearchGroupbox.ResumeLayout(false);
            this.customerProductSearchGroupbox.PerformLayout();
            this.customerPurchaseGrpBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productQtyUpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox productsListGroupbox;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.ListBox productPriceListbox;
        private System.Windows.Forms.GroupBox customerTransactionsGroupbox;
        private System.Windows.Forms.ListBox customerInvoicesListBox;
        private System.Windows.Forms.GroupBox customerProductSearchGroupbox;
        private System.Windows.Forms.Button productSearchBtn;
        private System.Windows.Forms.TextBox productNameTextbox;
        private System.Windows.Forms.Label prodSearchLabel;
        private System.Windows.Forms.Label welcomeToLbl;
        private System.Windows.Forms.GroupBox customerPurchaseGrpBx;
        private System.Windows.Forms.Button generateInvoiceBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.NumericUpDown productQtyUpDwn;
        private System.Windows.Forms.ComboBox productNameComboBox;
    }
}