namespace MyStoreWinApp
{
    partial class frmLogin
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
            btnLogin = new Button();
            btnCancel = new Button();
            lbLogin = new Label();
            lbUsername = new Label();
            lbPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(331, 437);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(624, 437);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.Location = new Point(477, 73);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(142, 60);
            lbLogin.TabIndex = 2;
            lbLogin.Text = "Login";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(198, 200);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(121, 32);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(198, 314);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(111, 32);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(331, 200);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(439, 39);
            txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(331, 311);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(443, 39);
            txtPassword.TabIndex = 6;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 670);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(lbLogin);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnCancel;
        private Label lbLogin;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}