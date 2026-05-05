using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using FuelTrack.Database;
using MySql.Data.MySqlClient;
using static FuelTrack.UIHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FuelTrack
{
    public partial class Dashboard : Form
    {
        private Color _logoutOriginalColor;
        private readonly System.Windows.Forms.Timer _clockTimer = new System.Windows.Forms.Timer();
        private readonly Database.Database _database = new Database.Database();
        private readonly DataGridView _recentTransactionsGrid = new DataGridView();
        private readonly FlowLayoutPanel _inventoryFlow = new FlowLayoutPanel();
        public Dashboard()
        {
            InitializeComponent();
            _logoutOriginalColor = logout_btn.BackColor;
            UIHelper.MakeCircular(usr_avatar);
            UIHelper.StyleFuelTrackTitle(richTextBox1);
            ConfigureOverviewGrids();
            ConfigureClockTimer();
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
            UIHelper.DisableCloseButton(this);
            LoadDashboardStats();
            LoadInventorySnapshot();
            LoadRecentTransactions();
        }

        private void ConfigureClockTimer()
        {
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += clockTimer_Tick;
            _clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            UIHelper.setDateLabel(date_label);
        }

        private void ConfigureOverviewGrids()
        {
            ConfigureOverviewGrid(_recentTransactionsGrid);

            _recentTransactionsGrid.Dock = DockStyle.Fill;

            ConfigureInventoryFlow();

            inventory_pnel.Controls.Add(_inventoryFlow);
            recent_transaction_panel.Controls.Add(_recentTransactionsGrid);
        }

        private void ConfigureInventoryFlow()
        {
            _inventoryFlow.Dock = DockStyle.Fill;
            _inventoryFlow.FlowDirection = FlowDirection.TopDown;
            _inventoryFlow.WrapContents = false;
            _inventoryFlow.AutoScroll = true;
            _inventoryFlow.Padding = new Padding(8);
            _inventoryFlow.BackColor = Color.WhiteSmoke;
        }

        private static void ConfigureOverviewGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.BackgroundColor = Color.WhiteSmoke;
            grid.BorderStyle = BorderStyle.None;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void LoadDashboardStats()
        {
            const string query = @"
                SELECT
                    COALESCE(SUM(t.amount_paid), 0) AS total_sales,
                    COALESCE(SUM(t.liters_dispensed), 0) AS total_liters,
                    COUNT(*) AS transaction_count
                FROM transactions t
                WHERE t.transaction_date >= CURDATE()
                  AND t.transaction_date < CURDATE() + INTERVAL 1 DAY;";

            const string lowStockQuery = @"
                SELECT COUNT(*)
                FROM Fuel_types
                WHERE current_stock_liters <= min_stock_threshold;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var totalSales = reader.GetDecimal("total_sales");
                    var totalLiters = reader.GetDecimal("total_liters");
                    var transactionCount = reader.GetInt32("transaction_count");

                    today_label.Text = $"₱{totalSales:N2}";
                    litersdispensed_label.Text = $"{totalLiters:N2} L";
                    transaction_label.Text = transactionCount.ToString("N0");
                }

                reader.Close();
                command.CommandText = lowStockQuery;
                var lowStockCount = Convert.ToInt32(command.ExecuteScalar());
                stocks_label.Text = lowStockCount.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load dashboard stats: {ex.Message}", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInventorySnapshot()
        {
            const string query = @"
                SELECT
                    name AS `Fuel`,
                    current_stock_liters AS `Stock (L)`,
                    min_stock_threshold AS `Min (L)`,
                    status AS `Status`
                FROM Fuel_types
                ORDER BY name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                PopulateInventoryBars(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load inventory snapshot: {ex.Message}", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateInventoryBars(DataTable table)
        {
            _inventoryFlow.SuspendLayout();
            _inventoryFlow.Controls.Clear();

            foreach (DataRow row in table.Rows)
            {
                var fuelName = row["Fuel"].ToString() ?? string.Empty;
                var stock = Convert.ToDecimal(row["Stock (L)"]);
                var capacity = Convert.ToDecimal(row["Min (L)"]);
                var status = GetStockStatus(stock, capacity);
                var percentage = CalculateStockValue(stock, capacity);

                var rowPanel = new Panel
                {
                    Width = inventory_pnel.ClientSize.Width - 24,
                    Height = 26,
                    BackColor = Color.Transparent
                };

                var nameLabel = new Label
                {
                    AutoSize = true,
                    Text = fuelName,
                    Location = new Point(0, 5)
                };

                var statusLabel = new Label
                {
                    AutoSize = true,
                    Text = $"{status} — {stock:N0} L",
                    Location = new Point(rowPanel.Width - 90, 5),
                    TextAlign = ContentAlignment.MiddleRight
                };

                var barPanel = new Panel
                {
                    Location = new Point(80, 8),
                    Size = new Size(rowPanel.Width - 180, 10),
                    BackColor = Color.FromArgb(230, 230, 230)
                };

                var fillPanel = new Panel
                {
                    Height = 10,
                    Width = (int)Math.Round(barPanel.Width * (percentage / 100m), 0),
                    BackColor = GetStatusColor(status)
                };

                barPanel.Controls.Add(fillPanel);
                statusLabel.ForeColor = GetStatusColor(status);

                rowPanel.Controls.Add(nameLabel);
                rowPanel.Controls.Add(barPanel);
                rowPanel.Controls.Add(statusLabel);
                _inventoryFlow.Controls.Add(rowPanel);
            }

            _inventoryFlow.ResumeLayout();
        }

        private static int CalculateStockValue(decimal stock, decimal capacity)
        {
            if (capacity <= 0m)
            {
                return 0;
            }

            var percentage = Math.Min(1m, stock / capacity);
            return (int)Math.Round(percentage * 100m, 0);
        }

        private static string GetStockStatus(decimal stock, decimal capacity)
        {
            if (capacity <= 0m)
            {
                return "Critical";
            }

            if (stock < capacity * 0.2m)
            {
                return "Critical";
            }

            if (stock <= capacity)
            {
                return "Low";
            }

            return "Normal";
        }

        private static Color GetStatusColor(string status)
        {
            return status switch
            {
                "Normal" => ColorTranslator.FromHtml("#639922"),
                "Low" => ColorTranslator.FromHtml("#EF9F27"),
                "Critical" => ColorTranslator.FromHtml("#E24B4A"),
                _ => Color.Gray
            };
        }

        private void LoadRecentTransactions()
        {
            const string query = @"
                SELECT
                    p.pump_label AS `Pump`,
                    ft.name AS `Fuel`,
                    t.liters_dispensed AS `Liters`,
                    t.amount_paid AS `Total`
                FROM transactions t
                INNER JOIN pumps p ON p.pump_id = t.pump_id
                INNER JOIN fuel_types ft ON ft.fuel_type_id = t.fuel_type_id
                ORDER BY t.transaction_date DESC
                LIMIT 5;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                _recentTransactionsGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load recent transactions: {ex.Message}", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
