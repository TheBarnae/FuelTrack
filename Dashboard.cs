using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using static FuelTrack.UIHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FuelTrack
{
    public partial class Dashboard : Form
    {
        private Color _logoutOriginalColor;
        public Dashboard()
        {
            InitializeComponent();
            _logoutOriginalColor = logout_btn.BackColor;
            UIHelper.MakeCircular(usr_avatar);
            UIHelper.StyleFuelTrackTitle(richTextBox1);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            UIHelper.setDateLabel(date_label);
            // Set the dashboard as the active one
            UIHelper.SetButtonActive(dashboard_btn, true);
            // Set rounded corners for panels in dashboard
            UIHelper.SetRadius(sales_panel, 12);
            UIHelper.SetRadius(liters_panel, 12);
            UIHelper.SetRadius(transaction_panel, 12);
            UIHelper.SetRadius(Low_stocks_alerts, 12);
            UIHelper.SetRadius(inventory_pnel, 12);
            UIHelper.SetRadius(recent_transaction_panel, 12);
            UIHelper.DisableCloseButton(this);
        }
    }
}
