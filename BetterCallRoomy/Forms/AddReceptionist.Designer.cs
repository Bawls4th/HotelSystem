namespace BetterCallRoomy.Forms
{
    partial class AddReceptionist
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
            label7 = new Label();
            dataReceptionistList = new DataGridView();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            txtSearch = new TextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbID = new RadioButton();
            rbName = new RadioButton();
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label6 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            rbUsername = new RadioButton();
            mtxtContacNo = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataReceptionistList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(335, 77);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 94;
            label7.Text = "Contact No:";
            // 
            // dataReceptionistList
            // 
            dataReceptionistList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataReceptionistList.Location = new Point(6, 237);
            dataReceptionistList.Margin = new Padding(2);
            dataReceptionistList.Name = "dataReceptionistList";
            dataReceptionistList.RowHeadersWidth = 62;
            dataReceptionistList.Size = new Size(754, 343);
            dataReceptionistList.TabIndex = 92;
            dataReceptionistList.CellContentClick += dataReceptionistList_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(254, 187);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 37);
            btnDelete.TabIndex = 90;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(407, 187);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(224, 35);
            btnClear.TabIndex = 91;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(130, 187);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 37);
            btnUpdate.TabIndex = 89;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(7, 189);
            btnInsert.Margin = new Padding(2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(118, 35);
            btnInsert.TabIndex = 88;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(254, 30);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 33);
            txtSearch.TabIndex = 76;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(139, 143);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 29);
            txtEmail.TabIndex = 72;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(7, 145);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 87;
            label9.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(335, 113);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 85;
            label4.Text = "User Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(335, 148);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 84;
            label5.Text = "Password:";
            // 
            // rbID
            // 
            rbID.AutoSize = true;
            rbID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbID.Location = new Point(5, 32);
            rbID.Margin = new Padding(2);
            rbID.Name = "rbID";
            rbID.Size = new Size(43, 25);
            rbID.TabIndex = 83;
            rbID.TabStop = true;
            rbID.Text = "ID";
            rbID.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            rbName.AutoSize = true;
            rbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbName.Location = new Point(68, 32);
            rbName.Margin = new Padding(2);
            rbName.Name = "rbName";
            rbName.Size = new Size(70, 25);
            rbName.TabIndex = 81;
            rbName.TabStop = true;
            rbName.Text = "Name";
            rbName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 3);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 80;
            label1.Text = "Search";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(139, 107);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(168, 29);
            txtLastName.TabIndex = 70;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(139, 74);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(168, 29);
            txtFirstName.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 110);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 78;
            label6.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 77;
            label2.Text = "First Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(594, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 290);
            pictureBox1.TabIndex = 93;
            pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(462, 110);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(169, 29);
            txtUserName.TabIndex = 96;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(462, 142);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(169, 29);
            txtPassword.TabIndex = 97;
            // 
            // rbUsername
            // 
            rbUsername.AutoSize = true;
            rbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbUsername.Location = new Point(151, 32);
            rbUsername.Margin = new Padding(2);
            rbUsername.Name = "rbUsername";
            rbUsername.Size = new Size(99, 25);
            rbUsername.TabIndex = 98;
            rbUsername.TabStop = true;
            rbUsername.Text = "Username";
            rbUsername.UseVisualStyleBackColor = true;
            // 
            // mtxtContacNo
            // 
            mtxtContacNo.Font = new Font("Segoe UI", 12F);
            mtxtContacNo.Location = new Point(462, 74);
            mtxtContacNo.Mask = "0000-000-0000";
            mtxtContacNo.Name = "mtxtContacNo";
            mtxtContacNo.Size = new Size(169, 29);
            mtxtContacNo.TabIndex = 99;
            // 
            // AddReceptionist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(927, 588);
            Controls.Add(mtxtContacNo);
            Controls.Add(rbUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label7);
            Controls.Add(dataReceptionistList);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtSearch);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(rbID);
            Controls.Add(rbName);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "AddReceptionist";
            Text = "AddReceptionist";
            Load += AddReceptionist_Load;
            ((System.ComponentModel.ISupportInitialize)dataReceptionistList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private DataGridView dataReceptionistList;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox txtSearch;
        private TextBox txtEmail;
        private Label label9;
        private Label label4;
        private Label label5;
        private RadioButton rbID;
        private RadioButton rbName;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label6;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private RadioButton rbUsername;
        private MaskedTextBox mtxtContacNo;
    }
}