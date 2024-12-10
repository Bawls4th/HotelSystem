namespace BetterCallRoomy
{
    partial class LogInForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbxUsername = new TextBox();
            label4 = new Label();
            txtbxPassword = new TextBox();
            btnLogIn = new Button();
            cbSP = new CheckBox();
            rbManager = new RadioButton();
            rbReceptionist = new RadioButton();
            lblLogic = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(231, -29);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 174);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 106);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 137);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 2;
            label2.Text = "LOG IN TO CONTINUE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDarkDark;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(217, 158);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 3;
            label3.Text = "USERNAME:";
            // 
            // txtbxUsername
            // 
            txtbxUsername.Location = new Point(217, 183);
            txtbxUsername.Margin = new Padding(3, 2, 3, 2);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(289, 23);
            txtbxUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDarkDark;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(216, 209);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 5;
            label4.Text = "PASSWORD:";
            // 
            // txtbxPassword
            // 
            txtbxPassword.Location = new Point(217, 233);
            txtbxPassword.Margin = new Padding(3, 2, 3, 2);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.Size = new Size(289, 23);
            txtbxPassword.TabIndex = 6;
            txtbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.Location = new Point(320, 359);
            btnLogIn.Margin = new Padding(3, 2, 3, 2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(74, 30);
            btnLogIn.TabIndex = 7;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // cbSP
            // 
            cbSP.AutoSize = true;
            cbSP.BackColor = SystemColors.ControlDarkDark;
            cbSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSP.Location = new Point(217, 259);
            cbSP.Margin = new Padding(3, 2, 3, 2);
            cbSP.Name = "cbSP";
            cbSP.Size = new Size(112, 19);
            cbSP.TabIndex = 8;
            cbSP.Text = "Show Password";
            cbSP.UseVisualStyleBackColor = false;
            cbSP.CheckedChanged += cbSP_CheckedChanged;
            // 
            // rbManager
            // 
            rbManager.AutoSize = true;
            rbManager.BackColor = SystemColors.ControlDarkDark;
            rbManager.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbManager.Location = new Point(231, 286);
            rbManager.Name = "rbManager";
            rbManager.Size = new Size(74, 19);
            rbManager.TabIndex = 9;
            rbManager.TabStop = true;
            rbManager.Text = "Manager";
            rbManager.UseVisualStyleBackColor = false;
            // 
            // rbReceptionist
            // 
            rbReceptionist.AutoSize = true;
            rbReceptionist.BackColor = SystemColors.ControlDarkDark;
            rbReceptionist.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbReceptionist.Location = new Point(400, 285);
            rbReceptionist.Name = "rbReceptionist";
            rbReceptionist.Size = new Size(95, 19);
            rbReceptionist.TabIndex = 10;
            rbReceptionist.TabStop = true;
            rbReceptionist.Text = "Receptionist";
            rbReceptionist.UseVisualStyleBackColor = false;
            // 
            // lblLogic
            // 
            lblLogic.AccessibleRole = AccessibleRole.None;
            lblLogic.AutoSize = true;
            lblLogic.BackColor = SystemColors.ControlDarkDark;
            lblLogic.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblLogic.ForeColor = Color.LightCoral;
            lblLogic.Location = new Point(265, 315);
            lblLogic.Name = "lblLogic";
            lblLogic.Size = new Size(12, 13);
            lblLogic.TabIndex = 12;
            lblLogic.Text = "_";
            lblLogic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Location = new Point(155, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(404, 246);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.homepage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 435);
            Controls.Add(txtbxPassword);
            Controls.Add(txtbxUsername);
            Controls.Add(rbReceptionist);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(cbSP);
            Controls.Add(rbManager);
            Controls.Add(lblLogic);
            Controls.Add(btnLogIn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogInForm";
            Text = "LogIn";
            Load += LogInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbxUsername;
        private Label label4;
        private TextBox txtbxPassword;
        private Button btnLogIn;
        private CheckBox cbSP;
        private RadioButton rbManager;
        private RadioButton rbReceptionist;
        private Label lblLogic;
        private PictureBox pictureBox2;
    }
}
