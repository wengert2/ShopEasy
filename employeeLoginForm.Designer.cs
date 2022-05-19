
namespace ShopEasy
{
    partial class employeeLoginForm
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
            this.employeeIDLoginLabel = new System.Windows.Forms.Label();
            this.employeePasswordLoginLabel = new System.Windows.Forms.Label();
            this.employeeIDLoginTextbox = new System.Windows.Forms.TextBox();
            this.employeeLoginSubmitButton = new System.Windows.Forms.Button();
            this.employeePasswordLoginTextbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // employeeIDLoginLabel
            // 
            this.employeeIDLoginLabel.AutoSize = true;
            this.employeeIDLoginLabel.Location = new System.Drawing.Point(12, 16);
            this.employeeIDLoginLabel.Name = "employeeIDLoginLabel";
            this.employeeIDLoginLabel.Size = new System.Drawing.Size(63, 15);
            this.employeeIDLoginLabel.TabIndex = 0;
            this.employeeIDLoginLabel.Text = "Username:";
            // 
            // employeePasswordLoginLabel
            // 
            this.employeePasswordLoginLabel.AutoSize = true;
            this.employeePasswordLoginLabel.Location = new System.Drawing.Point(12, 45);
            this.employeePasswordLoginLabel.Name = "employeePasswordLoginLabel";
            this.employeePasswordLoginLabel.Size = new System.Drawing.Size(60, 15);
            this.employeePasswordLoginLabel.TabIndex = 1;
            this.employeePasswordLoginLabel.Text = "Password:";
            // 
            // employeeIDLoginTextbox
            // 
            this.employeeIDLoginTextbox.Location = new System.Drawing.Point(135, 8);
            this.employeeIDLoginTextbox.Name = "employeeIDLoginTextbox";
            this.employeeIDLoginTextbox.Size = new System.Drawing.Size(100, 23);
            this.employeeIDLoginTextbox.TabIndex = 1;
            // 
            // employeeLoginSubmitButton
            // 
            this.employeeLoginSubmitButton.Location = new System.Drawing.Point(83, 97);
            this.employeeLoginSubmitButton.Name = "employeeLoginSubmitButton";
            this.employeeLoginSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.employeeLoginSubmitButton.TabIndex = 3;
            this.employeeLoginSubmitButton.Text = "Submit";
            this.employeeLoginSubmitButton.UseVisualStyleBackColor = true;
            this.employeeLoginSubmitButton.Click += new System.EventHandler(this.employeeLoginSubmitButton_Click);
            // 
            // employeePasswordLoginTextbox
            // 
            this.employeePasswordLoginTextbox.Location = new System.Drawing.Point(135, 42);
            this.employeePasswordLoginTextbox.Name = "employeePasswordLoginTextbox";
            this.employeePasswordLoginTextbox.PasswordChar = '*';
            this.employeePasswordLoginTextbox.Size = new System.Drawing.Size(100, 23);
            this.employeePasswordLoginTextbox.TabIndex = 2;
            // 
            // employeeLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 141);
            this.Controls.Add(this.employeePasswordLoginTextbox);
            this.Controls.Add(this.employeeLoginSubmitButton);
            this.Controls.Add(this.employeeIDLoginTextbox);
            this.Controls.Add(this.employeePasswordLoginLabel);
            this.Controls.Add(this.employeeIDLoginLabel);
            this.Name = "employeeLoginForm";
            this.Text = "Employee Login";
            this.Load += new System.EventHandler(this.employeeLoginForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeIDLoginLabel;
        private System.Windows.Forms.Label employeePasswordLoginLabel;
        private System.Windows.Forms.TextBox employeeIDLoginTextbox;
        private System.Windows.Forms.Button employeeLoginSubmitButton;
        private System.Windows.Forms.MaskedTextBox employeePasswordLoginTextbox;
    }
}