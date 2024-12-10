namespace BetterCallRoomy
{
    partial class GuestProfiles
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
            rbName = new RadioButton();
            rbID = new RadioButton();
            rbEmail = new RadioButton();
            txtSearch = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            label6 = new Label();
            txtLastName = new TextBox();
            btnGuestInsert = new Button();
            btnUpdate = new Button();
            btnGuestDelete = new Button();
            dataViewList = new DataGridView();
            txtEmail = new TextBox();
            label10 = new Label();
            dateRegistered = new DateTimePicker();
            btnClear = new Button();
            txtMiddleName = new TextBox();
            label3 = new Label();
            dateBirthDate = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            lblAge = new Label();
            label11 = new Label();
            label12 = new Label();
            cbGender = new ComboBox();
            cbEthnic = new ComboBox();
            pictureBox1 = new PictureBox();
            txtContactNo = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataViewList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // rbName
            // 
            rbName.AutoSize = true;
            rbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbName.Location = new Point(16, 45);
            rbName.Margin = new Padding(2, 3, 2, 3);
            rbName.Name = "rbName";
            rbName.Size = new Size(85, 32);
            rbName.TabIndex = 11;
            rbName.TabStop = true;
            rbName.Text = "&Name";
            rbName.UseVisualStyleBackColor = true;
            // 
            // rbID
            // 
            rbID.AutoSize = true;
            rbID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbID.Location = new Point(155, 44);
            rbID.Margin = new Padding(2, 3, 2, 3);
            rbID.Name = "rbID";
            rbID.Size = new Size(129, 32);
            rbID.TabIndex = 12;
            rbID.TabStop = true;
            rbID.Text = "ID &Number";
            rbID.UseVisualStyleBackColor = true;
            // 
            // rbEmail
            // 
            rbEmail.AutoSize = true;
            rbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbEmail.Location = new Point(347, 43);
            rbEmail.Margin = new Padding(2, 3, 2, 3);
            rbEmail.Name = "rbEmail";
            rbEmail.Size = new Size(155, 32);
            rbEmail.TabIndex = 13;
            rbEmail.TabStop = true;
            rbEmail.Text = "E&mail Address";
            rbEmail.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(531, 35);
            txtSearch.Margin = new Padding(2, 3, 2, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(413, 42);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 111);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 5;
            label2.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(480, 292);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 7;
            label4.Text = "Contact No.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(480, 355);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 8;
            label5.Text = "Registered:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(155, 111);
            txtFirstName.Margin = new Padding(2, 3, 2, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(259, 34);
            txtFirstName.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 227);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 28);
            label6.TabIndex = 14;
            label6.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(155, 223);
            txtLastName.Margin = new Padding(2, 3, 2, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(259, 34);
            txtLastName.TabIndex = 2;
            // 
            // btnGuestInsert
            // 
            btnGuestInsert.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuestInsert.Location = new Point(13, 411);
            btnGuestInsert.Margin = new Padding(2, 3, 2, 3);
            btnGuestInsert.Name = "btnGuestInsert";
            btnGuestInsert.Size = new Size(128, 47);
            btnGuestInsert.TabIndex = 17;
            btnGuestInsert.Text = "Ins&ert";
            btnGuestInsert.UseVisualStyleBackColor = true;
            btnGuestInsert.Click += btnGuestInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(146, 411);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 47);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Upd&ate";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGuestDelete
            // 
            btnGuestDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuestDelete.Location = new Point(282, 411);
            btnGuestDelete.Margin = new Padding(2, 3, 2, 3);
            btnGuestDelete.Name = "btnGuestDelete";
            btnGuestDelete.Size = new Size(133, 47);
            btnGuestDelete.TabIndex = 20;
            btnGuestDelete.Text = "&Delete";
            btnGuestDelete.UseVisualStyleBackColor = true;
            btnGuestDelete.Click += btnGuestDelete_Click;
            // 
            // dataViewList
            // 
            dataViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewList.Location = new Point(9, 480);
            dataViewList.Margin = new Padding(2, 3, 2, 3);
            dataViewList.Name = "dataViewList";
            dataViewList.RowHeadersWidth = 62;
            dataViewList.Size = new Size(1325, 499);
            dataViewList.TabIndex = 18;
            dataViewList.CellContentClick += dataViewList_CellContentClick;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(627, 232);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 34);
            txtEmail.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(480, 236);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 28);
            label10.TabIndex = 32;
            label10.Text = "Email:";
            // 
            // dateRegistered
            // 
            dateRegistered.Checked = false;
            dateRegistered.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dateRegistered.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateRegistered.Format = DateTimePickerFormat.Custom;
            dateRegistered.Location = new Point(627, 349);
            dateRegistered.Margin = new Padding(2, 3, 2, 3);
            dateRegistered.Name = "dateRegistered";
            dateRegistered.RightToLeft = RightToLeft.No;
            dateRegistered.Size = new Size(259, 34);
            dateRegistered.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(480, 411);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(407, 47);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(155, 167);
            txtMiddleName.Margin = new Padding(2, 3, 2, 3);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(259, 34);
            txtMiddleName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 167);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 35;
            label3.Text = "Middle Name:";
            // 
            // dateBirthDate
            // 
            dateBirthDate.Checked = false;
            dateBirthDate.CustomFormat = "MM/dd/yyyy";
            dateBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBirthDate.Format = DateTimePickerFormat.Custom;
            dateBirthDate.Location = new Point(155, 283);
            dateBirthDate.Margin = new Padding(2, 3, 2, 3);
            dateBirthDate.Name = "dateBirthDate";
            dateBirthDate.RightToLeft = RightToLeft.No;
            dateBirthDate.Size = new Size(259, 34);
            dateBirthDate.TabIndex = 3;
            dateBirthDate.ValueChanged += dateBirthDate_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 289);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 28);
            label7.TabIndex = 37;
            label7.Text = "Birth Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 351);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 28);
            label8.TabIndex = 39;
            label8.Text = "Age:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(155, 351);
            lblAge.Margin = new Padding(2, 0, 2, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(88, 28);
            lblAge.TabIndex = 40;
            lblAge.Text = "Age No.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(480, 115);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(86, 28);
            label11.TabIndex = 41;
            label11.Text = "Gender:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(480, 175);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(101, 28);
            label12.TabIndex = 43;
            label12.Text = "Ethnicity:";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(627, 111);
            cbGender.Margin = new Padding(3, 4, 3, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(259, 36);
            cbGender.TabIndex = 4;
            // 
            // cbEthnic
            // 
            cbEthnic.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEthnic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEthnic.FormattingEnabled = true;
            cbEthnic.Items.AddRange(new object[] { "Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguan", "Argentine", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Botswanan", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabé", "Burundian", "Cabo Verdean", "Cambodian", "Cameroonian", "Canadian", "Central African", "Chadian", "Chilean", "Chinese", "Colombian", "Comorian", "Congolese", "Costa Rican", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djiboutian", "Dominican", "Ecuadorian", "Egyptian", "El Salvadoran", "Equatorial Guinean", "Eritrean", "Estonian", "Eswatini", "Ethiopian", "Fijian", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinea-Bissauan", "Guinean", "Guyanese", "Haitian", "Honduran", "Hungarian", "Icelander", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Jamaican", "Japanese", "Jordanian", "Kazakhstani", "Kenyan", "Kittian and Nevisian", "Kuwaiti", "Kyrgyzstani", "Laotian", "Latvian", "Lebanese", "Lesothan", "Liberian", "Libyan", "Liechtensteinian", "Lithuanian", "Luxembourgish", "Macedonian", "Madagascan", "Malawian", "Malaysian", "Maldivian", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monacan", "Mongolian", "Montenegrin", "Moroccan", "Mozambican Burmese", "Namibian", "Nauruan", "Nepali", "Netherlandish", "New Zealander", "Nicaraguan", "Nigerian", "Nigerien", "North Korean", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Philippine", "Polish", "Portuguese", "Qatari", "Romanian", "Russian", "Rwandan", "Saint Lucian", "Salvadoran", "Samoan", "San Marinese", "Sao Tomean", "Saudi", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Slovak", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "Spanish", "Sri Lankan", "Sudanese", "Surinamese", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajikistani", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian/Tobagonian", "Tunisian", "Turkish", "Turkmen", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Vanuatu", "Venezuelan", "Vietnamese", "Wallisian", "Walisian", "Yemenite", "Zambian", "Zimbabwean" });
            cbEthnic.Location = new Point(627, 171);
            cbEthnic.Margin = new Padding(3, 4, 3, 4);
            cbEthnic.Name = "cbEthnic";
            cbEthnic.Size = new Size(259, 36);
            cbEthnic.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(920, -49);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 545);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 12F);
            txtContactNo.Location = new Point(627, 289);
            txtContactNo.Margin = new Padding(3, 4, 3, 4);
            txtContactNo.Mask = "0000-000-0000";
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(259, 34);
            txtContactNo.TabIndex = 7;
            // 
            // GuestProfiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1343, 993);
            Controls.Add(txtContactNo);
            Controls.Add(cbEthnic);
            Controls.Add(cbGender);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lblAge);
            Controls.Add(label8);
            Controls.Add(dateBirthDate);
            Controls.Add(label7);
            Controls.Add(txtMiddleName);
            Controls.Add(label3);
            Controls.Add(btnGuestDelete);
            Controls.Add(txtSearch);
            Controls.Add(dateRegistered);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(dataViewList);
            Controls.Add(btnClear);
            Controls.Add(label10);
            Controls.Add(btnUpdate);
            Controls.Add(btnGuestInsert);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(rbEmail);
            Controls.Add(rbID);
            Controls.Add(rbName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "GuestProfiles";
            Load += GuestProfiles_Load;
            ((System.ComponentModel.ISupportInitialize)dataViewList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbName;
        private RadioButton rbID;
        private RadioButton rbEmail;
        private TextBox txtSearch;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtFirstName;
        private Label label6;
        private TextBox txtLastName;
        private TextBox txtbxID;
        private Button btnGuestInsert;
        private Button btnUpdate;
        private Button btnGuestDelete;
        private DataGridView dataViewList;
        private TextBox txtEmail;
        private Label label10;
        private DateTimePicker dateRegistered;
        private Button btnClear;
        private TextBox txtMiddleName;
        private Label label3;
        private DateTimePicker dateBirthDate;
        private Label label7;
        private Label label8;
        private Label lblAge;
        private Label label11;
        private Label label12;
        private ComboBox cbGender;
        private ComboBox cbEthnic;
        private PictureBox pictureBox1;
        private MaskedTextBox txtContactNo;
    }
}