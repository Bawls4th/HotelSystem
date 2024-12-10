namespace BetterCallRoomy.Forms
{
    partial class Payment
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            btnTransact = new Button();
            pbPrint = new PictureBox();
            toolTip1 = new ToolTip(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pictureBox1 = new PictureBox();
            label421 = new Label();
            lablel1 = new Label();
            label324 = new Label();
            label32 = new Label();
            lblGuestName = new Label();
            label412 = new Label();
            lblReservationID = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblName = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            lblRoomNo = new Label();
            lblPrice = new Label();
            lblChange = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            lblBalance = new Label();
            label15 = new Label();
            lblID = new Label();
            label17 = new Label();
            label19 = new Label();
            label18 = new Label();
            label9 = new Label();
            label22 = new Label();
            lbldate = new Label();
            label20 = new Label();
            lblDateIssued = new Label();
            panelDocu = new Panel();
            label21 = new Label();
            label16 = new Label();
            lblDateTime = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            hidepan = new Panel();
            cbPaymentMethod = new ComboBox();
            label6 = new Label();
            lblServicor = new Label();
            label5 = new Label();
            txtAmountPaid = new TextBox();
            txtRoomCharges = new TextBox();
            dtpTransaction = new DataGridView();
            pbTxt = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPrint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDocu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtpTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTxt).BeginInit();
            SuspendLayout();
            // 
            // btnTransact
            // 
            btnTransact.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransact.Location = new Point(720, 803);
            btnTransact.Margin = new Padding(3, 4, 3, 4);
            btnTransact.Name = "btnTransact";
            btnTransact.Size = new Size(165, 52);
            btnTransact.TabIndex = 30;
            btnTransact.Text = "Transact";
            btnTransact.UseVisualStyleBackColor = true;
            btnTransact.Click += btnTransact_Click;
            // 
            // pbPrint
            // 
            pbPrint.BackColor = Color.Transparent;
            pbPrint.BackgroundImage = Properties.Resources.printer;
            pbPrint.BackgroundImageLayout = ImageLayout.Zoom;
            pbPrint.Location = new Point(720, 863);
            pbPrint.Margin = new Padding(3, 4, 3, 4);
            pbPrint.Name = "pbPrint";
            pbPrint.Size = new Size(55, 57);
            pbPrint.TabIndex = 46;
            pbPrint.TabStop = false;
            pbPrint.Click += pbPrint_Click;
            pbPrint.MouseHover += pbPrint_MouseHover;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(615, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 202);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label421
            // 
            label421.AutoSize = true;
            label421.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label421.Location = new Point(460, 442);
            label421.Name = "label421";
            label421.Size = new Size(152, 28);
            label421.TabIndex = 14;
            label421.Text = "Total Amount : ";
            // 
            // lablel1
            // 
            lablel1.AutoSize = true;
            lablel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lablel1.Location = new Point(57, 518);
            lablel1.Name = "lablel1";
            lablel1.Size = new Size(138, 28);
            lablel1.TabIndex = 13;
            lablel1.Text = "Tax Amount : ";
            // 
            // label324
            // 
            label324.AutoSize = true;
            label324.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label324.Location = new Point(460, 304);
            label324.Name = "label324";
            label324.Size = new Size(175, 28);
            label324.TabIndex = 11;
            label324.Text = "Check Out Time : ";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label32.Location = new Point(460, 266);
            label32.Name = "label32";
            label32.Size = new Size(159, 28);
            label32.TabIndex = 10;
            label32.Text = "Check In Time : ";
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGuestName.Location = new Point(53, 304);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(142, 28);
            lblGuestName.TabIndex = 9;
            lblGuestName.Text = "Guest Name : ";
            // 
            // label412
            // 
            label412.AutoSize = true;
            label412.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label412.Location = new Point(53, 339);
            label412.Name = "label412";
            label412.Size = new Size(158, 28);
            label412.TabIndex = 8;
            label412.Text = "Room Booked : ";
            // 
            // lblReservationID
            // 
            lblReservationID.AutoSize = true;
            lblReservationID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblReservationID.Location = new Point(53, 266);
            lblReservationID.Name = "lblReservationID";
            lblReservationID.Size = new Size(161, 28);
            lblReservationID.TabIndex = 7;
            lblReservationID.Text = "Reservation ID : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(58, 442);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 15;
            label1.Text = "Price: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(460, 518);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 16;
            label2.Text = "Balance: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(57, 479);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 17;
            label3.Text = "Room Charges : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(459, 558);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 18;
            label4.Text = "Change: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F);
            lblName.Location = new Point(197, 307);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 19;
            lblName.Text = "Name";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI", 12F);
            lblCheckIn.Location = new Point(620, 268);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(90, 28);
            lblCheckIn.TabIndex = 20;
            lblCheckIn.Text = "Check In ";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI", 12F);
            lblCheckOut.Location = new Point(634, 306);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(102, 28);
            lblCheckOut.TabIndex = 21;
            lblCheckOut.Text = "Check Out";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Segoe UI", 10.8F);
            lblRoomNo.Location = new Point(215, 342);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(89, 25);
            lblRoomNo.TabIndex = 22;
            lblRoomNo.Text = "Room No";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(131, 445);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 24;
            lblPrice.Text = "Price";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(547, 561);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(72, 25);
            lblChange.TabIndex = 26;
            lblChange.Text = "Change";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(201, 518);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(26, 25);
            lblTax.TabIndex = 27;
            lblTax.Text = "__";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(608, 442);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 25);
            lblTotal.TabIndex = 28;
            lblTotal.Text = "Total";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(557, 521);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(42, 25);
            lblBalance.TabIndex = 29;
            lblBalance.Text = "BAL";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(460, 479);
            label15.Name = "label15";
            label15.Size = new Size(141, 28);
            label15.TabIndex = 31;
            label15.Text = "Amount Paid: ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.8F);
            lblID.Location = new Point(217, 269);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 25);
            lblID.TabIndex = 33;
            lblID.Text = "ID";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(11, 6);
            label17.Name = "label17";
            label17.Size = new Size(279, 46);
            label17.TabIndex = 34;
            label17.Text = "BetterCallRoomy ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(53, 62);
            label19.Name = "label19";
            label19.Size = new Size(153, 28);
            label19.TabIndex = 86;
            label19.Text = "Reg No.  x1337x";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(53, 95);
            label18.Name = "label18";
            label18.Size = new Size(229, 28);
            label18.TabIndex = 87;
            label18.Text = "Balayan, Batangas - 4213";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(53, 127);
            label9.Name = "label9";
            label9.Size = new Size(155, 28);
            label9.TabIndex = 88;
            label9.Text = "Ref No. : 067824";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(53, 159);
            label22.Name = "label22";
            label22.Size = new Size(62, 28);
            label22.TabIndex = 89;
            label22.Text = "Date: ";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 12F);
            lbldate.Location = new Point(114, 159);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(51, 28);
            lbldate.TabIndex = 90;
            lbldate.Text = "date";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label20.Location = new Point(460, 339);
            label20.Name = "label20";
            label20.Size = new Size(130, 28);
            label20.TabIndex = 91;
            label20.Text = "Date Issued: ";
            // 
            // lblDateIssued
            // 
            lblDateIssued.AutoSize = true;
            lblDateIssued.Font = new Font("Segoe UI", 12F);
            lblDateIssued.Location = new Point(592, 340);
            lblDateIssued.Name = "lblDateIssued";
            lblDateIssued.Size = new Size(112, 28);
            lblDateIssued.TabIndex = 92;
            lblDateIssued.Text = "Date Issued";
            // 
            // panelDocu
            // 
            panelDocu.Controls.Add(label21);
            panelDocu.Controls.Add(label16);
            panelDocu.Controls.Add(lblDateTime);
            panelDocu.Controls.Add(label13);
            panelDocu.Controls.Add(label12);
            panelDocu.Controls.Add(label11);
            panelDocu.Controls.Add(label10);
            panelDocu.Controls.Add(label8);
            panelDocu.Controls.Add(label7);
            panelDocu.Controls.Add(hidepan);
            panelDocu.Controls.Add(cbPaymentMethod);
            panelDocu.Controls.Add(label6);
            panelDocu.Controls.Add(lblServicor);
            panelDocu.Controls.Add(label5);
            panelDocu.Controls.Add(txtAmountPaid);
            panelDocu.Controls.Add(txtRoomCharges);
            panelDocu.Controls.Add(lblDateIssued);
            panelDocu.Controls.Add(label20);
            panelDocu.Controls.Add(lbldate);
            panelDocu.Controls.Add(label22);
            panelDocu.Controls.Add(label9);
            panelDocu.Controls.Add(label18);
            panelDocu.Controls.Add(label19);
            panelDocu.Controls.Add(label17);
            panelDocu.Controls.Add(lblID);
            panelDocu.Controls.Add(label15);
            panelDocu.Controls.Add(lblBalance);
            panelDocu.Controls.Add(lblTotal);
            panelDocu.Controls.Add(lblTax);
            panelDocu.Controls.Add(lblChange);
            panelDocu.Controls.Add(lblPrice);
            panelDocu.Controls.Add(lblRoomNo);
            panelDocu.Controls.Add(lblCheckOut);
            panelDocu.Controls.Add(lblCheckIn);
            panelDocu.Controls.Add(lblName);
            panelDocu.Controls.Add(label4);
            panelDocu.Controls.Add(label3);
            panelDocu.Controls.Add(label2);
            panelDocu.Controls.Add(label1);
            panelDocu.Controls.Add(lblReservationID);
            panelDocu.Controls.Add(label412);
            panelDocu.Controls.Add(lblGuestName);
            panelDocu.Controls.Add(label32);
            panelDocu.Controls.Add(label324);
            panelDocu.Controls.Add(lablel1);
            panelDocu.Controls.Add(label421);
            panelDocu.Controls.Add(pictureBox1);
            panelDocu.Location = new Point(0, 1);
            panelDocu.Margin = new Padding(3, 4, 3, 4);
            panelDocu.Name = "panelDocu";
            panelDocu.Size = new Size(918, 748);
            panelDocu.TabIndex = 34;
            panelDocu.Paint += panelDocu_Paint;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F);
            label21.Location = new Point(311, 713);
            label21.Name = "label21";
            label21.Size = new Size(324, 28);
            label21.TabIndex = 108;
            label21.Text = "-          THIS IS YOUR INVOICE          -";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(673, 639);
            label16.Name = "label16";
            label16.Size = new Size(63, 28);
            label16.TabIndex = 107;
            label16.Text = "JAYCE";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 12F);
            lblDateTime.Location = new Point(372, 629);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(51, 28);
            lblDateTime.TabIndex = 106;
            lblDateTime.Text = "date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(149, 673);
            label13.Name = "label13";
            label13.Size = new Size(230, 28);
            label13.TabIndex = 105;
            label13.Text = "INVOICE#133783676675";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(149, 629);
            label12.Name = "label12";
            label12.Size = new Size(127, 28);
            label12.TabIndex = 104;
            label12.Text = "TXN#420360";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 595);
            label11.Name = "label11";
            label11.Size = new Size(897, 20);
            label11.TabIndex = 103;
            label11.Text = "____________________________________________________________________________________________________________________________________________________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(53, 192);
            label10.Name = "label10";
            label10.Size = new Size(158, 28);
            label10.TabIndex = 102;
            label10.Text = "PA # 23 McLovin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 407);
            label8.Name = "label8";
            label8.Size = new Size(897, 20);
            label8.TabIndex = 101;
            label8.Text = "____________________________________________________________________________________________________________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 235);
            label7.Name = "label7";
            label7.Size = new Size(897, 20);
            label7.TabIndex = 51;
            label7.Text = "____________________________________________________________________________________________________________________________________________________";
            // 
            // hidepan
            // 
            hidepan.Location = new Point(372, 558);
            hidepan.Margin = new Padding(3, 4, 3, 4);
            hidepan.Name = "hidepan";
            hidepan.Size = new Size(22, 33);
            hidepan.TabIndex = 100;
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.BackColor = Color.White;
            cbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentMethod.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Master Card", "Bank Transfer" });
            cbPaymentMethod.Location = new Point(249, 558);
            cbPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(145, 33);
            cbPaymentMethod.TabIndex = 98;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(57, 558);
            label6.Name = "label6";
            label6.Size = new Size(186, 28);
            label6.TabIndex = 97;
            label6.Text = "Payment Method : ";
            // 
            // lblServicor
            // 
            lblServicor.AutoSize = true;
            lblServicor.Font = new Font("Segoe UI", 10.8F);
            lblServicor.Location = new Point(149, 378);
            lblServicor.Name = "lblServicor";
            lblServicor.Size = new Size(75, 25);
            lblServicor.TabIndex = 96;
            lblServicor.Text = "Servicor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(53, 374);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 95;
            label5.Text = "Servicor: ";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountPaid.Location = new Point(607, 479);
            txtAmountPaid.Margin = new Padding(3, 4, 3, 4);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(114, 31);
            txtAmountPaid.TabIndex = 94;
            txtAmountPaid.TextChanged += txtAmountPaid_TextChanged;
            // 
            // txtRoomCharges
            // 
            txtRoomCharges.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomCharges.Location = new Point(221, 479);
            txtRoomCharges.Margin = new Padding(3, 4, 3, 4);
            txtRoomCharges.Name = "txtRoomCharges";
            txtRoomCharges.Size = new Size(114, 31);
            txtRoomCharges.TabIndex = 93;
            txtRoomCharges.TextChanged += txtRoomCharges_TextChanged;
            // 
            // dtpTransaction
            // 
            dtpTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtpTransaction.Location = new Point(9, 762);
            dtpTransaction.Margin = new Padding(3, 4, 3, 4);
            dtpTransaction.Name = "dtpTransaction";
            dtpTransaction.RowHeadersWidth = 51;
            dtpTransaction.Size = new Size(655, 212);
            dtpTransaction.TabIndex = 47;
            dtpTransaction.CellContentClick += dtpTransaction_CellContentClick;
            // 
            // pbTxt
            // 
            pbTxt.BackColor = Color.Transparent;
            pbTxt.BackgroundImage = Properties.Resources.txtlogo1;
            pbTxt.BackgroundImageLayout = ImageLayout.Zoom;
            pbTxt.Location = new Point(830, 863);
            pbTxt.Margin = new Padding(3, 4, 3, 4);
            pbTxt.Name = "pbTxt";
            pbTxt.Size = new Size(55, 57);
            pbTxt.TabIndex = 109;
            pbTxt.TabStop = false;
            pbTxt.Click += pbTxt_Click;
            pbTxt.MouseHover += pbTxt_MouseHover;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(918, 987);
            Controls.Add(pbTxt);
            Controls.Add(dtpTransaction);
            Controls.Add(pbPrint);
            Controls.Add(btnTransact);
            Controls.Add(panelDocu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)pbPrint).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDocu.ResumeLayout(false);
            panelDocu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtpTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTxt).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTransact;
        private PictureBox pbPrint;
        private ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox1;
        private Label label421;
        private Label lablel1;
        private Label label324;
        private Label label32;
        private Label lblGuestName;
        private Label label412;
        private Label lblReservationID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblName;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private Label lblRoomNo;
        private Label lblPrice;
        private Label lblChange;
        private Label lblTax;
        private Label lblTotal;
        private Label lblBalance;
        private Label label15;
        private Label lblID;
        private Label label17;
        private Label label19;
        private Label label18;
        private Label label9;
        private Label label22;
        private Label lbldate;
        private Label label20;
        private Label lblDateIssued;
        private Panel panelDocu;
        private TextBox txtAmountPaid;
        private TextBox txtRoomCharges;
        private Label lblServicor;
        private Label label5;
        private ComboBox cbPaymentMethod;
        private Label label6;
        private Panel hidepan;
        private DataGridView dtpTransaction;
        private Label label7;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label label21;
        private Label label16;
        private Label lblDateTime;
        private Label label13;
        private Label label8;
        private PictureBox pbTxt;
    }
}