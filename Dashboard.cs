using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;


namespace FuelTrack
{
    public partial class Dashboard : Form
    {
        private Color _logoutOriginalColor;

        public Dashboard()
        {
            InitializeComponent();
            _logoutOriginalColor = logout_btn.BackColor;
            MakeCircular(usr_avatar);
            richTextBox1.Text = "FuelTrack";
            richTextBox1.Select(0, 4); // Fuel
            richTextBox1.SelectionColor = Color.Aqua;
            richTextBox1.Select(4, 5); // Track
            richTextBox1.SelectionColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ReadOnly = true;
        }

        private void MakeCircular(PictureBox pic)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pic.Width, pic.Height);
            pic.Region = new Region(path);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UIHelper.setDateLabel(date_label);
            UIHelper.SetButtonColors(dashboard_btn);

            // Set the dashboard as the active one
            UIHelper.SetButtonActive(dashboard_btn, true);

            // Set rounded corners for panels in dashboard
            UIHelper.SetRadius(sales_panel, 12);
            UIHelper.SetRadius(liters_panel, 12);
            UIHelper.SetRadius(transaction_panel, 12);
            UIHelper.SetRadius(Low_stocks_alerts, 12);
            UIHelper.SetRadius(inventory_pnel, 12);
            UIHelper.SetRadius(recent_transaction_panel, 12);


        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
