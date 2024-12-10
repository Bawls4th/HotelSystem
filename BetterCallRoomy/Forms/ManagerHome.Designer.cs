namespace BetterCallRoomy.ReceptionistForm
{
    partial class ManagerHome
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
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            receptionistToolStripMenuItem = new ToolStripMenuItem();
            guestProfilesToolStripMenuItem = new ToolStripMenuItem();
            servicorsToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            bookReservationToolStripMenuItem = new ToolStripMenuItem();
            roomInfosToolStripMenuItem = new ToolStripMenuItem();
            lblTime = new Label();
            lblDate = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, infoToolStripMenuItem, roomsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 1, 0, 1);
            menuStrip1.Size = new Size(1924, 68);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator2, logOutToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            profileToolStripMenuItem.Font = new Font("Segoe UI", 27.75F);
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(134, 66);
            profileToolStripMenuItem.Text = "User";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(198, 6);
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(201, 36);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(198, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(201, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { receptionistToolStripMenuItem, guestProfilesToolStripMenuItem, servicorsToolStripMenuItem });
            infoToolStripMenuItem.Font = new Font("Segoe UI", 27.75F);
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(124, 66);
            infoToolStripMenuItem.Text = "Info";
            // 
            // receptionistToolStripMenuItem
            // 
            receptionistToolStripMenuItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receptionistToolStripMenuItem.Name = "receptionistToolStripMenuItem";
            receptionistToolStripMenuItem.Size = new Size(261, 36);
            receptionistToolStripMenuItem.Text = "Receptionist";
            receptionistToolStripMenuItem.Click += receptionistToolStripMenuItem_Click;
            // 
            // guestProfilesToolStripMenuItem
            // 
            guestProfilesToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            guestProfilesToolStripMenuItem.Name = "guestProfilesToolStripMenuItem";
            guestProfilesToolStripMenuItem.Size = new Size(261, 36);
            guestProfilesToolStripMenuItem.Text = "Guest Profiles";
            guestProfilesToolStripMenuItem.Click += guestProfilesToolStripMenuItem_Click;
            // 
            // servicorsToolStripMenuItem
            // 
            servicorsToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            servicorsToolStripMenuItem.Name = "servicorsToolStripMenuItem";
            servicorsToolStripMenuItem.Size = new Size(261, 36);
            servicorsToolStripMenuItem.Text = "Servicors";
            servicorsToolStripMenuItem.Click += servicorsToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookReservationToolStripMenuItem, roomInfosToolStripMenuItem });
            roomsToolStripMenuItem.Font = new Font("Segoe UI", 27.75F);
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(184, 66);
            roomsToolStripMenuItem.Text = "Rooms";
            // 
            // bookReservationToolStripMenuItem
            // 
            bookReservationToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            bookReservationToolStripMenuItem.Name = "bookReservationToolStripMenuItem";
            bookReservationToolStripMenuItem.Size = new Size(242, 36);
            bookReservationToolStripMenuItem.Text = "Reservation";
            bookReservationToolStripMenuItem.Click += bookReservationToolStripMenuItem_Click;
            // 
            // roomInfosToolStripMenuItem
            // 
            roomInfosToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            roomInfosToolStripMenuItem.Name = "roomInfosToolStripMenuItem";
            roomInfosToolStripMenuItem.Size = new Size(242, 36);
            roomInfosToolStripMenuItem.Text = "Room Info's";
            roomInfosToolStripMenuItem.Click += roomInfosToolStripMenuItem_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 24F);
            lblTime.Location = new Point(1443, 1203);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(109, 54);
            lblTime.TabIndex = 4;
            lblTime.Text = "Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 24F);
            lblDate.Location = new Point(1443, 1143);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(106, 54);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date";
            // 
            // ManagerHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3706eb7b_3c7d_403e_ad2c_76323e278483;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerHome";
            Text = "ManagerHome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem guestProfilesToolStripMenuItem;
        private ToolStripMenuItem servicorsToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem bookReservationToolStripMenuItem;
        private ToolStripMenuItem roomInfosToolStripMenuItem;
        private Label lblTime;
        private Label lblDate;
        private ToolStripMenuItem receptionistToolStripMenuItem;
    }
}