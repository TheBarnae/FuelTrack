namespace FuelTrack
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            Employees_panel = new Panel();
            alert_label = new Label();
            usr_avatar = new PictureBox();
            role_label = new Label();
            date_label = new Label();
            Employees_label = new Label();
            addemployee_button = new Button();
            totalemployee_dataGridView = new DataGridView();
            employeedata_dataGridView = new DataGridView();
            addemployee_dataGridView = new DataGridView();
            add_label = new Label();
            fullname_label = new Label();
            fullname_textBox = new TextBox();
            username_label = new Label();
            username_textBox = new TextBox();
            shiftassignment_label = new Label();
            rol_label = new Label();
            password_label = new Label();
            password_textBox = new TextBox();
            contactnumber_label = new Label();
            contactnumber_textBox = new TextBox();
            shiftassignment_comboBox = new ComboBox();
            rol_comboBox = new ComboBox();
            saveemployee_button = new Button();
            clear_button = new Button();
            delete_button = new Button();
            addEmployee = new PictureBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            total_emp_label = new Label();
            onDuty_emp_lbl = new Label();
            offDuty_emp_lbl = new Label();
            total_emp_db_label = new Label();
            on_duty_db_lbl = new Label();
            off_duty_db_lbl = new Label();
            sts_comboBox = new ComboBox();
            status_comboBox = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Employees_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalemployee_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeedata_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addemployee_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Employees_panel
            // 
            Employees_panel.BackColor = SystemColors.ButtonHighlight;
            Employees_panel.Controls.Add(alert_label);
            Employees_panel.Controls.Add(usr_avatar);
            Employees_panel.Controls.Add(role_label);
            Employees_panel.Controls.Add(date_label);
            Employees_panel.Location = new Point(-2, -4);
            Employees_panel.Margin = new Padding(3, 4, 3, 4);
            Employees_panel.Name = "Employees_panel";
            Employees_panel.Size = new Size(1453, 69);
            Employees_panel.TabIndex = 3;
            // 
            // alert_label
            // 
            alert_label.AutoSize = true;
            alert_label.Location = new Point(891, 29);
            alert_label.Name = "alert_label";
            alert_label.Size = new Size(82, 20);
            alert_label.TabIndex = 3;
            alert_label.Text = "--ALERTS--";
            // 
            // usr_avatar
            // 
            usr_avatar.BackColor = SystemColors.ControlDark;
            usr_avatar.BackgroundImageLayout = ImageLayout.None;
            usr_avatar.Location = new Point(978, 12);
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
            role_label.Location = new Point(1029, 29);
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
            // Employees_label
            // 
            Employees_label.AutoSize = true;
            Employees_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            Employees_label.Location = new Point(238, 137);
            Employees_label.Name = "Employees_label";
            Employees_label.Size = new Size(148, 37);
            Employees_label.TabIndex = 4;
            Employees_label.Text = "Employees";
            // 
            // addemployee_button
            // 
            addemployee_button.BackColor = Color.FromArgb(221, 152, 3);
            addemployee_button.FlatStyle = FlatStyle.Popup;
            addemployee_button.ForeColor = SystemColors.ControlLightLight;
            addemployee_button.Location = new Point(928, 133);
            addemployee_button.Margin = new Padding(3, 4, 3, 4);
            addemployee_button.Name = "addemployee_button";
            addemployee_button.Size = new Size(131, 44);
            addemployee_button.TabIndex = 8;
            addemployee_button.Text = "+ Add Employee";
            addemployee_button.UseVisualStyleBackColor = false;
            // 
            // totalemployee_dataGridView
            // 
            totalemployee_dataGridView.BackgroundColor = SystemColors.Info;
            totalemployee_dataGridView.BorderStyle = BorderStyle.None;
            totalemployee_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            totalemployee_dataGridView.Location = new Point(238, 185);
            totalemployee_dataGridView.Margin = new Padding(3, 4, 3, 4);
            totalemployee_dataGridView.Name = "totalemployee_dataGridView";
            totalemployee_dataGridView.RowHeadersWidth = 51;
            totalemployee_dataGridView.Size = new Size(262, 131);
            totalemployee_dataGridView.TabIndex = 9;
            totalemployee_dataGridView.CellContentClick += totalemployee_dataGridView_CellContentClick_1;
            // 
            // employeedata_dataGridView
            // 
            employeedata_dataGridView.BackgroundColor = Color.White;
            employeedata_dataGridView.BorderStyle = BorderStyle.None;
            employeedata_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            employeedata_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeedata_dataGridView.Location = new Point(238, 347);
            employeedata_dataGridView.Margin = new Padding(3, 4, 3, 4);
            employeedata_dataGridView.Name = "employeedata_dataGridView";
            employeedata_dataGridView.RowHeadersWidth = 51;
            employeedata_dataGridView.Size = new Size(823, 208);
            employeedata_dataGridView.TabIndex = 12;
            // 
            // addemployee_dataGridView
            // 
            addemployee_dataGridView.BackgroundColor = Color.White;
            addemployee_dataGridView.BorderStyle = BorderStyle.None;
            addemployee_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            addemployee_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addemployee_dataGridView.Location = new Point(238, 583);
            addemployee_dataGridView.Margin = new Padding(3, 4, 3, 4);
            addemployee_dataGridView.Name = "addemployee_dataGridView";
            addemployee_dataGridView.RowHeadersWidth = 51;
            addemployee_dataGridView.Size = new Size(823, 401);
            addemployee_dataGridView.TabIndex = 13;
            // 
            // add_label
            // 
            add_label.AutoSize = true;
            add_label.BackColor = SystemColors.ControlLightLight;
            add_label.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            add_label.Location = new Point(305, 612);
            add_label.Name = "add_label";
            add_label.Size = new Size(190, 23);
            add_label.TabIndex = 14;
            add_label.Text = "ADD /  EDIT EMPLOYEE";
            // 
            // fullname_label
            // 
            fullname_label.AutoSize = true;
            fullname_label.BackColor = SystemColors.ControlLightLight;
            fullname_label.Location = new Point(293, 661);
            fullname_label.Name = "fullname_label";
            fullname_label.Size = new Size(76, 20);
            fullname_label.TabIndex = 15;
            fullname_label.Text = "Full Name";
            // 
            // fullname_textBox
            // 
            fullname_textBox.Location = new Point(291, 685);
            fullname_textBox.Margin = new Padding(3, 4, 3, 4);
            fullname_textBox.Name = "fullname_textBox";
            fullname_textBox.Size = new Size(305, 27);
            fullname_textBox.TabIndex = 16;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BackColor = SystemColors.ControlLightLight;
            username_label.Location = new Point(294, 741);
            username_label.Name = "username_label";
            username_label.Size = new Size(75, 20);
            username_label.TabIndex = 17;
            username_label.Text = "Username";
            // 
            // username_textBox
            // 
            username_textBox.Location = new Point(291, 767);
            username_textBox.Margin = new Padding(3, 4, 3, 4);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(303, 27);
            username_textBox.TabIndex = 18;
            // 
            // shiftassignment_label
            // 
            shiftassignment_label.AutoSize = true;
            shiftassignment_label.BackColor = SystemColors.ControlLightLight;
            shiftassignment_label.Location = new Point(293, 824);
            shiftassignment_label.Name = "shiftassignment_label";
            shiftassignment_label.Size = new Size(120, 20);
            shiftassignment_label.TabIndex = 19;
            shiftassignment_label.Text = "Shift Assignment";
            // 
            // rol_label
            // 
            rol_label.AutoSize = true;
            rol_label.BackColor = SystemColors.ControlLightLight;
            rol_label.Location = new Point(669, 660);
            rol_label.Name = "rol_label";
            rol_label.Size = new Size(39, 20);
            rol_label.TabIndex = 21;
            rol_label.Text = "Role";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.BackColor = SystemColors.ControlLightLight;
            password_label.Location = new Point(667, 741);
            password_label.Name = "password_label";
            password_label.Size = new Size(70, 20);
            password_label.TabIndex = 23;
            password_label.Text = "Password";
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(669, 767);
            password_textBox.Margin = new Padding(3, 4, 3, 4);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(330, 27);
            password_textBox.TabIndex = 24;
            // 
            // contactnumber_label
            // 
            contactnumber_label.AutoSize = true;
            contactnumber_label.BackColor = SystemColors.ControlLightLight;
            contactnumber_label.Location = new Point(669, 824);
            contactnumber_label.Name = "contactnumber_label";
            contactnumber_label.Size = new Size(118, 20);
            contactnumber_label.TabIndex = 25;
            contactnumber_label.Text = "Contact Number";
            // 
            // contactnumber_textBox
            // 
            contactnumber_textBox.Location = new Point(669, 851);
            contactnumber_textBox.Margin = new Padding(3, 4, 3, 4);
            contactnumber_textBox.Name = "contactnumber_textBox";
            contactnumber_textBox.Size = new Size(330, 27);
            contactnumber_textBox.TabIndex = 26;
            // 
            // shiftassignment_comboBox
            // 
            shiftassignment_comboBox.FormattingEnabled = true;
            shiftassignment_comboBox.Location = new Point(293, 851);
            shiftassignment_comboBox.Margin = new Padding(3, 4, 3, 4);
            shiftassignment_comboBox.Name = "shiftassignment_comboBox";
            shiftassignment_comboBox.Size = new Size(300, 28);
            shiftassignment_comboBox.TabIndex = 27;
            // 
            // rol_comboBox
            // 
            rol_comboBox.FormattingEnabled = true;
            rol_comboBox.Location = new Point(667, 683);
            rol_comboBox.Margin = new Padding(3, 4, 3, 4);
            rol_comboBox.Name = "rol_comboBox";
            rol_comboBox.Size = new Size(331, 28);
            rol_comboBox.TabIndex = 28;
            // 
            // saveemployee_button
            // 
            saveemployee_button.BackColor = Color.FromArgb(243, 113, 0);
            saveemployee_button.FlatStyle = FlatStyle.Popup;
            saveemployee_button.ForeColor = Color.White;
            saveemployee_button.Location = new Point(672, 911);
            saveemployee_button.Margin = new Padding(3, 4, 3, 4);
            saveemployee_button.Name = "saveemployee_button";
            saveemployee_button.Size = new Size(125, 43);
            saveemployee_button.TabIndex = 29;
            saveemployee_button.Text = "Save Employee";
            saveemployee_button.UseVisualStyleBackColor = false;
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.FromArgb(221, 152, 3);
            clear_button.FlatStyle = FlatStyle.Popup;
            clear_button.ForeColor = Color.White;
            clear_button.Location = new Point(810, 911);
            clear_button.Margin = new Padding(3, 4, 3, 4);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(86, 43);
            clear_button.TabIndex = 30;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = false;
            // 
            // delete_button
            // 
            delete_button.BackColor = Color.FromArgb(192, 0, 0);
            delete_button.FlatStyle = FlatStyle.Popup;
            delete_button.ForeColor = Color.White;
            delete_button.Location = new Point(912, 911);
            delete_button.Margin = new Padding(3, 4, 3, 4);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(86, 43);
            delete_button.TabIndex = 31;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = false;
            // 
            // addEmployee
            // 
            addEmployee.BackColor = SystemColors.ControlLightLight;
            addEmployee.Image = (Image)resources.GetObject("addEmployee.Image");
            addEmployee.Location = new Point(262, 603);
            addEmployee.Margin = new Padding(3, 4, 3, 4);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(39, 40);
            addEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            addEmployee.TabIndex = 57;
            addEmployee.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(517, 185);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(262, 131);
            dataGridView1.TabIndex = 58;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(798, 185);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(262, 131);
            dataGridView2.TabIndex = 59;
            // 
            // total_emp_label
            // 
            total_emp_label.AutoSize = true;
            total_emp_label.BackColor = SystemColors.Info;
            total_emp_label.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            total_emp_label.Location = new Point(243, 193);
            total_emp_label.Name = "total_emp_label";
            total_emp_label.Size = new Size(150, 25);
            total_emp_label.TabIndex = 60;
            total_emp_label.Text = "Total Employees";
            total_emp_label.Click += total_emp_label_Click;
            // 
            // onDuty_emp_lbl
            // 
            onDuty_emp_lbl.AutoSize = true;
            onDuty_emp_lbl.BackColor = SystemColors.Info;
            onDuty_emp_lbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            onDuty_emp_lbl.Location = new Point(522, 191);
            onDuty_emp_lbl.Name = "onDuty_emp_lbl";
            onDuty_emp_lbl.Size = new Size(84, 25);
            onDuty_emp_lbl.TabIndex = 61;
            onDuty_emp_lbl.Text = "On Duty";
            onDuty_emp_lbl.Click += onDuty_emp_lbl_Click;
            // 
            // offDuty_emp_lbl
            // 
            offDuty_emp_lbl.AutoSize = true;
            offDuty_emp_lbl.BackColor = SystemColors.Info;
            offDuty_emp_lbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            offDuty_emp_lbl.Location = new Point(803, 189);
            offDuty_emp_lbl.Name = "offDuty_emp_lbl";
            offDuty_emp_lbl.Size = new Size(84, 25);
            offDuty_emp_lbl.TabIndex = 62;
            offDuty_emp_lbl.Text = "Off duty";
            offDuty_emp_lbl.Click += offDuty_emp_lbl_Click;
            // 
            // total_emp_db_label
            // 
            total_emp_db_label.BackColor = SystemColors.Info;
            total_emp_db_label.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            total_emp_db_label.ForeColor = Color.Black;
            total_emp_db_label.Location = new Point(323, 233);
            total_emp_db_label.Name = "total_emp_db_label";
            total_emp_db_label.Size = new Size(172, 53);
            total_emp_db_label.TabIndex = 63;
            total_emp_db_label.Text = "Total employee Here";
            total_emp_db_label.Click += total_emp_db_label_Click;
            // 
            // on_duty_db_lbl
            // 
            on_duty_db_lbl.BackColor = SystemColors.Info;
            on_duty_db_lbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            on_duty_db_lbl.ForeColor = Color.Black;
            on_duty_db_lbl.Location = new Point(603, 233);
            on_duty_db_lbl.Name = "on_duty_db_lbl";
            on_duty_db_lbl.Size = new Size(151, 53);
            on_duty_db_lbl.TabIndex = 64;
            on_duty_db_lbl.Text = "On Duty Here";
            on_duty_db_lbl.Click += on_duty_db_lbl_Click;
            // 
            // off_duty_db_lbl
            // 
            off_duty_db_lbl.BackColor = SystemColors.Info;
            off_duty_db_lbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            off_duty_db_lbl.ForeColor = Color.Black;
            off_duty_db_lbl.Location = new Point(881, 227);
            off_duty_db_lbl.Name = "off_duty_db_lbl";
            off_duty_db_lbl.Size = new Size(156, 53);
            off_duty_db_lbl.TabIndex = 65;
            off_duty_db_lbl.Text = "Off Duty Here";
            off_duty_db_lbl.Click += off_duty_db_lbl_Click;
            // 
            // sts_comboBox
            // 
            sts_comboBox.FormattingEnabled = true;
            sts_comboBox.Location = new Point(291, 923);
            sts_comboBox.Margin = new Padding(3, 4, 3, 4);
            sts_comboBox.Name = "sts_comboBox";
            sts_comboBox.Size = new Size(301, 28);
            sts_comboBox.TabIndex = 66;
            sts_comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // status_comboBox
            // 
            status_comboBox.AutoSize = true;
            status_comboBox.BackColor = SystemColors.ControlLightLight;
            status_comboBox.Location = new Point(291, 899);
            status_comboBox.Name = "status_comboBox";
            status_comboBox.Size = new Size(49, 20);
            status_comboBox.TabIndex = 67;
            status_comboBox.Text = "Status";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(533, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 69;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(810, 227);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 70;
            pictureBox3.TabStop = false;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 1024);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(status_comboBox);
            Controls.Add(sts_comboBox);
            Controls.Add(off_duty_db_lbl);
            Controls.Add(on_duty_db_lbl);
            Controls.Add(total_emp_db_label);
            Controls.Add(offDuty_emp_lbl);
            Controls.Add(onDuty_emp_lbl);
            Controls.Add(total_emp_label);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(addEmployee);
            Controls.Add(delete_button);
            Controls.Add(clear_button);
            Controls.Add(saveemployee_button);
            Controls.Add(rol_comboBox);
            Controls.Add(shiftassignment_comboBox);
            Controls.Add(contactnumber_textBox);
            Controls.Add(contactnumber_label);
            Controls.Add(password_textBox);
            Controls.Add(password_label);
            Controls.Add(rol_label);
            Controls.Add(shiftassignment_label);
            Controls.Add(username_textBox);
            Controls.Add(username_label);
            Controls.Add(fullname_textBox);
            Controls.Add(fullname_label);
            Controls.Add(add_label);
            Controls.Add(addemployee_dataGridView);
            Controls.Add(employeedata_dataGridView);
            Controls.Add(totalemployee_dataGridView);
            Controls.Add(addemployee_button);
            Controls.Add(Employees_label);
            Controls.Add(Employees_panel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FuelTrack — Employees";
            Employees_panel.ResumeLayout(false);
            Employees_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usr_avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalemployee_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeedata_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)addemployee_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)addEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Employees_panel;
        private Label alert_label;
        private PictureBox usr_avatar;
        private Label role_label;
        private Label date_label;
        private Label Employees_label;
        private Button addemployee_button;
        private DataGridView totalemployee_dataGridView;
        private DataGridView employeedata_dataGridView;
        private DataGridView addemployee_dataGridView;
        private Label add_label;
        private Label fullname_label;
        private TextBox fullname_textBox;
        private Label username_label;
        private TextBox username_textBox;
        private Label shiftassignment_label;
        private Label rol_label;
        private Label password_label;
        private TextBox password_textBox;
        private Label contactnumber_label;
        private TextBox contactnumber_textBox;
        private ComboBox shiftassignment_comboBox;
        private ComboBox rol_comboBox;
        private Button saveemployee_button;
        private Button clear_button;
        private Button delete_button;
        private PictureBox addEmployee;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label total_emp_label;
        private Label onDuty_emp_lbl;
        private Label offDuty_emp_lbl;
        private Label total_emp_db_label;
        private Label on_duty_db_lbl;
        private Label off_duty_db_lbl;
        private ComboBox sts_comboBox;
        private Label status_comboBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}