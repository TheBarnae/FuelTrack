namespace FuelTrack
{
    partial class Audit_Trail
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
            AuditTrail_panel = new Panel();
            alert_label = new Label();
            usr_avatar = new PictureBox();
            role_label = new Label();
            date_label = new Label();
            auditTrail_label = new Label();
            actiontoday_dataGridView = new DataGridView();
            logintoday_dataGridView = new DataGridView();
            flaggedactions_dataGridView = new DataGridView();
            dataRange_dataGridView = new DataGridView();
            auditTrailData_dataGridView = new DataGridView();
            dateRange_label = new Label();
            dateRange_dateTimePicker = new DateTimePicker();
            user_label = new Label();
            user_comboBox = new ComboBox();
            module_label = new Label();
            module_comboBox = new ComboBox();
            actionType_label = new Label();
            actionType_comboBox = new ComboBox();
            filter_button = new Button();
            AuditTrail_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actiontoday_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logintoday_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flaggedactions_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataRange_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)auditTrailData_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // AuditTrail_panel
            // 
            AuditTrail_panel.BackColor = SystemColors.ButtonHighlight;
            AuditTrail_panel.Controls.Add(alert_label);
            AuditTrail_panel.Controls.Add(usr_avatar);
            AuditTrail_panel.Controls.Add(role_label);
            AuditTrail_panel.Controls.Add(date_label);
            AuditTrail_panel.Location = new Point(-2, -4);
            AuditTrail_panel.Margin = new Padding(3, 4, 3, 4);
            AuditTrail_panel.Name = "AuditTrail_panel";
            AuditTrail_panel.Size = new Size(1453, 69);
            AuditTrail_panel.TabIndex = 14;
            // 
            // alert_label
            // 
            alert_label.AutoSize = true;
            alert_label.Location = new Point(901, 29);
            alert_label.Name = "alert_label";
            alert_label.Size = new Size(82, 20);
            alert_label.TabIndex = 3;
            alert_label.Text = "--ALERTS--";
            // 
            // usr_avatar
            // 
            usr_avatar.BackColor = SystemColors.ControlDark;
            usr_avatar.BackgroundImageLayout = ImageLayout.None;
            usr_avatar.Location = new Point(982, 15);
            usr_avatar.Margin = new Padding(3, 4, 3, 4);
            usr_avatar.Name = "usr_avatar";
            usr_avatar.Size = new Size(43, 51);
            usr_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            usr_avatar.TabIndex = 2;
            usr_avatar.TabStop = false;
            // 
            // role_label
            // 
            role_label.AutoSize = true;
            role_label.Location = new Point(1032, 29);
            role_label.Name = "role_label";
            role_label.Size = new Size(68, 20);
            role_label.TabIndex = 1;
            role_label.Text = "--ROLE--";
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
            // auditTrail_label
            // 
            auditTrail_label.AutoSize = true;
            auditTrail_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            auditTrail_label.Location = new Point(239, 137);
            auditTrail_label.Name = "auditTrail_label";
            auditTrail_label.Size = new Size(142, 37);
            auditTrail_label.TabIndex = 15;
            auditTrail_label.Text = "Audit Trail";
            // 
            // actiontoday_dataGridView
            // 
            actiontoday_dataGridView.BackgroundColor = SystemColors.Info;
            actiontoday_dataGridView.BorderStyle = BorderStyle.None;
            actiontoday_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            actiontoday_dataGridView.Location = new Point(239, 185);
            actiontoday_dataGridView.Margin = new Padding(3, 4, 3, 4);
            actiontoday_dataGridView.Name = "actiontoday_dataGridView";
            actiontoday_dataGridView.RowHeadersWidth = 51;
            actiontoday_dataGridView.Size = new Size(262, 131);
            actiontoday_dataGridView.TabIndex = 17;
            // 
            // logintoday_dataGridView
            // 
            logintoday_dataGridView.BackgroundColor = SystemColors.Info;
            logintoday_dataGridView.BorderStyle = BorderStyle.None;
            logintoday_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            logintoday_dataGridView.Location = new Point(527, 185);
            logintoday_dataGridView.Margin = new Padding(3, 4, 3, 4);
            logintoday_dataGridView.Name = "logintoday_dataGridView";
            logintoday_dataGridView.RowHeadersWidth = 51;
            logintoday_dataGridView.Size = new Size(262, 131);
            logintoday_dataGridView.TabIndex = 18;
            // 
            // flaggedactions_dataGridView
            // 
            flaggedactions_dataGridView.BackgroundColor = SystemColors.Info;
            flaggedactions_dataGridView.BorderStyle = BorderStyle.None;
            flaggedactions_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            flaggedactions_dataGridView.Location = new Point(816, 185);
            flaggedactions_dataGridView.Margin = new Padding(3, 4, 3, 4);
            flaggedactions_dataGridView.Name = "flaggedactions_dataGridView";
            flaggedactions_dataGridView.RowHeadersWidth = 51;
            flaggedactions_dataGridView.Size = new Size(262, 131);
            flaggedactions_dataGridView.TabIndex = 19;
            // 
            // dataRange_dataGridView
            // 
            dataRange_dataGridView.BackgroundColor = SystemColors.ControlLightLight;
            dataRange_dataGridView.BorderStyle = BorderStyle.None;
            dataRange_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataRange_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRange_dataGridView.Location = new Point(239, 345);
            dataRange_dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataRange_dataGridView.Name = "dataRange_dataGridView";
            dataRange_dataGridView.RowHeadersWidth = 51;
            dataRange_dataGridView.Size = new Size(839, 261);
            dataRange_dataGridView.TabIndex = 20;
            // 
            // auditTrailData_dataGridView
            // 
            auditTrailData_dataGridView.BackgroundColor = SystemColors.ControlLightLight;
            auditTrailData_dataGridView.BorderStyle = BorderStyle.None;
            auditTrailData_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            auditTrailData_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            auditTrailData_dataGridView.Location = new Point(239, 635);
            auditTrailData_dataGridView.Margin = new Padding(3, 4, 3, 4);
            auditTrailData_dataGridView.Name = "auditTrailData_dataGridView";
            auditTrailData_dataGridView.RowHeadersWidth = 51;
            auditTrailData_dataGridView.Size = new Size(839, 345);
            auditTrailData_dataGridView.TabIndex = 21;
            // 
            // dateRange_label
            // 
            dateRange_label.AutoSize = true;
            dateRange_label.BackColor = SystemColors.ControlLightLight;
            dateRange_label.Location = new Point(256, 379);
            dateRange_label.Name = "dateRange_label";
            dateRange_label.Size = new Size(87, 20);
            dateRange_label.TabIndex = 22;
            dateRange_label.Text = "Date Range";
            // 
            // dateRange_dateTimePicker
            // 
            dateRange_dateTimePicker.Location = new Point(256, 405);
            dateRange_dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateRange_dateTimePicker.Name = "dateRange_dateTimePicker";
            dateRange_dateTimePicker.Size = new Size(239, 27);
            dateRange_dateTimePicker.TabIndex = 23;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.BackColor = SystemColors.ControlLightLight;
            user_label.Location = new Point(527, 379);
            user_label.Name = "user_label";
            user_label.Size = new Size(38, 20);
            user_label.TabIndex = 24;
            user_label.Text = "User";
            // 
            // user_comboBox
            // 
            user_comboBox.FormattingEnabled = true;
            user_comboBox.Location = new Point(527, 405);
            user_comboBox.Margin = new Padding(3, 4, 3, 4);
            user_comboBox.Name = "user_comboBox";
            user_comboBox.Size = new Size(215, 28);
            user_comboBox.TabIndex = 25;
            // 
            // module_label
            // 
            module_label.AutoSize = true;
            module_label.BackColor = SystemColors.ControlLightLight;
            module_label.Location = new Point(790, 381);
            module_label.Name = "module_label";
            module_label.Size = new Size(60, 20);
            module_label.TabIndex = 26;
            module_label.Text = "Module";
            // 
            // module_comboBox
            // 
            module_comboBox.FormattingEnabled = true;
            module_comboBox.Location = new Point(790, 405);
            module_comboBox.Margin = new Padding(3, 4, 3, 4);
            module_comboBox.Name = "module_comboBox";
            module_comboBox.Size = new Size(207, 28);
            module_comboBox.TabIndex = 27;
            // 
            // actionType_label
            // 
            actionType_label.AutoSize = true;
            actionType_label.BackColor = SystemColors.ControlLightLight;
            actionType_label.Location = new Point(264, 480);
            actionType_label.Name = "actionType_label";
            actionType_label.Size = new Size(87, 20);
            actionType_label.TabIndex = 28;
            actionType_label.Text = "Action Type";
            // 
            // actionType_comboBox
            // 
            actionType_comboBox.FormattingEnabled = true;
            actionType_comboBox.Location = new Point(264, 511);
            actionType_comboBox.Margin = new Padding(3, 4, 3, 4);
            actionType_comboBox.Name = "actionType_comboBox";
            actionType_comboBox.Size = new Size(231, 28);
            actionType_comboBox.TabIndex = 29;
            // 
            // filter_button
            // 
            filter_button.BackColor = Color.FromArgb(243, 113, 0);
            filter_button.FlatStyle = FlatStyle.Popup;
            filter_button.ForeColor = SystemColors.ControlLightLight;
            filter_button.Location = new Point(514, 511);
            filter_button.Margin = new Padding(3, 4, 3, 4);
            filter_button.Name = "filter_button";
            filter_button.Size = new Size(90, 35);
            filter_button.TabIndex = 30;
            filter_button.Text = "Filter";
            filter_button.UseVisualStyleBackColor = false;
            filter_button.Click += filter_button_Click;
            // 
            // Audit_Trail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 1024);
            Controls.Add(filter_button);
            Controls.Add(actionType_comboBox);
            Controls.Add(actionType_label);
            Controls.Add(module_comboBox);
            Controls.Add(module_label);
            Controls.Add(user_comboBox);
            Controls.Add(user_label);
            Controls.Add(dateRange_dateTimePicker);
            Controls.Add(dateRange_label);
            Controls.Add(auditTrailData_dataGridView);
            Controls.Add(dataRange_dataGridView);
            Controls.Add(flaggedactions_dataGridView);
            Controls.Add(logintoday_dataGridView);
            Controls.Add(actiontoday_dataGridView);
            Controls.Add(auditTrail_label);
            Controls.Add(AuditTrail_panel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Audit_Trail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FuelTrack — Audit_Trail";
            Load += Audit_Trail_Load;
            AuditTrail_panel.ResumeLayout(false);
            AuditTrail_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)actiontoday_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)logintoday_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)flaggedactions_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataRange_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)auditTrailData_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel AuditTrail_panel;
        private Label alert_label;
        private PictureBox usr_avatar;
        private Label role_label;
        private Label date_label;
        private Label auditTrail_label;
        private DataGridView actiontoday_dataGridView;
        private DataGridView logintoday_dataGridView;
        private DataGridView flaggedactions_dataGridView;
        private DataGridView dataRange_dataGridView;
        private DataGridView auditTrailData_dataGridView;
        private Label dateRange_label;
        private DateTimePicker dateRange_dateTimePicker;
        private Label user_label;
        private ComboBox user_comboBox;
        private Label module_label;
        private ComboBox module_comboBox;
        private Label actionType_label;
        private ComboBox actionType_comboBox;
        private Button filter_button;
    }
}