
namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            lbMemberID = new Label();
            lbMemberName = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtMemberName = new TextBox();
            txtMemberID = new TextBox();
            cboCity = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            cboCountry = new ComboBox();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(290, 41);
            lbMemberID.Margin = new Padding(6, 0, 6, 0);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(135, 32);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(290, 124);
            lbMemberName.Margin = new Padding(6, 0, 6, 0);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(176, 32);
            lbMemberName.TabIndex = 1;
            lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(290, 226);
            lbEmail.Margin = new Padding(6, 0, 6, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 32);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(290, 316);
            lbPassword.Margin = new Padding(6, 0, 6, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(111, 32);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(290, 510);
            lbCity.Margin = new Padding(6, 0, 6, 0);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(55, 32);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(290, 407);
            lbCountry.Margin = new Padding(6, 0, 6, 0);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(99, 32);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(557, 316);
            txtPassword.Margin = new Padding(6, 4, 6, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(468, 39);
            txtPassword.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(557, 222);
            txtEmail.Margin = new Padding(6, 4, 6, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(468, 39);
            txtEmail.TabIndex = 8;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(557, 124);
            txtMemberName.Margin = new Padding(6, 4, 6, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(468, 39);
            txtMemberName.TabIndex = 9;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(557, 41);
            txtMemberID.Margin = new Padding(6, 4, 6, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(468, 39);
            txtMemberID.TabIndex = 10;
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Items.AddRange(new object[] { "Ho Chi Minh", "Da Nang", "Ha Noi", "Phu Quoc", "Vung Tau" });
            cboCity.Location = new Point(557, 510);
            cboCity.Margin = new Padding(6, 4, 6, 4);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(468, 40);
            cboCity.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(557, 610);
            btnSave.Margin = new Padding(6, 4, 6, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 47);
            btnSave.TabIndex = 13;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(877, 610);
            btnCancel.Margin = new Padding(6, 4, 6, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 47);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Items.AddRange(new object[] { "Viet Nam", "America", "United State", "United Kingdom" });
            cboCountry.Location = new Point(557, 403);
            cboCountry.Margin = new Padding(6, 4, 6, 4);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(468, 40);
            cboCountry.TabIndex = 15;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 721);
            Controls.Add(cboCountry);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboCity);
            Controls.Add(txtMemberID);
            Controls.Add(txtMemberName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberID);
            Margin = new Padding(6, 4, 6, 4);
            Name = "frmMemberDetail";
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private Label lbMemberName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtMemberName;
        private TextBox txtMemberID;
        private ComboBox cboCity;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cboCountry;
    }
}