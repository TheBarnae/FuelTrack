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
            dashboard1 = new PictureBox();
            inventory = new PictureBox();
            transaction = new PictureBox();
            employee = new PictureBox();
            supplier = new PictureBox();
            reports = new PictureBox();
            auditTrial = new PictureBox();
            logout = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            dashboard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).BeginInit();
            menubar_dashboard.SuspendLayout();
            sales_panel.SuspendLayout();
            liters_panel.SuspendLayout();
            transaction_panel.SuspendLayout();
            Low_stocks_alerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)auditTrial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            usr_avatar.Location = new Point(860, 8);
            usr_avatar.Name = "usr_avatar";
            usr_avatar.Size = new Size(38, 38);
            usr_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            usr_avatar.TabIndex = 2;
            usr_avatar.TabStop = false;
            // 
            // role_label
            // 
            role_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            role_label.Location = new Point(761, 22);
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
            menubar_dashboard.Controls.Add(logout);
            menubar_dashboard.Controls.Add(auditTrial);
            menubar_dashboard.Controls.Add(reports);
            menubar_dashboard.Controls.Add(supplier);
            menubar_dashboard.Controls.Add(employee);
            menubar_dashboard.Controls.Add(transaction);
            menubar_dashboard.Controls.Add(inventory);
            menubar_dashboard.Controls.Add(dashboard1);
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
            menubar_dashboard.Size = new Size(174, 731);
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
            logout_btn.Location = new Point(46, 679);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(107, 30);
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
            audit_btn.Location = new Point(44, 556);
            audit_btn.Name = "audit_btn";
            audit_btn.Size = new Size(111, 33);
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
            reports_Btn.Location = new Point(46, 501);
            reports_Btn.Name = "reports_Btn";
            reports_Btn.Size = new Size(91, 33);
            reports_Btn.TabIndex = 10;
            reports_Btn.Text = "Reports";
            reports_Btn.UseVisualStyleBackColor = false;
            // 
            // rprt_label
            // 
            rprt_label.AutoSize = true;
            rprt_label.BackColor = Color.Transparent;
            rprt_label.FlatStyle = FlatStyle.Flat;
            rprt_label.Font = new Font("Segoe UI", 9F);
            rprt_label.ForeColor = Color.White;
            rprt_label.Location = new Point(6, 470);
            rprt_label.Name = "rprt_label";
            rprt_label.Size = new Size(54, 15);
            rprt_label.TabIndex = 9;
            rprt_label.Text = "REPORTS";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Maroon;
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
            employee_btn.Location = new Point(48, 353);
            employee_btn.Name = "employee_btn";
            employee_btn.Size = new Size(101, 33);
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
            suplier_btn.Location = new Point(46, 400);
            suplier_btn.Name = "suplier_btn";
            suplier_btn.Size = new Size(101, 33);
            suplier_btn.TabIndex = 6;
            suplier_btn.Text = "Suppliers";
            suplier_btn.UseVisualStyleBackColor = false;
            // 
            // manage_btn
            // 
            manage_btn.AutoSize = true;
            manage_btn.BackColor = Color.Transparent;
            manage_btn.FlatStyle = FlatStyle.Flat;
            manage_btn.Font = new Font("Segoe UI", 9F);
            manage_btn.ForeColor = Color.White;
            manage_btn.Location = new Point(2, 323);
            manage_btn.Name = "manage_btn";
            manage_btn.Size = new Size(57, 15);
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
            trans_btn.Location = new Point(46, 244);
            trans_btn.Name = "trans_btn";
            trans_btn.Size = new Size(116, 33);
            trans_btn.TabIndex = 4;
            trans_btn.Text = "Transactions";
            trans_btn.UseVisualStyleBackColor = false;
            // 
            // main_label_menu
            // 
            main_label_menu.AutoSize = true;
            main_label_menu.BackColor = Color.Transparent;
            main_label_menu.FlatStyle = FlatStyle.Flat;
            main_label_menu.Font = new Font("Segoe UI", 9F);
            main_label_menu.ForeColor = Color.White;
            main_label_menu.Location = new Point(8, 123);
            main_label_menu.Name = "main_label_menu";
            main_label_menu.Size = new Size(38, 15);
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
            inv_btn.Location = new Point(46, 198);
            inv_btn.Name = "inv_btn";
            inv_btn.Size = new Size(101, 33);
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
            dashboard_btn.Location = new Point(37, 151);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(127, 33);
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
            sales_panel.BackColor = SystemColors.Info;
            sales_panel.Controls.Add(pictureBox2);
            sales_panel.Controls.Add(today_label);
            sales_panel.Controls.Add(today_sales);
            sales_panel.Location = new Point(223, 116);
            sales_panel.Name = "sales_panel";
            sales_panel.Size = new Size(160, 132);
            sales_panel.TabIndex = 2;
            // 
            // today_label
            // 
            today_label.AutoSize = true;
            today_label.BackColor = SystemColors.Info;
            today_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            today_label.ForeColor = Color.Black;
            today_label.Location = new Point(70, 58);
            today_label.Name = "today_label";
            today_label.Size = new Size(53, 23);
            today_label.TabIndex = 1;
            today_label.Text = "label1";
            // 
            // today_sales
            // 
            today_sales.AutoSize = true;
            today_sales.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            today_sales.ForeColor = Color.Black;
            today_sales.Location = new Point(12, 10);
            today_sales.Name = "today_sales";
            today_sales.Size = new Size(97, 20);
            today_sales.TabIndex = 0;
            today_sales.Text = "Today's Sales";
            // 
            // liters_panel
            // 
            liters_panel.BackColor = SystemColors.Info;
            liters_panel.Controls.Add(pictureBox3);
            liters_panel.Controls.Add(litersdispensed_label);
            liters_panel.Controls.Add(liters_txt);
            liters_panel.Location = new Point(402, 116);
            liters_panel.Name = "liters_panel";
            liters_panel.Size = new Size(164, 132);
            liters_panel.TabIndex = 3;
            // 
            // litersdispensed_label
            // 
            litersdispensed_label.AutoSize = true;
            litersdispensed_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            litersdispensed_label.ForeColor = Color.Black;
            litersdispensed_label.Location = new Point(69, 58);
            litersdispensed_label.Name = "litersdispensed_label";
            litersdispensed_label.Size = new Size(55, 23);
            litersdispensed_label.TabIndex = 2;
            litersdispensed_label.Text = "label2";
            // 
            // liters_txt
            // 
            liters_txt.AutoSize = true;
            liters_txt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            liters_txt.ForeColor = Color.Black;
            liters_txt.Location = new Point(7, 8);
            liters_txt.Name = "liters_txt";
            liters_txt.Size = new Size(117, 20);
            liters_txt.TabIndex = 1;
            liters_txt.Text = "Liters dispensed";
            // 
            // transaction_panel
            // 
            transaction_panel.BackColor = SystemColors.Info;
            transaction_panel.Controls.Add(pictureBox4);
            transaction_panel.Controls.Add(transaction_label);
            transaction_panel.Controls.Add(transaction_txt);
            transaction_panel.Location = new Point(583, 116);
            transaction_panel.Name = "transaction_panel";
            transaction_panel.Size = new Size(164, 132);
            transaction_panel.TabIndex = 4;
            // 
            // transaction_label
            // 
            transaction_label.AutoSize = true;
            transaction_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction_label.ForeColor = Color.Black;
            transaction_label.Location = new Point(72, 58);
            transaction_label.Name = "transaction_label";
            transaction_label.Size = new Size(55, 23);
            transaction_label.TabIndex = 3;
            transaction_label.Text = "label3";
            // 
            // transaction_txt
            // 
            transaction_txt.AutoSize = true;
            transaction_txt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            transaction_txt.ForeColor = Color.Black;
            transaction_txt.Location = new Point(8, 8);
            transaction_txt.Name = "transaction_txt";
            transaction_txt.Size = new Size(93, 20);
            transaction_txt.TabIndex = 2;
            transaction_txt.Text = "Transactions";
            // 
            // Low_stocks_alerts
            // 
            Low_stocks_alerts.BackColor = SystemColors.Info;
            Low_stocks_alerts.Controls.Add(pictureBox5);
            Low_stocks_alerts.Controls.Add(stocks_label);
            Low_stocks_alerts.Controls.Add(low_stox_txt);
            Low_stocks_alerts.Location = new Point(768, 116);
            Low_stocks_alerts.Name = "Low_stocks_alerts";
            Low_stocks_alerts.Size = new Size(164, 132);
            Low_stocks_alerts.TabIndex = 5;
            // 
            // stocks_label
            // 
            stocks_label.AutoSize = true;
            stocks_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stocks_label.ForeColor = Color.Black;
            stocks_label.Location = new Point(72, 58);
            stocks_label.Name = "stocks_label";
            stocks_label.Size = new Size(56, 23);
            stocks_label.TabIndex = 4;
            stocks_label.Text = "label4";
            // 
            // low_stox_txt
            // 
            low_stox_txt.AutoSize = true;
            low_stox_txt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            low_stox_txt.ForeColor = Color.Black;
            low_stox_txt.Location = new Point(8, 8);
            low_stox_txt.Name = "low_stox_txt";
            low_stox_txt.Size = new Size(52, 20);
            low_stox_txt.TabIndex = 3;
            low_stox_txt.Text = "Stocks";
            // 
            // inventory_pnel
            // 
            inventory_pnel.BackColor = SystemColors.ControlLightLight;
            inventory_pnel.Location = new Point(223, 274);
            inventory_pnel.Name = "inventory_pnel";
            inventory_pnel.Size = new Size(344, 455);
            inventory_pnel.TabIndex = 6;
            // 
            // recent_transaction_panel
            // 
            recent_transaction_panel.BackColor = SystemColors.ControlLightLight;
            recent_transaction_panel.Location = new Point(583, 274);
            recent_transaction_panel.Name = "recent_transaction_panel";
            recent_transaction_panel.Size = new Size(349, 455);
            recent_transaction_panel.TabIndex = 7;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.Maroon;
            dashboard1.Image = (Image)resources.GetObject("dashboard1.Image");
            dashboard1.Location = new Point(19, 154);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(34, 30);
            dashboard1.SizeMode = PictureBoxSizeMode.StretchImage;
            dashboard1.TabIndex = 59;
            dashboard1.TabStop = false;
            // 
            // inventory
            // 
            inventory.BackColor = Color.Maroon;
            inventory.Image = (Image)resources.GetObject("inventory.Image");
            inventory.Location = new Point(19, 198);
            inventory.Name = "inventory";
            inventory.Size = new Size(34, 30);
            inventory.SizeMode = PictureBoxSizeMode.StretchImage;
            inventory.TabIndex = 60;
            inventory.TabStop = false;
            // 
            // transaction
            // 
            transaction.BackColor = Color.Maroon;
            transaction.Image = (Image)resources.GetObject("transaction.Image");
            transaction.Location = new Point(19, 247);
            transaction.Name = "transaction";
            transaction.Size = new Size(34, 30);
            transaction.SizeMode = PictureBoxSizeMode.StretchImage;
            transaction.TabIndex = 61;
            transaction.TabStop = false;
            // 
            // employee
            // 
            employee.BackColor = Color.Maroon;
            employee.Image = (Image)resources.GetObject("employee.Image");
            employee.Location = new Point(19, 353);
            employee.Name = "employee";
            employee.Size = new Size(34, 30);
            employee.SizeMode = PictureBoxSizeMode.StretchImage;
            employee.TabIndex = 62;
            employee.TabStop = false;
            // 
            // supplier
            // 
            supplier.BackColor = Color.Maroon;
            supplier.Image = (Image)resources.GetObject("supplier.Image");
            supplier.Location = new Point(19, 403);
            supplier.Name = "supplier";
            supplier.Size = new Size(34, 30);
            supplier.SizeMode = PictureBoxSizeMode.StretchImage;
            supplier.TabIndex = 63;
            supplier.TabStop = false;
            // 
            // reports
            // 
            reports.BackColor = Color.Maroon;
            reports.Image = (Image)resources.GetObject("reports.Image");
            reports.Location = new Point(19, 504);
            reports.Name = "reports";
            reports.Size = new Size(34, 30);
            reports.SizeMode = PictureBoxSizeMode.StretchImage;
            reports.TabIndex = 64;
            reports.TabStop = false;
            // 
            // auditTrial
            // 
            auditTrial.BackColor = Color.Maroon;
            auditTrial.Image = (Image)resources.GetObject("auditTrial.Image");
            auditTrial.Location = new Point(19, 556);
            auditTrial.Name = "auditTrial";
            auditTrial.Size = new Size(34, 33);
            auditTrial.SizeMode = PictureBoxSizeMode.StretchImage;
            auditTrial.TabIndex = 65;
            auditTrial.TabStop = false;
            // 
            // logout
            // 
            logout.BackColor = Color.Maroon;
            logout.Image = (Image)resources.GetObject("logout.Image");
            logout.Location = new Point(25, 679);
            logout.Name = "logout";
            logout.Size = new Size(34, 30);
            logout.SizeMode = PictureBoxSizeMode.StretchImage;
            logout.TabIndex = 66;
            logout.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Maroon;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Maroon;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 68;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Maroon;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 44);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 69;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Maroon;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(17, 44);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 51);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 70;
            pictureBox5.TabStop = false;
            // 
            // Dashboard
            // 
            AccessibleRole = AccessibleRole.SplitButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(979, 768);
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
            ((System.ComponentModel.ISupportInitialize)dashboard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)transaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)employee).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)reports).EndInit();
            ((System.ComponentModel.ISupportInitialize)auditTrial).EndInit();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox dashboard1;
        private PictureBox inventory;
        private PictureBox transaction;
        private PictureBox employee;
        private PictureBox supplier;
        private PictureBox reports;
        private PictureBox auditTrial;
        private PictureBox logout;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}