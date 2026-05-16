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
            sales_panel = new Panel();
            pictureBox2 = new PictureBox();
            today_label = new Label();
            today_sales = new Label();
            liters_panel = new Panel();
            pictureBox3 = new PictureBox();
            litersdispensed_label = new Label();
            liters_txt = new Label();
            transaction_panel = new Panel();
            pictureBox4 = new PictureBox();
            transaction_label = new Label();
            transaction_txt = new Label();
            Low_stocks_alerts = new Panel();
            pictureBox5 = new PictureBox();
            stocks_label = new Label();
            low_stox_txt = new Label();
            inventory_pnel = new Panel();
            recent_transaction_panel = new Panel();
            dashboard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).BeginInit();
            sales_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            liters_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            transaction_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Low_stocks_alerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dashboard_panel
            // 
            dashboard_panel.BackColor = SystemColors.ButtonHighlight;
            dashboard_panel.Controls.Add(usr_avatar);
            dashboard_panel.Controls.Add(role_label);
            dashboard_panel.Controls.Add(date_label);
            dashboard_panel.Location = new Point(-2, -4);
            dashboard_panel.Margin = new Padding(3, 4, 3, 4);
            dashboard_panel.Name = "dashboard_panel";
            dashboard_panel.Size = new Size(1453, 69);
            dashboard_panel.TabIndex = 0;
            // 
            // usr_avatar
            // 
            usr_avatar.BackColor = SystemColors.ControlDark;
            usr_avatar.BackgroundImageLayout = ImageLayout.None;
            usr_avatar.Location = new Point(983, 11);
            usr_avatar.Margin = new Padding(3, 4, 3, 4);
            usr_avatar.Name = "usr_avatar";
            usr_avatar.Size = new Size(43, 51);
            usr_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            usr_avatar.TabIndex = 2;
            usr_avatar.TabStop = false;
            // 
            // role_label
            // 
            role_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            role_label.Location = new Point(870, 29);
            role_label.Name = "role_label";
            role_label.Size = new Size(229, 20);
            role_label.TabIndex = 1;
            role_label.Text = "--ROLE--";
            role_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.Location = new Point(16, 29);
            date_label.Name = "date_label";
            date_label.Size = new Size(126, 20);
            date_label.TabIndex = 0;
            date_label.Text = "DATE GOES HERE";
            // 
            // sales_panel
            // 
            sales_panel.BackColor = SystemColors.Info;
            sales_panel.Controls.Add(pictureBox2);
            sales_panel.Controls.Add(today_label);
            sales_panel.Controls.Add(today_sales);
            sales_panel.Location = new Point(255, 155);
            sales_panel.Margin = new Padding(3, 4, 3, 4);
            sales_panel.Name = "sales_panel";
            sales_panel.Size = new Size(183, 176);
            sales_panel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Maroon;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 59);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // today_label
            // 
            today_label.AutoSize = true;
            today_label.BackColor = SystemColors.Info;
            today_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            today_label.ForeColor = Color.Black;
            today_label.Location = new Point(80, 77);
            today_label.Name = "today_label";
            today_label.Size = new Size(70, 30);
            today_label.TabIndex = 1;
            today_label.Text = "label1";
            // 
            // today_sales
            // 
            today_sales.AutoSize = true;
            today_sales.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            today_sales.ForeColor = Color.Black;
            today_sales.Location = new Point(14, 13);
            today_sales.Name = "today_sales";
            today_sales.Size = new Size(122, 25);
            today_sales.TabIndex = 0;
            today_sales.Text = "Today's Sales";
            // 
            // liters_panel
            // 
            liters_panel.BackColor = SystemColors.Info;
            liters_panel.Controls.Add(pictureBox3);
            liters_panel.Controls.Add(litersdispensed_label);
            liters_panel.Controls.Add(liters_txt);
            liters_panel.Location = new Point(459, 155);
            liters_panel.Margin = new Padding(3, 4, 3, 4);
            liters_panel.Name = "liters_panel";
            liters_panel.Size = new Size(187, 176);
            liters_panel.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Maroon;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 59);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 68;
            pictureBox3.TabStop = false;
            // 
            // litersdispensed_label
            // 
            litersdispensed_label.AutoSize = true;
            litersdispensed_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            litersdispensed_label.ForeColor = Color.Black;
            litersdispensed_label.Location = new Point(79, 77);
            litersdispensed_label.Name = "litersdispensed_label";
            litersdispensed_label.Size = new Size(73, 30);
            litersdispensed_label.TabIndex = 2;
            litersdispensed_label.Text = "label2";
            // 
            // liters_txt
            // 
            liters_txt.AutoSize = true;
            liters_txt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            liters_txt.ForeColor = Color.Black;
            liters_txt.Location = new Point(8, 11);
            liters_txt.Name = "liters_txt";
            liters_txt.Size = new Size(148, 25);
            liters_txt.TabIndex = 1;
            liters_txt.Text = "Liters dispensed";
            // 
            // transaction_panel
            // 
            transaction_panel.BackColor = SystemColors.Info;
            transaction_panel.Controls.Add(pictureBox4);
            transaction_panel.Controls.Add(transaction_label);
            transaction_panel.Controls.Add(transaction_txt);
            transaction_panel.Location = new Point(666, 155);
            transaction_panel.Margin = new Padding(3, 4, 3, 4);
            transaction_panel.Name = "transaction_panel";
            transaction_panel.Size = new Size(187, 176);
            transaction_panel.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Maroon;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 59);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 68);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 69;
            pictureBox4.TabStop = false;
            // 
            // transaction_label
            // 
            transaction_label.AutoSize = true;
            transaction_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction_label.ForeColor = Color.Black;
            transaction_label.Location = new Point(82, 77);
            transaction_label.Name = "transaction_label";
            transaction_label.Size = new Size(73, 30);
            transaction_label.TabIndex = 3;
            transaction_label.Text = "label3";
            // 
            // transaction_txt
            // 
            transaction_txt.AutoSize = true;
            transaction_txt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            transaction_txt.ForeColor = Color.Black;
            transaction_txt.Location = new Point(9, 11);
            transaction_txt.Name = "transaction_txt";
            transaction_txt.Size = new Size(117, 25);
            transaction_txt.TabIndex = 2;
            transaction_txt.Text = "Transactions";
            // 
            // Low_stocks_alerts
            // 
            Low_stocks_alerts.BackColor = SystemColors.Info;
            Low_stocks_alerts.Controls.Add(pictureBox5);
            Low_stocks_alerts.Controls.Add(stocks_label);
            Low_stocks_alerts.Controls.Add(low_stox_txt);
            Low_stocks_alerts.Location = new Point(878, 155);
            Low_stocks_alerts.Margin = new Padding(3, 4, 3, 4);
            Low_stocks_alerts.Name = "Low_stocks_alerts";
            Low_stocks_alerts.Size = new Size(187, 176);
            Low_stocks_alerts.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Maroon;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 59);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 68);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 70;
            pictureBox5.TabStop = false;
            // 
            // stocks_label
            // 
            stocks_label.AutoSize = true;
            stocks_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stocks_label.ForeColor = Color.Black;
            stocks_label.Location = new Point(82, 77);
            stocks_label.Name = "stocks_label";
            stocks_label.Size = new Size(74, 30);
            stocks_label.TabIndex = 4;
            stocks_label.Text = "label4";
            // 
            // low_stox_txt
            // 
            low_stox_txt.AutoSize = true;
            low_stox_txt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            low_stox_txt.ForeColor = Color.Black;
            low_stox_txt.Location = new Point(9, 11);
            low_stox_txt.Name = "low_stox_txt";
            low_stox_txt.Size = new Size(105, 25);
            low_stox_txt.TabIndex = 3;
            low_stox_txt.Text = "Low Stocks";
            // 
            // inventory_pnel
            // 
            inventory_pnel.BackColor = SystemColors.ControlLightLight;
            inventory_pnel.Location = new Point(255, 365);
            inventory_pnel.Margin = new Padding(3, 4, 3, 4);
            inventory_pnel.Name = "inventory_pnel";
            inventory_pnel.Size = new Size(393, 607);
            inventory_pnel.TabIndex = 6;
            // 
            // recent_transaction_panel
            // 
            recent_transaction_panel.BackColor = SystemColors.ControlLightLight;
            recent_transaction_panel.Location = new Point(666, 365);
            recent_transaction_panel.Margin = new Padding(3, 4, 3, 4);
            recent_transaction_panel.Name = "recent_transaction_panel";
            recent_transaction_panel.Size = new Size(399, 607);
            recent_transaction_panel.TabIndex = 7;
            // 
            // Dashboard
            // 
            AccessibleRole = AccessibleRole.SplitButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1119, 1024);
            Controls.Add(recent_transaction_panel);
            Controls.Add(inventory_pnel);
            Controls.Add(Low_stocks_alerts);
            Controls.Add(transaction_panel);
            Controls.Add(liters_panel);
            Controls.Add(sales_panel);
            Controls.Add(dashboard_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FuelTrack — Dashboard";
            Load += Dashboard_Load;
            dashboard_panel.ResumeLayout(false);
            dashboard_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).EndInit();
            sales_panel.ResumeLayout(false);
            sales_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            liters_panel.ResumeLayout(false);
            liters_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            transaction_panel.ResumeLayout(false);
            transaction_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Low_stocks_alerts.ResumeLayout(false);
            Low_stocks_alerts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboard_panel;
        private Label date_label;
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
        private Label today_label;
        private Label litersdispensed_label;
        private Label transaction_label;
        private Label stocks_label;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}