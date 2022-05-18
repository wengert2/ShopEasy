
namespace ShopEasy
{
    partial class customerLoginForm
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
            this.customerUsernameLabel = new System.Windows.Forms.Label();
            this.customerPasswordLabel = new System.Windows.Forms.Label();
            this.customerUsernameTextbox = new System.Windows.Forms.TextBox();
            this.customerLoginSubmitButton = new System.Windows.Forms.Button();
            this.customerPasswordTextbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // customerUsernameLabel
            // 
            this.customerUsernameLabel.AutoSize = true;
            this.customerUsernameLabel.Location = new System.Drawing.Point(23, 20);
            this.customerUsernameLabel.Name = "customerUsernameLabel";
            this.customerUsernameLabel.Size = new System.Drawing.Size(63, 15);
            this.customerUsernameLabel.TabIndex = 0;
            this.customerUsernameLabel.Text = "Username:";
            // 
            // customerPasswordLabel
            // 
            this.customerPasswordLabel.AutoSize = true;
            this.customerPasswordLabel.Location = new System.Drawing.Point(23, 61);
            this.customerPasswordLabel.Name = "customerPasswordLabel";
            this.customerPasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.customerPasswordLabel.TabIndex = 1;
            this.customerPasswordLabel.Text = "Password:";
            // 
            // customerUsernameTextbox
            // 
            this.customerUsernameTextbox.Location = new System.Drawing.Point(134, 12);
            this.customerUsernameTextbox.Name = "customerUsernameTextbox";
            this.customerUsernameTextbox.Size = new System.Drawing.Size(100, 23);
            this.customerUsernameTextbox.TabIndex = 1;
            // 
            // customerLoginSubmitButton
            // 
            this.customerLoginSubmitButton.Location = new System.Drawing.Point(69, 102);
            this.customerLoginSubmitButton.Name = "customerLoginSubmitButton";
            this.customerLoginSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.customerLoginSubmitButton.TabIndex = 3;
            this.customerLoginSubmitButton.Text = "Submit";
            this.customerLoginSubmitButton.UseVisualStyleBackColor = true;
            this.customerLoginSubmitButton.Click += new System.EventHandler(this.customerLoginSubmitButton_Click);
            // 
            // customerPasswordTextbox
            // 
            this.customerPasswordTextbox.Location = new System.Drawing.Point(134, 53);
            this.customerPasswordTextbox.Name = "customerPasswordTextbox";
            this.customerPasswordTextbox.PasswordChar = '*';
            this.customerPasswordTextbox.Size = new System.Drawing.Size(100, 23);
            this.customerPasswordTextbox.TabIndex = 2;
            // 
            // customerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 153);
            this.Controls.Add(this.customerPasswordTextbox);
            this.Controls.Add(this.customerLoginSubmitButton);
            this.Controls.Add(this.customerUsernameTextbox);
            this.Controls.Add(this.customerPasswordLabel);
            this.Controls.Add(this.customerUsernameLabel);
            this.Name = "customerLoginForm";
            this.Text = "Customer Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerUsernameLabel;
        private System.Windows.Forms.Label customerPasswordLabel;
        private System.Windows.Forms.TextBox customerUsernameTextbox;
        private System.Windows.Forms.Button customerLoginSubmitButton;
        private System.Windows.Forms.MaskedTextBox customerPasswordTextbox;
    }
}