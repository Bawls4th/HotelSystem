namespace BetterCallRoomy.ReceptionistForm
{
    partial class Reservation
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
            rbID = new RadioButton();
            rbName = new RadioButton();
            rbRoom = new RadioButton();
            rbServicor = new RadioButton();
            txtSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtGuestID = new TextBox();
            txtServiceID = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            dtpIssued = new DateTimePicker();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnPrint = new Button();
            pictureBox1 = new PictureBox();
            btnPayment = new Button();
            dataReservationList = new DataGridView();
            btnServicor = new Button();
            btnFrmGuest = new Button();
            buttonFrmRoom = new Button();
            txtRoomID = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            label8 = new Label();
            lblName = new Label();
            lblRoom = new Label();
            lblServicor = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            lblID = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataReservationList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 17);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // rbID
            // 
            rbID.AutoSize = true;
            rbID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbID.Location = new Point(18, 59);
            rbID.Margin = new Padding(3, 4, 3, 4);
            rbID.Name = "rbID";
            rbID.Size = new Size(52, 32);
            rbID.TabIndex = 1;
            rbID.TabStop = true;
            rbID.Text = "ID";
            rbID.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            rbName.AutoSize = true;
            rbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbName.Location = new Point(98, 59);
            rbName.Margin = new Padding(3, 4, 3, 4);
            rbName.Name = "rbName";
            rbName.Size = new Size(85, 32);
            rbName.TabIndex = 2;
            rbName.TabStop = true;
            rbName.Text = "Name";
            rbName.UseVisualStyleBackColor = true;
            // 
            // rbRoom
            // 
            rbRoom.AutoSize = true;
            rbRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbRoom.Location = new Point(211, 59);
            rbRoom.Margin = new Padding(3, 4, 3, 4);
            rbRoom.Name = "rbRoom";
            rbRoom.Size = new Size(85, 32);
            rbRoom.TabIndex = 3;
            rbRoom.TabStop = true;
            rbRoom.Text = "Room";
            rbRoom.UseVisualStyleBackColor = true;
            // 
            // rbServicor
            // 
            rbServicor.AutoSize = true;
            rbServicor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbServicor.Location = new Point(326, 59);
            rbServicor.Margin = new Padding(3, 4, 3, 4);
            rbServicor.Name = "rbServicor";
            rbServicor.Size = new Size(104, 32);
            rbServicor.TabIndex = 4;
            rbServicor.TabStop = true;
            rbServicor.Text = "Servicor";
            rbServicor.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(462, 53);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(364, 39);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 176);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 6;
            label2.Text = "RoomID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 120);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 7;
            label3.Text = "Guest ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 231);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 8;
            label4.Text = "Service ID:";
            // 
            // txtGuestID
            // 
            txtGuestID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuestID.Location = new Point(134, 116);
            txtGuestID.Margin = new Padding(3, 4, 3, 4);
            txtGuestID.Name = "txtGuestID";
            txtGuestID.Size = new Size(157, 39);
            txtGuestID.TabIndex = 10;
            // 
            // txtServiceID
            // 
            txtServiceID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceID.Location = new Point(134, 227);
            txtServiceID.Margin = new Padding(3, 4, 3, 4);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new Size(157, 39);
            txtServiceID.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(366, 235);
            label5.Name = "label5";
            label5.Size = new Size(154, 32);
            label5.TabIndex = 14;
            label5.Text = "Date Issued:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(366, 179);
            label6.Name = "label6";
            label6.Size = new Size(137, 32);
            label6.TabIndex = 13;
            label6.Text = "Check Out:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(366, 121);
            label7.Name = "label7";
            label7.Size = new Size(118, 32);
            label7.TabIndex = 12;
            label7.Text = "Check In:";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckIn.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dtpCheckIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.Location = new Point(526, 116);
            dtpCheckIn.Margin = new Padding(3, 4, 3, 4);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(300, 39);
            dtpCheckIn.TabIndex = 15;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckOut.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dtpCheckOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.Location = new Point(526, 176);
            dtpCheckOut.Margin = new Padding(3, 4, 3, 4);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(300, 39);
            dtpCheckOut.TabIndex = 16;
            // 
            // dtpIssued
            // 
            dtpIssued.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpIssued.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dtpIssued.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpIssued.Format = DateTimePickerFormat.Custom;
            dtpIssued.Location = new Point(526, 235);
            dtpIssued.Margin = new Padding(3, 4, 3, 4);
            dtpIssued.Name = "dtpIssued";
            dtpIssued.Size = new Size(300, 39);
            dtpIssued.TabIndex = 17;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(17, 348);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(181, 53);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(271, 289);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 53);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(143, 289);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 53);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(17, 289);
            btnInsert.Margin = new Padding(2, 3, 2, 3);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 53);
            btnInsert.TabIndex = 21;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(202, 348);
            btnPrint.Margin = new Padding(2, 3, 2, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(189, 53);
            btnPrint.TabIndex = 25;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(879, -55);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(488, 601);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(513, 289);
            btnPayment.Margin = new Padding(2, 3, 2, 3);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(309, 53);
            btnPayment.TabIndex = 27;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // dataReservationList
            // 
            dataReservationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataReservationList.Location = new Point(10, 412);
            dataReservationList.Margin = new Padding(3, 4, 3, 4);
            dataReservationList.Name = "dataReservationList";
            dataReservationList.RowHeadersWidth = 51;
            dataReservationList.Size = new Size(1025, 457);
            dataReservationList.TabIndex = 28;
            dataReservationList.CellContentClick += dataReservationList_CellContentClick;
            // 
            // btnServicor
            // 
            btnServicor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServicor.Location = new Point(717, 348);
            btnServicor.Margin = new Padding(2, 3, 2, 3);
            btnServicor.Name = "btnServicor";
            btnServicor.Size = new Size(104, 53);
            btnServicor.TabIndex = 31;
            btnServicor.Text = "FrmServicor";
            btnServicor.UseVisualStyleBackColor = true;
            btnServicor.Click += btnServicor_Click;
            // 
            // btnFrmGuest
            // 
            btnFrmGuest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFrmGuest.Location = new Point(513, 348);
            btnFrmGuest.Margin = new Padding(2, 3, 2, 3);
            btnFrmGuest.Name = "btnFrmGuest";
            btnFrmGuest.Size = new Size(97, 53);
            btnFrmGuest.TabIndex = 29;
            btnFrmGuest.Text = "FrmGuest";
            btnFrmGuest.UseVisualStyleBackColor = true;
            btnFrmGuest.Click += btnFrmGuest_Click;
            // 
            // buttonFrmRoom
            // 
            buttonFrmRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFrmRoom.Location = new Point(615, 348);
            buttonFrmRoom.Margin = new Padding(2, 3, 2, 3);
            buttonFrmRoom.Name = "buttonFrmRoom";
            buttonFrmRoom.Size = new Size(97, 53);
            buttonFrmRoom.TabIndex = 32;
            buttonFrmRoom.Text = "FrmRoom";
            buttonFrmRoom.UseVisualStyleBackColor = true;
            buttonFrmRoom.Click += buttonFrmRoom_Click;
            // 
            // txtRoomID
            // 
            txtRoomID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomID.Location = new Point(134, 172);
            txtRoomID.Margin = new Padding(3, 4, 3, 4);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(157, 39);
            txtRoomID.TabIndex = 33;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1045, 460);
            label8.Name = "label8";
            label8.Size = new Size(68, 32);
            label8.TabIndex = 34;
            label8.Text = "Info:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(13, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 28);
            lblName.TabIndex = 35;
            lblName.Text = "Name";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(13, 164);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(64, 28);
            lblRoom.TabIndex = 36;
            lblRoom.Text = "Room";
            // 
            // lblServicor
            // 
            lblServicor.AutoSize = true;
            lblServicor.Font = new Font("Segoe UI", 12F);
            lblServicor.Location = new Point(13, 231);
            lblServicor.Name = "lblServicor";
            lblServicor.Size = new Size(83, 28);
            lblServicor.TabIndex = 37;
            lblServicor.Text = "Servicor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(3, 199);
            label11.Name = "label11";
            label11.Size = new Size(96, 28);
            label11.TabIndex = 40;
            label11.Text = "Servicor:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 135);
            label10.Name = "label10";
            label10.Size = new Size(72, 28);
            label10.TabIndex = 39;
            label10.Text = "Room:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(3, 72);
            label9.Name = "label9";
            label9.Size = new Size(73, 28);
            label9.TabIndex = 38;
            label9.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblServicor);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblRoom);
            panel1.Location = new Point(1051, 497);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 283);
            panel1.TabIndex = 41;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(13, 43);
            lblID.Name = "lblID";
            lblID.Size = new Size(35, 28);
            lblID.TabIndex = 42;
            lblID.Text = "ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(3, 15);
            label12.Name = "label12";
            label12.Size = new Size(38, 28);
            label12.TabIndex = 41;
            label12.Text = "ID:";
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1374, 885);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(txtRoomID);
            Controls.Add(buttonFrmRoom);
            Controls.Add(btnServicor);
            Controls.Add(btnFrmGuest);
            Controls.Add(dataReservationList);
            Controls.Add(btnPayment);
            Controls.Add(btnPrint);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dtpIssued);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtServiceID);
            Controls.Add(txtGuestID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(rbServicor);
            Controls.Add(rbRoom);
            Controls.Add(rbName);
            Controls.Add(rbID);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reservation";
            Text = "Reservation";
            Load += Reservation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataReservationList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbID;
        private RadioButton rbName;
        private RadioButton rbRoom;
        private RadioButton rbServicor;
        private TextBox txtSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtGuestID;
        private TextBox txtServiceID;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpIssued;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnPrint;
        private PictureBox pictureBox1;
        private Button btnPayment;
        private DataGridView dataReservationList;
        private Button btnServicor;
        private Button btnFrmGuest;
        private Button buttonFrmRoom;
        private TextBox txtRoomID;
        private OpenFileDialog openFileDialog1;
        private Label label8;
        private Label lblName;
        private Label lblRoom;
        private Label lblServicor;
        private Label label11;
        private Label label10;
        private Label label9;
        private Panel panel1;
        private Label lblID;
        private Label label12;
    }
}