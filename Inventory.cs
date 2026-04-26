using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static FuelTrack.UIHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelTrack
{
    public partial class Inventory : Form
    {
        private Color _logoutOriginalColor;
        public Inventory()
        {
            InitializeComponent();
            UIHelper.MakeCircular(usr_avatar);
            UIHelper.StyleFuelTrackTitle(richTextBox1);
        }

        private void menubar_dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            UIHelper.setDateLabel(date_label);
            UIHelper.SetButtonActive(inv_btn, true);
            UIHelper.DisableCloseButton(this);

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            Navigator.Switch(this, new Dashboard());
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Navigator.Switch(this, new Login());
        }

        private void inv_btn_Click(object sender, EventArgs e)
        {
            Navigator.Switch(this, new Inventory());
        }
        private void trans_btn_Click(object sender, EventArgs e)
        {
            Navigator.Switch(this, new Transaction());
        }
    }
}
