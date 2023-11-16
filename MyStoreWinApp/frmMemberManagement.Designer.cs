namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            cboSearchCountry = new ComboBox();
            cboSearchCity = new ComboBox();
            lbMemberID = new Label();
            lbPassword = new Label();
            lbMemberName = new Label();
            lbCountry = new Label();
            lbCity = new Label();
            lbEmail = new Label();
            txtEmail = new TextBox();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtPassword = new TextBox();
            cboCity = new ComboBox();
            btnDelete = new Button();
            btnNew = new Button();
            btnLoad = new Button();
            btnClose = new Button();
            dgvMemberList = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            cboCountry = new ComboBox();
            btnFind = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // cboSearchCountry
            // 
            cboSearchCountry.FormattingEnabled = true;
            cboSearchCountry.Items.AddRange(new object[] { "Country", "United State", "Viet Nam", "America", "United Kingdom" });
            cboSearchCountry.Location = new Point(230, 414);
            cboSearchCountry.Margin = new Padding(6, 4, 6, 4);
            cboSearchCountry.Name = "cboSearchCountry";
            cboSearchCountry.Size = new Size(340, 40);
            cboSearchCountry.TabIndex = 19;
            cboSearchCountry.Text = "Country";
            cboSearchCountry.SelectedIndexChanged += cboSearchCountry_SelectedIndexChanged;
            // 
            // cboSearchCity
            // 
            cboSearchCity.FormattingEnabled = true;
            cboSearchCity.Items.AddRange(new object[] { "City", "Ho Chi Minh", "Da Nang", "Ha Noi", "Phu Quoc", "Vung Tau" });
            cboSearchCity.Location = new Point(672, 416);
            cboSearchCity.Margin = new Padding(6, 4, 6, 4);
            cboSearchCity.Name = "cboSearchCity";
            cboSearchCity.Size = new Size(348, 40);
            cboSearchCity.TabIndex = 21;
            cboSearchCity.Text = "City";
            cboSearchCity.SelectedIndexChanged += cboSearchCity_SelectedIndexChanged;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(95, 36);
            lbMemberID.Margin = new Padding(6, 0, 6, 0);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(135, 32);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(95, 188);
            lbPassword.Margin = new Padding(6, 0, 6, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(111, 32);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(95, 115);
            lbMemberName.Margin = new Padding(6, 0, 6, 0);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(176, 32);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(672, 119);
            lbCountry.Margin = new Padding(6, 0, 6, 0);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(99, 32);
            lbCountry.TabIndex = 3;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(672, 194);
            lbCity.Margin = new Padding(6, 0, 6, 0);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(55, 32);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(672, 36);
            lbEmail.Margin = new Padding(6, 0, 6, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 32);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(813, 36);
            txtEmail.Margin = new Padding(6, 4, 6, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(403, 39);
            txtEmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(279, 36);
            txtMemberID.Margin = new Padding(6, 4, 6, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(353, 39);
            txtMemberID.TabIndex = 8;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(275, 115);
            txtMemberName.Margin = new Padding(6, 4, 6, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(353, 39);
            txtMemberName.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(279, 188);
            txtPassword.Margin = new Padding(6, 4, 6, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(353, 39);
            txtPassword.TabIndex = 10;
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Items.AddRange(new object[] { "Ho Chi Minh", "Da Nang", "Ha Noi", "Phu Quoc", "Vung Tau" });
            cboCity.Location = new Point(813, 188);
            cboCity.Margin = new Padding(6, 4, 6, 4);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(403, 40);
            cboCity.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(982, 277);
            btnDelete.Margin = new Padding(6, 4, 6, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 47);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(576, 277);
            btnNew.Margin = new Padding(6, 4, 6, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(152, 47);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(173, 277);
            btnLoad.Margin = new Padding(6, 4, 6, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(152, 47);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(576, 813);
            btnClose.Margin = new Padding(6, 4, 6, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(152, 47);
            btnClose.TabIndex = 15;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(19, 469);
            dgvMemberList.Margin = new Padding(6, 4, 6, 4);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(1263, 269);
            dgvMemberList.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(230, 337);
            txtSearch.Margin = new Padding(6, 4, 6, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Seach member";
            txtSearch.Size = new Size(790, 39);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1129, 333);
            btnSearch.Margin = new Padding(6, 4, 6, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 47);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Items.AddRange(new object[] { "Viet Nam", "America", "United State", "United Kingdom" });
            cboCountry.Location = new Point(813, 119);
            cboCountry.Margin = new Padding(6, 4, 6, 4);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(403, 40);
            cboCountry.TabIndex = 20;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1129, 414);
            btnFind.Margin = new Padding(6, 4, 6, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(152, 47);
            btnFind.TabIndex = 22;
            btnFind.Text = "&Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 343);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 23;
            label1.Text = "ID and/or Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 419);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 24;
            label2.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(585, 421);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 25;
            label3.Text = "City";
            label3.Click += label3_Click;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 909);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFind);
            Controls.Add(cboSearchCity);
            Controls.Add(cboCountry);
            Controls.Add(cboSearchCountry);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(cboCity);
            Controls.Add(txtPassword);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(lbMemberName);
            Controls.Add(lbPassword);
            Controls.Add(lbMemberID);
            Margin = new Padding(6, 4, 6, 4);
            Name = "frmMemberManagement";
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private Label lbPassword;
        private Label lbMemberName;
        private Label lbCountry;
        private Label lbCity;
        private Label lbEmail;
        private TextBox txtEmail;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtPassword;
        private ComboBox cboCity;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private Button btnClose;
        private DataGridView dgvMemberList;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cboSearchCountry;
        private ComboBox cboCountry;
        private ComboBox cboSearchCity;
        private Button btnFind;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

