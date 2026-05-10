namespace FuelTrack
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            FuelTrack_Logo = new PictureBox();
            user_label = new Label();
            pass_label = new Label();
            login_btn = new Button();
            user_txtbox = new TextBox();
            pass_txtbox = new TextBox();
            password_toggle = new PictureBox();
            login_pic = new PictureBox();
            leftpanel_login = new Panel();
            welcomelbl = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)FuelTrack_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)password_toggle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)login_pic).BeginInit();
            leftpanel_login.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FuelTrack_Logo
            // 
            FuelTrack_Logo.Anchor = AnchorStyles.Top;
            FuelTrack_Logo.Image = Properties.Resources.FUELTRACK_LOGO;
            FuelTrack_Logo.Location = new Point(95, 38);
            FuelTrack_Logo.Name = "FuelTrack_Logo";
            FuelTrack_Logo.Size = new Size(225, 223);
            FuelTrack_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            FuelTrack_Logo.TabIndex = 0;
            FuelTrack_Logo.TabStop = false;
            FuelTrack_Logo.Click += FuelTrack_Logo_Click;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_label.Location = new Point(95, 285);
            user_label.Name = "user_label";
            user_label.Size = new Size(75, 20);
            user_label.TabIndex = 1;
            user_label.Text = "Username";
            // 
            // pass_label
            // 
            pass_label.AutoSize = true;
            pass_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass_label.Location = new Point(95, 352);
            pass_label.Name = "pass_label";
            pass_label.Size = new Size(70, 20);
            pass_label.TabIndex = 3;
            pass_label.Text = "Password";
            // 
            // login_btn
            // 
            login_btn.Anchor = AnchorStyles.Bottom;
            login_btn.AutoSize = true;
            login_btn.BackColor = Color.Maroon;
            login_btn.BackgroundImageLayout = ImageLayout.Center;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.ImageAlign = ContentAlignment.BottomCenter;
            login_btn.Location = new Point(95, 422);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(225, 45);
            login_btn.TabIndex = 5;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // user_txtbox
            // 
            user_txtbox.BackColor = Color.FromArgb(224, 224, 224);
            user_txtbox.BorderStyle = BorderStyle.None;
            user_txtbox.Font = new Font("Segoe UI", 12F);
            user_txtbox.Location = new Point(95, 308);
            user_txtbox.Name = "user_txtbox";
            user_txtbox.Size = new Size(225, 22);
            user_txtbox.TabIndex = 6;
            // 
            // pass_txtbox
            // 
            pass_txtbox.BackColor = Color.FromArgb(224, 224, 224);
            pass_txtbox.BorderStyle = BorderStyle.None;
            pass_txtbox.Font = new Font("Segoe UI", 12F);
            pass_txtbox.Location = new Point(95, 375);
            pass_txtbox.Name = "pass_txtbox";
            pass_txtbox.Size = new Size(225, 22);
            pass_txtbox.TabIndex = 7;
            // 
            // password_toggle
            // 
            password_toggle.BackColor = Color.Gray;
            password_toggle.Cursor = Cursors.Hand;
            password_toggle.Location = new Point(299, 375);
            password_toggle.Name = "password_toggle";
            password_toggle.Size = new Size(21, 21);
            password_toggle.SizeMode = PictureBoxSizeMode.Zoom;
            password_toggle.TabIndex = 8;
            password_toggle.TabStop = false;
            password_toggle.Click += password_toggle_Click;
            // 
            // login_pic
            // 
            login_pic.Image = (Image)resources.GetObject("login_pic.Image");
            login_pic.Location = new Point(-30, 122);
            login_pic.Name = "login_pic";
            login_pic.Size = new Size(538, 367);
            login_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            login_pic.TabIndex = 9;
            login_pic.TabStop = false;
            // 
            // leftpanel_login
            // 
            leftpanel_login.BackColor = Color.Maroon;
            leftpanel_login.Controls.Add(welcomelbl);
            leftpanel_login.Controls.Add(login_pic);
            leftpanel_login.Location = new Point(0, -3);
            leftpanel_login.Name = "leftpanel_login";
            leftpanel_login.Size = new Size(476, 556);
            leftpanel_login.TabIndex = 10;
            leftpanel_login.Paint += panel1_Paint;
            // 
            // welcomelbl
            // 
            welcomelbl.AutoSize = true;
            welcomelbl.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomelbl.ForeColor = Color.White;
            welcomelbl.Location = new Point(88, 41);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(307, 45);
            welcomelbl.TabIndex = 10;
            welcomelbl.Text = "Welcome Admin!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FuelTrack_Logo);
            panel1.Controls.Add(user_label);
            panel1.Controls.Add(password_toggle);
            panel1.Controls.Add(pass_label);
            panel1.Controls.Add(pass_txtbox);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(user_txtbox);
            panel1.Location = new Point(475, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 525);
            panel1.TabIndex = 11;
            // 
            // Login
            // 
            AcceptButton = login_btn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(877, 525);
            Controls.Add(panel1);
            Controls.Add(leftpanel_login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FuelTrack — Login";
            ((System.ComponentModel.ISupportInitialize)FuelTrack_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)password_toggle).EndInit();
            ((System.ComponentModel.ISupportInitialize)login_pic).EndInit();
            leftpanel_login.ResumeLayout(false);
            leftpanel_login.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox FuelTrack_Logo;
        private Label user_label;
        private Label pass_label;
        private Button login_btn;
        private TextBox user_txtbox;
        private TextBox pass_txtbox;
        private PictureBox password_toggle;
        private PictureBox login_pic;
        private Panel leftpanel_login;
        private Label welcomelbl;
        private Panel panel1;
    }
}
