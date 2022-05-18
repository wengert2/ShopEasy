
namespace ShopEasy
{
    partial class CustomerInvoiceListForm
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
            this.invoiceListBox = new System.Windows.Forms.ListBox();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // invoiceListBox
            // 
            this.invoiceListBox.FormattingEnabled = true;
            this.invoiceListBox.ItemHeight = 15;
            this.invoiceListBox.Location = new System.Drawing.Point(12, 45);
            this.invoiceListBox.MultiColumn = true;
            this.invoiceListBox.Name = "invoiceListBox";
            this.invoiceListBox.Size = new System.Drawing.Size(175, 334);
            this.invoiceListBox.TabIndex = 0;
            this.invoiceListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 15;
            this.productListBox.Location = new System.Drawing.Point(488, 45);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(300, 334);
            this.productListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Past Invoices:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purchases:";
            // 
            // CustomerInvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.invoiceListBox);
            this.Name = "CustomerInvoiceListForm";
            this.Text = "CustomerInvoiceListForm";
            this.Load += new System.EventHandler(this.CustomerInvoiceListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox invoiceListBox;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}