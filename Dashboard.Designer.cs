namespace FuelTrack
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            alert_label = new Label();
            usr_avatar = new PictureBox();
            role_label = new Label();
            date_label = new Label();
            menubar_dashboard = new Panel();
            logout_btn = new Button();
            audit_btn = new Button();
            reports_Btn = new Button();
            rprt_label = new Label();
            richTextBox1 = new RichTextBox();
            employee_btn = new Button();
            suplier_btn = new Button();
            manage_btn = new Label();
            trans_btn = new Button();
            main_label_menu = new Label();
            inv_btn = new Button();
            dashboard_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).BeginInit();
            menubar_dashboard.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(alert_label);
            panel1.Controls.Add(usr_avatar);
            panel1.Controls.Add(role_label);
            panel1.Controls.Add(date_label);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 59);
            panel1.TabIndex = 0;
            // 
            // alert_label
            // 
            alert_label.AutoSize = true;
            alert_label.Location = new Point(635, 22);
            alert_label.Name = "alert_label";
            alert_label.Size = new Size(65, 15);
            alert_label.TabIndex = 3;
            alert_label.Text = "--ALERTS--";
            // 
            // usr_avatar
            // 
            usr_avatar.BackColor = SystemColors.ControlDark;
            usr_avatar.BackgroundImageLayout = ImageLayout.None;
            usr_avatar.Location = new Point(706, 12);
            usr_avatar.Name = "usr_avatar";
            usr_avatar.Size = new Size(38, 38);
            usr_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            usr_avatar.TabIndex = 2;
            usr_avatar.TabStop = false;
            // 
            // role_label
            // 
            role_label.AutoSize = true;
            role_label.Location = new Point(753, 22);
            role_label.Name = "role_label";
            role_label.Size = new Size(55, 15);
            role_label.TabIndex = 1;
            role_label.Text = "--ROLE--";
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.Location = new Point(14, 22);
            date_label.Name = "date_label";
            date_label.Size = new Size(97, 15);
            date_label.TabIndex = 0;
            date_label.Text = "DATE GOES HERE";
            // 
            // menubar_dashboard
            // 
            menubar_dashboard.BackColor = Color.FromArgb(26, 58, 92);
            menubar_dashboard.Controls.Add(logout_btn);
            menubar_dashboard.Controls.Add(audit_btn);
            menubar_dashboard.Controls.Add(reports_Btn);
            menubar_dashboard.Controls.Add(rprt_label);
            menubar_dashboard.Controls.Add(richTextBox1);
            menubar_dashboard.Controls.Add(employee_btn);
            menubar_dashboard.Controls.Add(suplier_btn);
            menubar_dashboard.Controls.Add(manage_btn);
            menubar_dashboard.Controls.Add(trans_btn);
            menubar_dashboard.Controls.Add(main_label_menu);
            menubar_dashboard.Controls.Add(inv_btn);
            menubar_dashboard.Controls.Add(dashboard_btn);
            menubar_dashboard.ForeColor = SystemColors.ActiveCaptionText;
            menubar_dashboard.Location = new Point(0, 37);
            menubar_dashboard.Name = "menubar_dashboard";
            menubar_dashboard.Size = new Size(163, 648);
            menubar_dashboard.TabIndex = 1;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.Transparent;
            logout_btn.BackgroundImageLayout = ImageLayout.None;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Location = new Point(12, 444);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(135, 30);
            logout_btn.TabIndex = 12;
            logout_btn.Text = "LOGOUT";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // audit_btn
            // 
            audit_btn.BackColor = Color.Transparent;
            audit_btn.FlatAppearance.BorderSize = 0;
            audit_btn.FlatStyle = FlatStyle.Flat;
            audit_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            audit_btn.Location = new Point(0, 385);
            audit_btn.Name = "audit_btn";
            audit_btn.Size = new Size(163, 33);
            audit_btn.TabIndex = 11;
            audit_btn.Text = "Audit Trail";
            audit_btn.UseVisualStyleBackColor = false;
            // 
            // reports_Btn
            // 
            reports_Btn.BackColor = Color.Transparent;
            reports_Btn.FlatAppearance.BorderSize = 0;
            reports_Btn.FlatStyle = FlatStyle.Flat;
            reports_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reports_Btn.Location = new Point(0, 346);
            reports_Btn.Name = "reports_Btn";
            reports_Btn.Size = new Size(163, 33);
            reports_Btn.TabIndex = 10;
            reports_Btn.Text = "Reports";
            reports_Btn.UseVisualStyleBackColor = false;
            // 
            // rprt_label
            // 
            rprt_label.AutoSize = true;
            rprt_label.BackColor = Color.Transparent;
            rprt_label.FlatStyle = FlatStyle.Flat;
            rprt_label.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            rprt_label.ForeColor = Color.White;
            rprt_label.Location = new Point(3, 332);
            rprt_label.Name = "rprt_label";
            rprt_label.Size = new Size(39, 11);
            rprt_label.TabIndex = 9;
            rprt_label.Text = "REPORTS";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(26, 58, 92);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(31, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(100, 32);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "FuelTrack";
            // 
            // employee_btn
            // 
            employee_btn.BackColor = Color.Transparent;
            employee_btn.FlatAppearance.BorderSize = 0;
            employee_btn.FlatStyle = FlatStyle.Flat;
            employee_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employee_btn.Location = new Point(0, 237);
            employee_btn.Name = "employee_btn";
            employee_btn.Size = new Size(163, 33);
            employee_btn.TabIndex = 7;
            employee_btn.Text = "Employees";
            employee_btn.UseVisualStyleBackColor = false;
            // 
            // suplier_btn
            // 
            suplier_btn.BackColor = Color.Transparent;
            suplier_btn.FlatAppearance.BorderSize = 0;
            suplier_btn.FlatStyle = FlatStyle.Flat;
            suplier_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suplier_btn.Location = new Point(0, 276);
            suplier_btn.Name = "suplier_btn";
            suplier_btn.Size = new Size(163, 33);
            suplier_btn.TabIndex = 6;
            suplier_btn.Text = "Suppliers";
            suplier_btn.UseVisualStyleBackColor = false;
            // 
            // manage_btn
            // 
            manage_btn.AutoSize = true;
            manage_btn.BackColor = Color.Transparent;
            manage_btn.FlatStyle = FlatStyle.Flat;
            manage_btn.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            manage_btn.ForeColor = Color.White;
            manage_btn.Location = new Point(3, 223);
            manage_btn.Name = "manage_btn";
            manage_btn.Size = new Size(41, 11);
            manage_btn.TabIndex = 5;
            manage_btn.Text = "MANAGE";
            // 
            // trans_btn
            // 
            trans_btn.BackColor = Color.Transparent;
            trans_btn.FlatAppearance.BorderSize = 0;
            trans_btn.FlatStyle = FlatStyle.Flat;
            trans_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trans_btn.Location = new Point(0, 178);
            trans_btn.Name = "trans_btn";
            trans_btn.Size = new Size(163, 33);
            trans_btn.TabIndex = 4;
            trans_btn.Text = "Transactions";
            trans_btn.UseVisualStyleBackColor = false;
            // 
            // main_label_menu
            // 
            main_label_menu.AutoSize = true;
            main_label_menu.BackColor = Color.Transparent;
            main_label_menu.FlatStyle = FlatStyle.Flat;
            main_label_menu.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            main_label_menu.ForeColor = Color.White;
            main_label_menu.Location = new Point(3, 85);
            main_label_menu.Name = "main_label_menu";
            main_label_menu.Size = new Size(28, 11);
            main_label_menu.TabIndex = 3;
            main_label_menu.Text = "MAIN";
            // 
            // inv_btn
            // 
            inv_btn.BackColor = Color.Transparent;
            inv_btn.FlatAppearance.BorderSize = 0;
            inv_btn.FlatStyle = FlatStyle.Flat;
            inv_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inv_btn.Location = new Point(0, 139);
            inv_btn.Name = "inv_btn";
            inv_btn.Size = new Size(163, 33);
            inv_btn.TabIndex = 2;
            inv_btn.Text = "Inventory";
            inv_btn.UseVisualStyleBackColor = false;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.Transparent;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_btn.Location = new Point(0, 100);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(163, 33);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(807, 523);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(menubar_dashboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FuelTrack — Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).EndInit();
            menubar_dashboard.ResumeLayout(false);
            menubar_dashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel menubar_dashboard;
        private Button dashboard_btn;
        private Label main_label_menu;
        private Button inv_btn;
        private Button trans_btn;
        private Label manage_btn;
        private Button employee_btn;
        private Button suplier_btn;
        private RichTextBox richTextBox1;
        private Label rprt_label;
        private Button audit_btn;
        private Button reports_Btn;
        private Label date_label;
        private Label role_label;
        private Label alert_label;
        private PictureBox usr_avatar;
        private Button logout_btn;
    }
}