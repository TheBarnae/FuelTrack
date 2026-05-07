using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FuelTrack.Database;
using MySql.Data.MySqlClient;

namespace FuelTrack
{
    public partial class Audit_Trail : Form
    {
        private readonly Database.Database _database = new Database.Database();
        private DataTable? _auditTable;

        public Audit_Trail()
        {
            InitializeComponent();
        }

        private void Audit_Trail_Load(object sender, EventArgs e)
        {
            ConfigureSummaryGrid(actiontoday_dataGridView);
            ConfigureSummaryGrid(logintoday_dataGridView);
            ConfigureSummaryGrid(flaggedactions_dataGridView);
            ConfigureAuditGrid(auditTrailData_dataGridView);

            LoadFilterOptions();
            LoadAuditStats();
            LoadAuditTrail();
        }

        private static void ConfigureSummaryGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = true;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private static void ConfigureAuditGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = true;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadFilterOptions()
        {
            LoadUsers();
            LoadModules();
            LoadActionTypes();
        }

        private void LoadUsers()
        {
            const string query = @"
                SELECT u.user_id,
                       COALESCE(u.full_name, u.username, CONCAT('User #', u.user_id)) AS user_name
                FROM Users u
                ORDER BY user_name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                var allRow = table.NewRow();
                allRow["user_id"] = DBNull.Value;
                allRow["user_name"] = "All users";
                table.Rows.InsertAt(allRow, 0);

                user_comboBox.DisplayMember = "user_name";
                user_comboBox.ValueMember = "user_id";
                user_comboBox.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load users: {ex.Message}", "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadModules()
        {
            const string query = "SELECT DISTINCT module FROM audit_trail ORDER BY module;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                var allRow = table.NewRow();
                allRow["module"] = "All modules";
                table.Rows.InsertAt(allRow, 0);

                module_comboBox.DisplayMember = "module";
                module_comboBox.ValueMember = "module";
                module_comboBox.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load modules: {ex.Message}", "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadActionTypes()
        {
            const string query = "SELECT DISTINCT action_type FROM audit_trail ORDER BY action_type;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                var allRow = table.NewRow();
                allRow["action_type"] = "All actions";
                table.Rows.InsertAt(allRow, 0);

                actionType_comboBox.DisplayMember = "action_type";
                actionType_comboBox.ValueMember = "action_type";
                actionType_comboBox.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load action types: {ex.Message}", "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAuditStats()
        {
            const string actionsQuery = @"
                SELECT COUNT(*)
                FROM audit_trail
                WHERE action_date >= CURDATE()
                  AND action_date < CURDATE() + INTERVAL 1 DAY;";

            const string loginsQuery = @"
                SELECT COUNT(*)
                FROM audit_trail
                WHERE action_date >= CURDATE()
                  AND action_date < CURDATE() + INTERVAL 1 DAY
                  AND action_type IN ('Login', 'Logout', 'Logged in', 'Logged out', 'Logged in/out');";

            const string flaggedQuery = @"
                SELECT COUNT(*)
                FROM audit_trail
                WHERE action_date >= CURDATE()
                  AND action_date < CURDATE() + INTERVAL 1 DAY
                  AND action_type = 'Deleted';";

            try
            {
                var actionsToday = ExecuteScalarCount(actionsQuery);
                var loginsToday = ExecuteScalarCount(loginsQuery);
                var flaggedToday = ExecuteScalarCount(flaggedQuery);

                actiontoday_dataGridView.DataSource = CreateSummaryTable("Actions today", actionsToday);
                logintoday_dataGridView.DataSource = CreateSummaryTable("Logins today", loginsToday);
                flaggedactions_dataGridView.DataSource = CreateSummaryTable("Flagged actions", flaggedToday);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load audit stats: {ex.Message}", "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ExecuteScalarCount(string query)
        {
            using var connection = _database.GetConnection();
            using var command = new MySqlCommand(query, connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private static DataTable CreateSummaryTable(string label, int value)
        {
            var table = new DataTable();
            table.Columns.Add(label, typeof(int));
            table.Rows.Add(value);
            return table;
        }

        private void LoadAuditTrail()
        {
            const string query = @"
                SELECT
                    a.action_date AS `Date`,
                    COALESCE(u.full_name, u.username, CONCAT('User #', a.user_id)) AS `User`,
                    a.module AS `Module`,
                    a.action_type AS `Action`,
                    a.description AS `Description`
                FROM audit_trail a
                LEFT JOIN users u ON u.user_id = a.user_id
                WHERE DATE(a.action_date) = @date
                  AND (@user_id IS NULL OR a.user_id = @user_id)
                  AND (@module = 'All modules' OR a.module = @module)
                  AND (@action_type = 'All actions' OR a.action_type = @action_type)
                ORDER BY a.action_date DESC;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@date", dateRange_dateTimePicker.Value.Date);

                var userId = user_comboBox.SelectedValue is DBNull ? null : user_comboBox.SelectedValue;
                command.Parameters.AddWithValue("@user_id", userId ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@module", module_comboBox.SelectedValue?.ToString() ?? "All modules");
                command.Parameters.AddWithValue("@action_type", actionType_comboBox.SelectedValue?.ToString() ?? "All actions");

                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                _auditTable = table;
                auditTrailData_dataGridView.DataSource = _auditTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load audit trail: {ex.Message}", "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            LoadAuditTrail();
        }
    }
}
