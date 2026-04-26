using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
this form is the main form to avoid blinking when switching between forms,
this form will load the dashboard form by default and then when the user 
clicks on the buttons it will load the corresponding forms in the panelMain
 */
namespace FuelTrack
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UIHelper.LoadForm(panelMain, new Dashboard());
            UIHelper.setDateLabel(date_label);
            UIHelper.MakeCircular(usr_avatar);
            UIHelper.StyleFuelTrackTitle(richTextBox1);
        }
        public void LoadView(Form form)
        {
            UIHelper.LoadForm(panelMain, form);
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadView(new Dashboard());
        }

        private void inv_btn_Click(object sender, EventArgs e)
        {
            LoadView(new Inventory());
        }

        private void trans_btn_Click(object sender, EventArgs e)
        {
            LoadView(new Transaction());
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();

                this.Close();
            }
        }
    }
}