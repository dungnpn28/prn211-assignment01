
namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            label1 = new Label();
            btnFind = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvMemberList = new DataGridView();
            btnClose = new Button();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            txtPassword = new TextBox();
            txtMemberName = new TextBox();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            lbEmail = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbMemberName = new Label();
            lbPassword = new Label();
            lbMemberID = new Label();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            lbFindCountry = new Label();
            lbFindCity = new Label();
            txtSearchCountry = new TextBox();
            txtSearchCity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 157);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 46;
            label1.Text = "ID and/or Name";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(543, 195);
            btnFind.Margin = new Padding(3, 2, 3, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(82, 22);
            btnFind.TabIndex = 45;
            btnFind.Text = "&Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(543, 154);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(110, 154);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Seach member";
            txtSearch.Size = new Size(427, 23);
            txtSearch.TabIndex = 40;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(12, 243);
            dgvMemberList.Margin = new Padding(3, 2, 3, 2);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(637, 166);
            dgvMemberList.TabIndex = 39;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(294, 425);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 38;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(37, 126);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 37;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(134, 126);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 22);
            btnNew.TabIndex = 36;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(231, 126);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(110, 81);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(192, 23);
            txtPassword.TabIndex = 33;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(110, 47);
            txtMemberName.Margin = new Padding(3, 2, 3, 2);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(192, 23);
            txtMemberName.TabIndex = 32;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(110, 10);
            txtMemberID.Margin = new Padding(3, 2, 3, 2);
            txtMemberID.Multiline = true;
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(192, 23);
            txtMemberID.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(413, 10);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 30;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(348, 13);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 29;
            lbEmail.Text = "Email";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(348, 84);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 28;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(348, 50);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 27;
            lbCountry.Text = "Country";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(37, 50);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(39, 15);
            lbMemberName.TabIndex = 26;
            lbMemberName.Text = "Name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(37, 84);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 25;
            lbPassword.Text = "Password";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(37, 13);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(18, 15);
            lbMemberID.TabIndex = 24;
            lbMemberID.Text = "ID";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(413, 47);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(219, 23);
            txtCountry.TabIndex = 47;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(413, 81);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(219, 23);
            txtCity.TabIndex = 48;
            // 
            // lbFindCountry
            // 
            lbFindCountry.AutoSize = true;
            lbFindCountry.Location = new Point(37, 187);
            lbFindCountry.Name = "lbFindCountry";
            lbFindCountry.Size = new Size(50, 15);
            lbFindCountry.TabIndex = 49;
            lbFindCountry.Text = "Country";
            // 
            // lbFindCity
            // 
            lbFindCity.AutoSize = true;
            lbFindCity.Location = new Point(48, 214);
            lbFindCity.Name = "lbFindCity";
            lbFindCity.Size = new Size(28, 15);
            lbFindCity.TabIndex = 50;
            lbFindCity.Text = "City";
            // 
            // txtSearchCountry
            // 
            txtSearchCountry.Location = new Point(110, 184);
            txtSearchCountry.Margin = new Padding(3, 2, 3, 2);
            txtSearchCountry.Name = "txtSearchCountry";
            txtSearchCountry.PlaceholderText = "Search by country";
            txtSearchCountry.Size = new Size(203, 23);
            txtSearchCountry.TabIndex = 51;
            // 
            // txtSearchCity
            // 
            txtSearchCity.Location = new Point(110, 211);
            txtSearchCity.Margin = new Padding(3, 2, 3, 2);
            txtSearchCity.Name = "txtSearchCity";
            txtSearchCity.PlaceholderText = "Search by city";
            txtSearchCity.Size = new Size(203, 23);
            txtSearchCity.TabIndex = 52;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 458);
            Controls.Add(txtSearchCity);
            Controls.Add(txtSearchCountry);
            Controls.Add(lbFindCity);
            Controls.Add(lbFindCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(label1);
            Controls.Add(btnFind);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
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
            Name = "frmMemberManagement";
            Text = "Member Page";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbFindCountry;
        private System.Windows.Forms.Label lbFindCity;
        private System.Windows.Forms.TextBox txtSearchCountry;
        private System.Windows.Forms.TextBox txtSearchCity;
    }
}