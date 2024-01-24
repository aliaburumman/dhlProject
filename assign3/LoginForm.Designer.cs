namespace assign3
{
    partial class LoginForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelpass = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Location = new System.Drawing.Point(234, 210);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(78, 20);
            this.labelpass.TabIndex = 8;
            this.labelpass.Text = "Password";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(229, 157);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(83, 20);
            this.labelname.TabIndex = 7;
            this.labelname.Text = "Username";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(349, 207);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(222, 26);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(349, 151);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(222, 26);
            this.Username.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "LoginForm";
            this.Text = "DHL - Login Screen";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
    }
}