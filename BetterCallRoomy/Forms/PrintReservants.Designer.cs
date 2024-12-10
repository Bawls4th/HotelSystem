namespace BetterCallRoomy.Forms
{
    partial class PrintReservants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintReservants));
            toolTip1 = new ToolTip(components);
            pbPrint = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panelDocu = new Panel();
            label24 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblCheckIn = new Label();
            label10 = new Label();
            label2 = new Label();
            lblDateIssued = new Label();
            label12 = new Label();
            lblCheckOut = new Label();
            label11 = new Label();
            lblTotalAmount = new Label();
            label23 = new Label();
            label18 = new Label();
            lbldate = new Label();
            label22 = new Label();
            lblservprice = new Label();
            lblroomprice = new Label();
            label21 = new Label();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label6 = new Label();
            label20 = new Label();
            lblServicor = new Label();
            lblRoomNo = new Label();
            lblName = new Label();
            lblID = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPrint).BeginInit();
            panelDocu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbPrint
            // 
            pbPrint.BackColor = Color.Transparent;
            pbPrint.BackgroundImage = Properties.Resources.printer;
            pbPrint.BackgroundImageLayout = ImageLayout.Zoom;
            pbPrint.Location = new Point(12, 892);
            pbPrint.Margin = new Padding(3, 4, 3, 4);
            pbPrint.Name = "pbPrint";
            pbPrint.Size = new Size(48, 52);
            pbPrint.TabIndex = 45;
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
            // panelDocu
            // 
            panelDocu.Controls.Add(label24);
            panelDocu.Controls.Add(pictureBox2);
            panelDocu.Controls.Add(pictureBox1);
            panelDocu.Controls.Add(lblCheckIn);
            panelDocu.Controls.Add(label10);
            panelDocu.Controls.Add(label2);
            panelDocu.Controls.Add(lblDateIssued);
            panelDocu.Controls.Add(label12);
            panelDocu.Controls.Add(lblCheckOut);
            panelDocu.Controls.Add(label11);
            panelDocu.Controls.Add(lblTotalAmount);
            panelDocu.Controls.Add(label23);
            panelDocu.Controls.Add(label18);
            panelDocu.Controls.Add(lbldate);
            panelDocu.Controls.Add(label22);
            panelDocu.Controls.Add(lblservprice);
            panelDocu.Controls.Add(lblroomprice);
            panelDocu.Controls.Add(label21);
            panelDocu.Controls.Add(label19);
            panelDocu.Controls.Add(label17);
            panelDocu.Controls.Add(label16);
            panelDocu.Controls.Add(label15);
            panelDocu.Controls.Add(label14);
            panelDocu.Controls.Add(label13);
            panelDocu.Controls.Add(label6);
            panelDocu.Controls.Add(label20);
            panelDocu.Controls.Add(lblServicor);
            panelDocu.Controls.Add(lblRoomNo);
            panelDocu.Controls.Add(lblName);
            panelDocu.Controls.Add(lblID);
            panelDocu.Controls.Add(label9);
            panelDocu.Controls.Add(label8);
            panelDocu.Controls.Add(label7);
            panelDocu.Controls.Add(label5);
            panelDocu.Controls.Add(label4);
            panelDocu.Controls.Add(label3);
            panelDocu.Controls.Add(label1);
            panelDocu.Location = new Point(0, 3);
            panelDocu.Margin = new Padding(3, 4, 3, 4);
            panelDocu.Name = "panelDocu";
            panelDocu.Size = new Size(916, 880);
            panelDocu.TabIndex = 46;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(363, 844);
            label24.Name = "label24";
            label24.Size = new Size(183, 25);
            label24.TabIndex = 91;
            label24.Text = "* 8 0 0 8 5 4 7 1 2 3 *";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(531, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 223);
            pictureBox2.TabIndex = 90;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(299, 755);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 85);
            pictureBox1.TabIndex = 89;
            pictureBox1.TabStop = false;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI", 13.8F);
            lblCheckIn.Location = new Point(569, 247);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(74, 31);
            lblCheckIn.TabIndex = 64;
            lblCheckIn.Text = "Date1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.Location = new Point(452, 247);
            label10.Name = "label10";
            label10.Size = new Size(111, 31);
            label10.TabIndex = 57;
            label10.Text = "Check In:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 217);
            label2.Name = "label2";
            label2.Size = new Size(801, 20);
            label2.TabIndex = 50;
            label2.Text = "____________________________________________________________________________________________________________________________________";
            // 
            // lblDateIssued
            // 
            lblDateIssued.AutoSize = true;
            lblDateIssued.Font = new Font("Segoe UI", 13.8F);
            lblDateIssued.Location = new Point(589, 332);
            lblDateIssued.Name = "lblDateIssued";
            lblDateIssued.Size = new Size(74, 31);
            lblDateIssued.TabIndex = 66;
            lblDateIssued.Text = "Date3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label12.Location = new Point(451, 331);
            label12.Name = "label12";
            label12.Size = new Size(143, 31);
            label12.TabIndex = 59;
            label12.Text = "Date Issued:";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.BackColor = Color.Transparent;
            lblCheckOut.Font = new Font("Segoe UI", 13.8F);
            lblCheckOut.Location = new Point(587, 289);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(74, 31);
            lblCheckOut.TabIndex = 65;
            lblCheckOut.Text = "Date2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label11.Location = new Point(452, 288);
            label11.Name = "label11";
            label11.Size = new Size(130, 31);
            label11.TabIndex = 58;
            label11.Text = "Check Out:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(656, 686);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(89, 37);
            lblTotalAmount.TabIndex = 88;
            lblTotalAmount.Text = "Price2";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(51, 701);
            label23.Name = "label23";
            label23.Size = new Size(176, 37);
            label23.TabIndex = 87;
            label23.Text = "Total Amount";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(46, 666);
            label18.Name = "label18";
            label18.Size = new Size(795, 20);
            label18.TabIndex = 86;
            label18.Text = "___________________________________________________________________________________________________________________________________";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 14.25F);
            lbldate.Location = new Point(130, 173);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(61, 32);
            lbldate.TabIndex = 85;
            lbldate.Text = "date";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14.25F);
            label22.Location = new Point(68, 173);
            label22.Name = "label22";
            label22.Size = new Size(76, 32);
            label22.TabIndex = 84;
            label22.Text = "Date: ";
            // 
            // lblservprice
            // 
            lblservprice.AutoSize = true;
            lblservprice.Font = new Font("Segoe UI", 15.75F);
            lblservprice.Location = new Point(670, 626);
            lblservprice.Name = "lblservprice";
            lblservprice.Size = new Size(89, 37);
            lblservprice.TabIndex = 78;
            lblservprice.Text = "Price2";
            // 
            // lblroomprice
            // 
            lblroomprice.AutoSize = true;
            lblroomprice.Font = new Font("Segoe UI", 15.75F);
            lblroomprice.Location = new Point(656, 582);
            lblroomprice.Name = "lblroomprice";
            lblroomprice.Size = new Size(89, 37);
            lblroomprice.TabIndex = 77;
            lblroomprice.Text = "Price1";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 15.75F);
            label21.Location = new Point(51, 628);
            label21.Name = "label21";
            label21.Size = new Size(111, 37);
            label21.TabIndex = 76;
            label21.Text = "Servicor";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15.75F);
            label19.Location = new Point(51, 582);
            label19.Name = "label19";
            label19.Size = new Size(87, 37);
            label19.TabIndex = 75;
            label19.Text = "Room";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(46, 552);
            label17.Name = "label17";
            label17.Size = new Size(795, 20);
            label17.TabIndex = 73;
            label17.Text = "___________________________________________________________________________________________________________________________________";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(646, 512);
            label16.Name = "label16";
            label16.Size = new Size(112, 37);
            label16.TabIndex = 72;
            label16.Text = "Amount";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(51, 509);
            label15.Name = "label15";
            label15.Size = new Size(138, 37);
            label15.TabIndex = 71;
            label15.Text = "Particulars";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(46, 474);
            label14.Name = "label14";
            label14.Size = new Size(795, 20);
            label14.TabIndex = 70;
            label14.Text = "___________________________________________________________________________________________________________________________________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(357, 430);
            label13.Name = "label13";
            label13.Size = new Size(193, 41);
            label13.TabIndex = 69;
            label13.Text = "Billing Notice";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(68, 247);
            label6.Name = "label6";
            label6.Size = new Size(176, 31);
            label6.TabIndex = 68;
            label6.Text = "Reservation ID:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(46, 400);
            label20.Name = "label20";
            label20.Size = new Size(795, 20);
            label20.TabIndex = 67;
            label20.Text = "___________________________________________________________________________________________________________________________________";
            // 
            // lblServicor
            // 
            lblServicor.AutoSize = true;
            lblServicor.Font = new Font("Segoe UI", 13.8F);
            lblServicor.Location = new Point(180, 371);
            lblServicor.Name = "lblServicor";
            lblServicor.Size = new Size(95, 31);
            lblServicor.TabIndex = 63;
            lblServicor.Text = "Servicor";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Segoe UI", 13.8F);
            lblRoomNo.Location = new Point(180, 330);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(103, 31);
            lblRoomNo.TabIndex = 62;
            lblRoomNo.Text = "RoomNo";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F);
            lblName.Location = new Point(152, 289);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 31);
            lblName.TabIndex = 61;
            lblName.Text = "Name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 13.8F);
            lblID.Location = new Point(247, 247);
            lblID.Name = "lblID";
            lblID.Size = new Size(36, 31);
            lblID.TabIndex = 60;
            lblID.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.Location = new Point(68, 369);
            label9.Name = "label9";
            label9.Size = new Size(109, 31);
            label9.TabIndex = 56;
            label9.Text = "Servicor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.Location = new Point(68, 329);
            label8.Name = "label8";
            label8.Size = new Size(115, 31);
            label8.TabIndex = 55;
            label8.Text = "RoomNo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.Location = new Point(68, 288);
            label7.Name = "label7";
            label7.Size = new Size(83, 31);
            label7.TabIndex = 54;
            label7.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(68, 143);
            label5.Name = "label5";
            label5.Size = new Size(189, 32);
            label5.TabIndex = 53;
            label5.Text = "Ref No. : 067824";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(68, 111);
            label4.Name = "label4";
            label4.Size = new Size(280, 32);
            label4.TabIndex = 52;
            label4.Text = "Balayan, Batangas - 4213";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(68, 79);
            label3.Name = "label3";
            label3.Size = new Size(186, 32);
            label3.TabIndex = 51;
            label3.Text = "Reg No.  x1337x";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 8);
            label1.Name = "label1";
            label1.Size = new Size(269, 46);
            label1.TabIndex = 49;
            label1.Text = "BetterCallRoomy";
            // 
            // PrintReservants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(915, 954);
            Controls.Add(panelDocu);
            Controls.Add(pbPrint);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrintReservants";
            Text = "PrintReservants";
            Load += PrintReservants_Load;
            ((System.ComponentModel.ISupportInitialize)pbPrint).EndInit();
            panelDocu.ResumeLayout(false);
            panelDocu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private PictureBox pbPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panelDocu;
        private Label lbldate;
        private Label label22;
        private Label label21;
        private Label label19;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label6;
        private Label label20;
        private Label lblDateIssued;
        private Label lblCheckOut;
        private Label lblCheckIn;
        private Label lblServicor;
        private Label lblRoomNo;
        private Label lblName;
        private Label lblID;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label23;
        private Label label18;
        private Label lblTotalAmount;
        private Label lblservprice;
        private Label lblroomprice;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label24;
    }
}