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
            dashboard_panel = new Panel();
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
            fueltrack_icon = new Label();
            sales_panel = new Panel();
            today_label = new Label();
            today_sales = new Label();
            liters_panel = new Panel();
            litersdispensed_label = new Label();
            liters_txt = new Label();
            transaction_panel = new Panel();
            transaction_label = new Label();
            transaction_txt = new Label();
            Low_stocks_alerts = new Panel();
            stocks_label = new Label();
            low_stox_txt = new Label();
            inventory_pnel = new Panel();
            recent_transaction_panel = new Panel();
            dashboard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).BeginInit();
            menubar_dashboard.SuspendLayout();
            sales_panel.SuspendLayout();
            liters_panel.SuspendLayout();
            transaction_panel.SuspendLayout();
            Low_stocks_alerts.SuspendLayout();
            SuspendLayout();
            // 
            // dashboard_panel
            // 
            dashboard_panel.BackColor = SystemColors.ButtonHighlight;
            dashboard_panel.Controls.Add(usr_avatar);
            dashboard_panel.Controls.Add(role_label);
            dashboard_panel.Controls.Add(date_label);
            dashboard_panel.Location = new Point(-2, -3);
            dashboard_panel.Name = "dashboard_panel";
            dashboard_panel.Size = new Size(1271, 52);
            dashboard_panel.TabIndex = 0;
            // 
            // usr_avatar
            // 
            usr_avatar.BackColor = SystemColors.ControlDark;
            usr_avatar.BackgroundImageLayout = ImageLayout.None;
            usr_avatar.Location = new Point(879, 11);
            usr_avatar.Name = "usr_avatar";
            usr_avatar.Size = new Size(38, 38);
            usr_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            usr_avatar.TabIndex = 2;
            usr_avatar.TabStop = false;
            // 
            // role_label
            // 
            role_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            role_label.Location = new Point(673, 22);
            role_label.Name = "role_label";
            role_label.Size = new Size(200, 15);
            role_label.TabIndex = 1;
            role_label.Text = "--ROLE--";
            role_label.TextAlign = ContentAlignment.MiddleRight;
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
            menubar_dashboard.BackColor = Color.Maroon;
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
            menubar_dashboard.Controls.Add(fueltrack_icon);
            menubar_dashboard.ForeColor = SystemColors.ActiveCaptionText;
            menubar_dashboard.Location = new Point(0, 37);
            menubar_dashboard.Name = "menubar_dashboard";
            menubar_dashboard.Size = new Size(174, 648);
            menubar_dashboard.TabIndex = 1;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.Transparent;
            logout_btn.BackgroundImageLayout = ImageLayout.None;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(12, 525);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(135, 30);
            logout_btn.TabIndex = 12;
            logout_btn.Text = "LOGOUT";
            logout_btn.UseVisualStyleBackColor = false;
            // 
            // audit_btn
            // 
            audit_btn.BackColor = Color.Transparent;
            audit_btn.FlatAppearance.BorderSize = 0;
            audit_btn.FlatStyle = FlatStyle.Flat;
            audit_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            audit_btn.ForeColor = Color.White;
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
            reports_Btn.ForeColor = Color.White;
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
            richTextBox1.Location = new Point(37, 37);
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
            employee_btn.ForeColor = Color.White;
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
            suplier_btn.ForeColor = Color.White;
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
            trans_btn.ForeColor = Color.White;
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
            inv_btn.ForeColor = Color.White;
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
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(-3, 102);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(163, 33);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            // 
            // fueltrack_icon
            // 
            fueltrack_icon.Image = Properties.Resources.fuel_station_vector_icon;
            fueltrack_icon.Location = new Point(6, 34);
            fueltrack_icon.Name = "fueltrack_icon";
            fueltrack_icon.Size = new Size(39, 38);
            fueltrack_icon.TabIndex = 13;
            fueltrack_icon.Text = "               ";
            // 
            // sales_panel
            // 
            sales_panel.BackColor = Color.Maroon;
            sales_panel.Controls.Add(today_label);
            sales_panel.Controls.Add(today_sales);
            sales_panel.Location = new Point(221, 203);
            sales_panel.Name = "sales_panel";
            sales_panel.Size = new Size(160, 93);
            sales_panel.TabIndex = 2;
            // 
            // today_label
            // 
            today_label.AutoSize = true;
            today_label.BackColor = Color.Maroon;
            today_label.Font = new Font("Segoe UI", 13F);
            today_label.ForeColor = Color.White;
            today_label.Location = new Point(3, 31);
            today_label.Name = "today_label";
            today_label.Size = new Size(59, 25);
            today_label.TabIndex = 1;
            today_label.Text = "label1";
            // 
            // today_sales
            // 
            today_sales.AutoSize = true;
            today_sales.Font = new Font("Segoe UI", 9F);
            today_sales.ForeColor = Color.White;
            today_sales.Location = new Point(5, 12);
            today_sales.Name = "today_sales";
            today_sales.Size = new Size(75, 15);
            today_sales.TabIndex = 0;
            today_sales.Text = "Today's Sales";
            // 
            // liters_panel
            // 
            liters_panel.BackColor = Color.Maroon;
            liters_panel.Controls.Add(litersdispensed_label);
            liters_panel.Controls.Add(liters_txt);
            liters_panel.Location = new Point(401, 203);
            liters_panel.Name = "liters_panel";
            liters_panel.Size = new Size(164, 93);
            liters_panel.TabIndex = 3;
            // 
            // litersdispensed_label
            // 
            litersdispensed_label.AutoSize = true;
            litersdispensed_label.Font = new Font("Segoe UI", 13F);
            litersdispensed_label.ForeColor = Color.White;
            litersdispensed_label.Location = new Point(5, 30);
            litersdispensed_label.Name = "litersdispensed_label";
            litersdispensed_label.Size = new Size(59, 25);
            litersdispensed_label.TabIndex = 2;
            litersdispensed_label.Text = "label2";
            // 
            // liters_txt
            // 
            liters_txt.AutoSize = true;
            liters_txt.Font = new Font("Segoe UI", 9F);
            liters_txt.ForeColor = Color.White;
            liters_txt.Location = new Point(5, 9);
            liters_txt.Name = "liters_txt";
            liters_txt.Size = new Size(91, 15);
            liters_txt.TabIndex = 1;
            liters_txt.Text = "Liters dispensed";
            // 
            // transaction_panel
            // 
            transaction_panel.BackColor = Color.Maroon;
            transaction_panel.Controls.Add(transaction_label);
            transaction_panel.Controls.Add(transaction_txt);
            transaction_panel.Location = new Point(583, 203);
            transaction_panel.Name = "transaction_panel";
            transaction_panel.Size = new Size(164, 93);
            transaction_panel.TabIndex = 4;
            // 
            // transaction_label
            // 
            transaction_label.AutoSize = true;
            transaction_label.Font = new Font("Segoe UI", 13F);
            transaction_label.ForeColor = Color.White;
            transaction_label.Location = new Point(5, 31);
            transaction_label.Name = "transaction_label";
            transaction_label.Size = new Size(59, 25);
            transaction_label.TabIndex = 3;
            transaction_label.Text = "label3";
            // 
            // transaction_txt
            // 
            transaction_txt.AutoSize = true;
            transaction_txt.Font = new Font("Segoe UI", 9F);
            transaction_txt.ForeColor = Color.White;
            transaction_txt.Location = new Point(5, 9);
            transaction_txt.Name = "transaction_txt";
            transaction_txt.Size = new Size(72, 15);
            transaction_txt.TabIndex = 2;
            transaction_txt.Text = "Transactions";
            // 
            // Low_stocks_alerts
            // 
            Low_stocks_alerts.BackColor = Color.Maroon;
            Low_stocks_alerts.Controls.Add(stocks_label);
            Low_stocks_alerts.Controls.Add(low_stox_txt);
            Low_stocks_alerts.Location = new Point(753, 203);
            Low_stocks_alerts.Name = "Low_stocks_alerts";
            Low_stocks_alerts.Size = new Size(164, 93);
            Low_stocks_alerts.TabIndex = 5;
            // 
            // stocks_label
            // 
            stocks_label.AutoSize = true;
            stocks_label.Font = new Font("Segoe UI", 13F);
            stocks_label.ForeColor = Color.White;
            stocks_label.Location = new Point(5, 31);
            stocks_label.Name = "stocks_label";
            stocks_label.Size = new Size(59, 25);
            stocks_label.TabIndex = 4;
            stocks_label.Text = "label4";
            // 
            // low_stox_txt
            // 
            low_stox_txt.AutoSize = true;
            low_stox_txt.Font = new Font("Segoe UI", 9F);
            low_stox_txt.ForeColor = Color.White;
            low_stox_txt.Location = new Point(5, 9);
            low_stox_txt.Name = "low_stox_txt";
            low_stox_txt.Size = new Size(41, 15);
            low_stox_txt.TabIndex = 3;
            low_stox_txt.Text = "Stocks";
            // 
            // inventory_pnel
            // 
            inventory_pnel.BackColor = Color.WhiteSmoke;
            inventory_pnel.Location = new Point(221, 321);
            inventory_pnel.Name = "inventory_pnel";
            inventory_pnel.Size = new Size(344, 190);
            inventory_pnel.TabIndex = 6;
            // 
            // recent_transaction_panel
            // 
            recent_transaction_panel.BackColor = Color.WhiteSmoke;
            recent_transaction_panel.Location = new Point(594, 321);
            recent_transaction_panel.Name = "recent_transaction_panel";
            recent_transaction_panel.Size = new Size(333, 190);
            recent_transaction_panel.TabIndex = 7;
            // 
            // Dashboard
            // 
            AccessibleRole = AccessibleRole.SplitButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(969, 616);
            Controls.Add(recent_transaction_panel);
            Controls.Add(inventory_pnel);
            Controls.Add(Low_stocks_alerts);
            Controls.Add(transaction_panel);
            Controls.Add(liters_panel);
            Controls.Add(sales_panel);
            Controls.Add(dashboard_panel);
            Controls.Add(menubar_dashboard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FuelTrack — Dashboard";
            Load += Dashboard_Load;
            dashboard_panel.ResumeLayout(false);
            dashboard_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).EndInit();
            menubar_dashboard.ResumeLayout(false);
            menubar_dashboard.PerformLayout();
            sales_panel.ResumeLayout(false);
            sales_panel.PerformLayout();
            liters_panel.ResumeLayout(false);
            liters_panel.PerformLayout();
            transaction_panel.ResumeLayout(false);
            transaction_panel.PerformLayout();
            Low_stocks_alerts.ResumeLayout(false);
            Low_stocks_alerts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboard_panel;
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
        private Button logout_btn;
        private Panel sales_panel;
        private Panel liters_panel;
        private Panel transaction_panel;
        private PictureBox usr_avatar;
        private Label role_label;
        private Panel Low_stocks_alerts;
        private Panel inventory_pnel;
        private Panel recent_transaction_panel;
        private Label today_sales;
        private Label liters_txt;
        private Label transaction_txt;
        private Label low_stox_txt;
        private Label fueltrack_icon;
        private Label today_label;
        private Label litersdispensed_label;
        private Label transaction_label;
        private Label stocks_label;
    }
}