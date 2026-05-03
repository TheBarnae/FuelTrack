using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static FuelTrack.UIHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelTrack
{
    public partial class Transaction : Form
    {
        private readonly Database.Database _database = new Database.Database();

        public Transaction()
        {
            InitializeComponent();
            UIHelper.MakeCircular(usr_avatar);
            UIHelper.StyleFuelTrackTitle(richTextBox1);
            newsale_button.Click += newsale_button_Click;
        }
        private void Transaction_Load(object sender, EventArgs e)
        {
            UIHelper.setDateLabel(date_label);
            UIHelper.SetButtonActive(trans_btn, true);
            UIHelper.DisableCloseButton(this);
            ConfigureTransactionsGrid();
            LoadTransactions();
            LoadTodaySummaryStats();
        }

        private void ConfigureTransactionsGrid()
        {
            transactionsdata_dataGridView.AutoGenerateColumns = true;
            transactionsdata_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionsdata_dataGridView.AllowUserToAddRows = false;
            transactionsdata_dataGridView.AllowUserToDeleteRows = false;
            transactionsdata_dataGridView.ReadOnly = true;
            transactionsdata_dataGridView.RowHeadersVisible = false;
            transactionsdata_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadTransactions()
        {
            const string query = @"
                SELECT
                    t.transaction_id AS `Txn ID`,
                    DATE_FORMAT(t.transaction_date, '%Y-%m-%d %H:%i:%s') AS `Transaction Date`,
                    p.pump_label AS `Pump`,
                    ft.name AS `Fuel Type`,
                    COALESCE(u.full_name, u.username, CONCAT('Employee #', e.employee_id)) AS `Employee`,
                    t.liters_dispensed AS `Liters Dispensed`,
                    t.amount_paid AS `Amount Paid`,
                    t.payment_method AS `Payment Method`
                FROM transactions t
                INNER JOIN pumps p ON p.pump_id = t.pump_id
                INNER JOIN fuel_types ft ON ft.fuel_type_id = t.fuel_type_id
                INNER JOIN employees e ON e.employee_id = t.employee_id
                LEFT JOIN users u ON u.user_id = e.user_id
                ORDER BY t.transaction_date DESC, t.transaction_id DESC;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                transactionsdata_dataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load transactions: {ex.Message}", "Transactions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTodaySummaryStats()
        {
            const string query = @"
                SELECT
                    COALESCE(SUM(t.amount_paid), 0) AS total_sales,
                    COUNT(*) AS transaction_count,
                    COALESCE(SUM(CASE WHEN t.payment_method = 'Cash' THEN t.amount_paid ELSE 0 END), 0) AS cash_total,
                    COALESCE(SUM(CASE WHEN t.payment_method IN ('Card', 'GCash') THEN t.amount_paid ELSE 0 END), 0) AS card_total
                FROM transactions t
                WHERE t.transaction_date >= CURDATE()
                  AND t.transaction_date < CURDATE() + INTERVAL 1 DAY;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var totalSales = reader.GetDecimal("total_sales");
                    var transactionCount = reader.GetInt32("transaction_count");
                    var cashTotal = reader.GetDecimal("cash_total");
                    var cardTotal = reader.GetDecimal("card_total");

                    total_sales_db_label.Text = $"₱{totalSales:N2}";
                    trans_db_label.Text = transactionCount.ToString("N0");
                    cash_card_db_label.Text = $"₱{cashTotal:N2} / ₱{cardTotal:N2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load today's summary: {ex.Message}", "Transactions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newsale_button_Click(object? sender, EventArgs e)
        {
            using var dialog = new TransactionSaleDialog(_database);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadTransactions();
                LoadTodaySummaryStats();
            }
        }

        private void menubar_dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
