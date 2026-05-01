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
            UIHelper.SetButtonActive(dashboard_btn, true);
            UpdateLoggedInUserLabel();
        }

        private void UpdateLoggedInUserLabel()
        {
            role_label.Text = SessionContext.CurrentUser?.DisplayName ?? "--ROLE--";
        }
        public void LoadView(Form form)
        {
            UIHelper.LoadForm(panelMain, form);
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadView(new Dashboard());
            UIHelper.SetButtonActive(dashboard_btn, true);
            UIHelper.SetButtonActive(inv_btn, false);
            UIHelper.SetButtonActive(trans_btn, false);
            UIHelper.SetButtonActive(employee_btn, false);
            UIHelper.SetButtonActive(suplier_btn, false);
            UIHelper.SetButtonActive(reports_Btn, false);
            UIHelper.SetButtonActive(audit_btn, false);

        }

        private void inv_btn_Click(object sender, EventArgs e)
        {
            LoadView(new Inventory());
            UIHelper.SetButtonActive(dashboard_btn, false);
            UIHelper.SetButtonActive(inv_btn, true);
            UIHelper.SetButtonActive(trans_btn, false);
            UIHelper.SetButtonActive(employee_btn, false);
            UIHelper.SetButtonActive(suplier_btn, false);
            UIHelper.SetButtonActive(reports_Btn, false);
            UIHelper.SetButtonActive(audit_btn, false);
        }

        private void trans_btn_Click(object sender, EventArgs e)
        {
            LoadView(new Transaction());
            UIHelper.SetButtonActive(dashboard_btn, false);
            UIHelper.SetButtonActive(inv_btn, false);
            UIHelper.SetButtonActive(trans_btn, true);
            UIHelper.SetButtonActive(employee_btn, false);
            UIHelper.SetButtonActive(suplier_btn, false);
            UIHelper.SetButtonActive(reports_Btn, false);
            UIHelper.SetButtonActive(audit_btn, false);
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
                SessionContext.Clear();
                Login login = new Login();
                login.Show();

                this.Close();
            }
        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            LoadView(new Employees());
            UIHelper.SetButtonActive(dashboard_btn, false);
            UIHelper.SetButtonActive(inv_btn, false);
            UIHelper.SetButtonActive(trans_btn, false);
            UIHelper.SetButtonActive(employee_btn, true);
            UIHelper.SetButtonActive(suplier_btn, false);
            UIHelper.SetButtonActive(reports_Btn, false);
            UIHelper.SetButtonActive(audit_btn, false);
        }

        private void suplier_btn_Click(object sender, EventArgs e)
        {
            LoadView(new Suppliers());
            UIHelper.SetButtonActive(dashboard_btn, false);
            UIHelper.SetButtonActive(inv_btn, false);
            UIHelper.SetButtonActive(trans_btn, false);
            UIHelper.SetButtonActive(employee_btn, false);
            UIHelper.SetButtonActive(suplier_btn, true);
            UIHelper.SetButtonActive(reports_Btn, false);
            UIHelper.SetButtonActive(audit_btn, false);
        }

        private void reports_Btn_Click(object sender, EventArgs e)
        {
            LoadView(new Reports());
            UIHelper.SetButtonActive(dashboard_btn, false);
            UIHelper.SetButtonActive(inv_btn, false);
            UIHelper.SetButtonActive(trans_btn, false);
            UIHelper.SetButtonActive(employee_btn, false);
            UIHelper.SetButtonActive(suplier_btn, false);
            UIHelper.SetButtonActive(reports_Btn, true);
            UIHelper.SetButtonActive(audit_btn, false);
        }

        private void audit_btn_Click(object sender, EventArgs e)
        {
            LoadView(new Audit_Trail());
            UIHelper.SetButtonActive(dashboard_btn, false);
            UIHelper.SetButtonActive(inv_btn, false);
            UIHelper.SetButtonActive(trans_btn, false);
            UIHelper.SetButtonActive(employee_btn, false);
            UIHelper.SetButtonActive(suplier_btn, false);
            UIHelper.SetButtonActive(reports_Btn, false);
            UIHelper.SetButtonActive(audit_btn, true);
        }
    }
}