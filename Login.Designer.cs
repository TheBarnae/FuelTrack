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
            ((System.ComponentModel.ISupportInitialize)FuelTrack_Logo).BeginInit();
            SuspendLayout();
            // 
            // FuelTrack_Logo
            // 
            FuelTrack_Logo.Anchor = AnchorStyles.Top;
            FuelTrack_Logo.Image = Properties.Resources.FUELTRACK_LOGO;
            FuelTrack_Logo.Location = new Point(116, -1);
            FuelTrack_Logo.Name = "FuelTrack_Logo";
            FuelTrack_Logo.Size = new Size(149, 149);
            FuelTrack_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            FuelTrack_Logo.TabIndex = 0;
            FuelTrack_Logo.TabStop = false;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Location = new Point(103, 174);
            user_label.Name = "user_label";
            user_label.Size = new Size(60, 15);
            user_label.TabIndex = 1;
            user_label.Text = "Username";
            // 
            // pass_label
            // 
            pass_label.AutoSize = true;
            pass_label.Location = new Point(103, 229);
            pass_label.Name = "pass_label";
            pass_label.Size = new Size(57, 15);
            pass_label.TabIndex = 3;
            pass_label.Text = "Password";
            // 
            // login_btn
            // 
            login_btn.Anchor = AnchorStyles.Bottom;
            login_btn.AutoSize = true;
            login_btn.BackgroundImageLayout = ImageLayout.Center;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.ImageAlign = ContentAlignment.BottomCenter;
            login_btn.Location = new Point(150, 300);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(83, 25);
            login_btn.TabIndex = 5;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // user_txtbox
            // 
            user_txtbox.BorderStyle = BorderStyle.None;
            user_txtbox.Font = new Font("Segoe UI", 12F);
            user_txtbox.Location = new Point(103, 192);
            user_txtbox.Name = "user_txtbox";
            user_txtbox.Size = new Size(179, 22);
            user_txtbox.TabIndex = 6;
            // 
            // pass_txtbox
            // 
            pass_txtbox.BorderStyle = BorderStyle.None;
            pass_txtbox.Font = new Font("Segoe UI", 12F);
            pass_txtbox.Location = new Point(103, 247);
            pass_txtbox.Name = "pass_txtbox";
            pass_txtbox.Size = new Size(179, 22);
            pass_txtbox.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(385, 359);
            Controls.Add(pass_txtbox);
            Controls.Add(user_txtbox);
            Controls.Add(login_btn);
            Controls.Add(pass_label);
            Controls.Add(user_label);
            Controls.Add(FuelTrack_Logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FuelTrack — Login";
            ((System.ComponentModel.ISupportInitialize)FuelTrack_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FuelTrack_Logo;
        private Label user_label;
        private Label pass_label;
        private Button login_btn;
        private TextBox user_txtbox;
        private TextBox pass_txtbox;
    }
}
