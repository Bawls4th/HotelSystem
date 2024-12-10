namespace BetterCallRoomy.ReceptionistForm
{
    partial class RoomMaintenance
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
            rbRoomNo = new RadioButton();
            rbRoomType = new RadioButton();
            rbStatus = new RadioButton();
            txtSearch = new TextBox();
            cbRoomType = new ComboBox();
            cbFloor = new ComboBox();
            cbStatus = new ComboBox();
            cbIsAvailable = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dataRoomList = new DataGridView();
            cbRoomNo = new ComboBox();
            label7 = new Label();
            cbCapacity = new ComboBox();
            pbRoom = new PictureBox();
            btnUpload = new Button();
            label8 = new Label();
            label9 = new Label();
            txtRoomName = new TextBox();
            rbRoomID = new RadioButton();
            mtxtRoomPrice = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataRoomList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRoom).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // rbRoomNo
            // 
            rbRoomNo.AutoSize = true;
            rbRoomNo.Font = new Font("Segoe UI", 12F);
            rbRoomNo.Location = new Point(106, 40);
            rbRoomNo.Margin = new Padding(2);
            rbRoomNo.Name = "rbRoomNo";
            rbRoomNo.Size = new Size(98, 25);
            rbRoomNo.TabIndex = 2;
            rbRoomNo.TabStop = true;
            rbRoomNo.Text = "Room No.";
            rbRoomNo.UseVisualStyleBackColor = true;
            // 
            // rbRoomType
            // 
            rbRoomType.AutoSize = true;
            rbRoomType.Font = new Font("Segoe UI", 12F);
            rbRoomType.Location = new Point(214, 40);
            rbRoomType.Margin = new Padding(2);
            rbRoomType.Name = "rbRoomType";
            rbRoomType.Size = new Size(102, 25);
            rbRoomType.TabIndex = 3;
            rbRoomType.TabStop = true;
            rbRoomType.Text = "RoomType";
            rbRoomType.UseVisualStyleBackColor = true;
            // 
            // rbStatus
            // 
            rbStatus.AutoSize = true;
            rbStatus.Font = new Font("Segoe UI", 12F);
            rbStatus.Location = new Point(326, 41);
            rbStatus.Margin = new Padding(2);
            rbStatus.Name = "rbStatus";
            rbStatus.Size = new Size(70, 25);
            rbStatus.TabIndex = 4;
            rbStatus.TabStop = true;
            rbStatus.Text = "Status";
            rbStatus.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(409, 36);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 33);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cbRoomType
            // 
            cbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomType.Font = new Font("Segoe UI", 12F);
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Items.AddRange(new object[] { "Single Room", "Double Room", "Family Room", "Deluxe Room" });
            cbRoomType.Location = new Point(118, 129);
            cbRoomType.Margin = new Padding(2);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(133, 29);
            cbRoomType.TabIndex = 7;
            // 
            // cbFloor
            // 
            cbFloor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFloor.Font = new Font("Segoe UI", 12F);
            cbFloor.FormattingEnabled = true;
            cbFloor.Items.AddRange(new object[] { "1st Floor", "2nd Floor", "3rd Floor", "4th Floor", "5th Floor" });
            cbFloor.Location = new Point(118, 172);
            cbFloor.Margin = new Padding(2);
            cbFloor.Name = "cbFloor";
            cbFloor.Size = new Size(133, 29);
            cbFloor.TabIndex = 8;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 12F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Available", "Occupied", "Reserved", "Out of Order" });
            cbStatus.Location = new Point(467, 166);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(133, 29);
            cbStatus.TabIndex = 9;
            // 
            // cbIsAvailable
            // 
            cbIsAvailable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsAvailable.Font = new Font("Segoe UI", 12F);
            cbIsAvailable.FormattingEnabled = true;
            cbIsAvailable.Items.AddRange(new object[] { "Yes", "No" });
            cbIsAvailable.Location = new Point(467, 212);
            cbIsAvailable.Margin = new Padding(2);
            cbIsAvailable.Name = "cbIsAvailable";
            cbIsAvailable.Size = new Size(133, 29);
            cbIsAvailable.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(4, 89);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 11;
            label2.Text = "Room No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(3, 129);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 12;
            label3.Text = "Room Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(4, 173);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 13;
            label4.Text = "Floor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(351, 172);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 14;
            label5.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(351, 216);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 15;
            label6.Text = "Is Available:";
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(7, 267);
            btnInsert.Margin = new Padding(2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(106, 40);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(117, 267);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 40);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(229, 267);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 40);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(409, 267);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(191, 40);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dataRoomList
            // 
            dataRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRoomList.Location = new Point(10, 316);
            dataRoomList.Margin = new Padding(2);
            dataRoomList.Name = "dataRoomList";
            dataRoomList.RowHeadersWidth = 62;
            dataRoomList.Size = new Size(1060, 371);
            dataRoomList.TabIndex = 21;
            dataRoomList.CellContentClick += dataRoomList_CellContentClick;
            // 
            // cbRoomNo
            // 
            cbRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomNo.Font = new Font("Segoe UI", 12F);
            cbRoomNo.FormattingEnabled = true;
            cbRoomNo.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510" });
            cbRoomNo.Location = new Point(118, 86);
            cbRoomNo.Margin = new Padding(2);
            cbRoomNo.Name = "cbRoomNo";
            cbRoomNo.Size = new Size(133, 29);
            cbRoomNo.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(352, 86);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 24;
            label7.Text = "Capacity:";
            // 
            // cbCapacity
            // 
            cbCapacity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCapacity.Font = new Font("Segoe UI", 12F);
            cbCapacity.FormattingEnabled = true;
            cbCapacity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cbCapacity.Location = new Point(467, 86);
            cbCapacity.Margin = new Padding(2);
            cbCapacity.Name = "cbCapacity";
            cbCapacity.Size = new Size(133, 29);
            cbCapacity.TabIndex = 23;
            // 
            // pbRoom
            // 
            pbRoom.BackgroundImage = Properties.Resources.roomexam1;
            pbRoom.BackgroundImageLayout = ImageLayout.Zoom;
            pbRoom.Location = new Point(746, 77);
            pbRoom.Name = "pbRoom";
            pbRoom.Size = new Size(264, 116);
            pbRoom.SizeMode = PictureBoxSizeMode.Zoom;
            pbRoom.TabIndex = 25;
            pbRoom.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(835, 198);
            btnUpload.Margin = new Padding(2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(97, 31);
            btnUpload.TabIndex = 26;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(351, 126);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 27;
            label8.Text = "Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(4, 216);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 30;
            label9.Text = "Name:";
            // 
            // txtRoomName
            // 
            txtRoomName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomName.Location = new Point(118, 216);
            txtRoomName.Margin = new Padding(2);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(133, 29);
            txtRoomName.TabIndex = 31;
            // 
            // rbRoomID
            // 
            rbRoomID.AutoSize = true;
            rbRoomID.Font = new Font("Segoe UI", 12F);
            rbRoomID.Location = new Point(7, 40);
            rbRoomID.Margin = new Padding(2);
            rbRoomID.Name = "rbRoomID";
            rbRoomID.Size = new Size(85, 25);
            rbRoomID.TabIndex = 33;
            rbRoomID.TabStop = true;
            rbRoomID.Text = "RoomID";
            rbRoomID.UseVisualStyleBackColor = true;
            // 
            // mtxtRoomPrice
            // 
            mtxtRoomPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtRoomPrice.Location = new Point(467, 126);
            mtxtRoomPrice.Mask = "₱0,000.00";
            mtxtRoomPrice.Name = "mtxtRoomPrice";
            mtxtRoomPrice.Size = new Size(133, 29);
            mtxtRoomPrice.TabIndex = 34;
            // 
            // RoomMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1080, 699);
            Controls.Add(mtxtRoomPrice);
            Controls.Add(rbRoomID);
            Controls.Add(txtRoomName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnUpload);
            Controls.Add(pbRoom);
            Controls.Add(label7);
            Controls.Add(cbCapacity);
            Controls.Add(cbRoomNo);
            Controls.Add(dataRoomList);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbIsAvailable);
            Controls.Add(cbStatus);
            Controls.Add(cbFloor);
            Controls.Add(cbRoomType);
            Controls.Add(txtSearch);
            Controls.Add(rbStatus);
            Controls.Add(rbRoomType);
            Controls.Add(rbRoomNo);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "RoomMaintenance";
            Text = "Status";
            Load += RoomMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dataRoomList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbRoomNo;
        private RadioButton rbRoomType;
        private RadioButton rbStatus;
        private TextBox txtSearch;
        private ComboBox cbRoomType;
        private ComboBox cbFloor;
        private ComboBox cbStatus;
        private ComboBox cbIsAvailable;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dataRoomList;
        private ComboBox cbRoomNo;
        private Label label7;
        private ComboBox cbCapacity;
        private PictureBox pbRoom;
        private Button btnUpload;
        private Label label8;
        private Label label9;
        private TextBox txtRoomName;
        private TextBox maskedTextBox1;
        private RadioButton rbRoomID;
        private MaskedTextBox mtxtRoomPrice;
    }
}