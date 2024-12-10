namespace BetterCallRoomy
{
    partial class ReceptionistHome
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
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            guestProfilesToolStripMenuItem = new ToolStripMenuItem();
            servicorsToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            bookReservationToolStripMenuItem = new ToolStripMenuItem();
            roomInfosToolStripMenuItem = new ToolStripMenuItem();
            lblDate = new Label();
            lblTime = new Label();
            timerDate = new System.Windows.Forms.Timer(components);
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
            menuStrip1.TabIndex = 0;
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
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guestProfilesToolStripMenuItem, servicorsToolStripMenuItem });
            infoToolStripMenuItem.Font = new Font("Segoe UI", 27.75F);
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(124, 66);
            infoToolStripMenuItem.Text = "Info";
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
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 24F);
            lblDate.Location = new Point(1440, 1144);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(106, 54);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 24F);
            lblTime.Location = new Point(1440, 1204);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(109, 54);
            lblTime.TabIndex = 2;
            lblTime.Text = "Time";
            // 
            // timerDate
            // 
            timerDate.Enabled = true;
            timerDate.Tick += timerDate_Tick;
            // 
            // ReceptionistHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3706eb7b_3c7d_403e_ad2c_76323e278483;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1, 3, 1, 3);
            Name = "ReceptionistHome";
            Text = "ReceptionistHome";
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem bookReservationToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private Label lblDate;
        private Label lblTime;
        private System.Windows.Forms.Timer timerDate;
        private ToolStripMenuItem roomInfosToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem guestProfilesToolStripMenuItem;
        private ToolStripMenuItem servicorsToolStripMenuItem;
    }
}