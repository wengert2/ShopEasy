
namespace ShopEasy
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerWelcomeButton = new System.Windows.Forms.Button();
            this.employeeWelcomeButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerWelcomeButton
            // 
            this.customerWelcomeButton.Location = new System.Drawing.Point(70, 41);
            this.customerWelcomeButton.Name = "customerWelcomeButton";
            this.customerWelcomeButton.Size = new System.Drawing.Size(75, 23);
            this.customerWelcomeButton.TabIndex = 0;
            this.customerWelcomeButton.Text = "Customer";
            this.customerWelcomeButton.UseVisualStyleBackColor = true;
            this.customerWelcomeButton.Click += new System.EventHandler(this.customerWelcomeButton_Click);
            // 
            // employeeWelcomeButton
            // 
            this.employeeWelcomeButton.Location = new System.Drawing.Point(70, 86);
            this.employeeWelcomeButton.Name = "employeeWelcomeButton";
            this.employeeWelcomeButton.Size = new System.Drawing.Size(75, 23);
            this.employeeWelcomeButton.TabIndex = 1;
            this.employeeWelcomeButton.Text = "Employee";
            this.employeeWelcomeButton.UseVisualStyleBackColor = true;
            this.employeeWelcomeButton.Click += new System.EventHandler(this.employeeWelcomeButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(209, 15);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Please select what type of user you are";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 139);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.employeeWelcomeButton);
            this.Controls.Add(this.customerWelcomeButton);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customerWelcomeButton;
        private System.Windows.Forms.Button employeeWelcomeButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

