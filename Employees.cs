using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FuelTrack
{
    public partial class Employees : Form
    {
        private readonly Database.Database _database = new Database.Database();
        private int? _selectedEmployeeId;
        private int? _selectedUserId;

        public Employees()
        {
            InitializeComponent();
            Load += Employees_Load;
            addemployee_button.Click += addemployee_button_Click;
            employeedata_dataGridView.CellClick += employeedata_dataGridView_CellClick;
            saveemployee_button.Click += btnSaveEmployee_Click;
            clear_button.Click += btnClear_Click;
            delete_button.Click += btnDelete_Click;
        }

        private void Employees_Load(object? sender, EventArgs e)
        {
            UIHelper.setDateLabel(date_label);
            UIHelper.SetButtonActive(employee_btn, true);
            UIHelper.DisableCloseButton(this);
            ConfigureGrid();
            LoadComboBoxes();
            LoadEmployees();
            LoadSummary();
            ClearFields();
        }

        private void ConfigureGrid()
        {
            employeedata_dataGridView.AutoGenerateColumns = true;
            employeedata_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeedata_dataGridView.RowHeadersVisible = false;
            employeedata_dataGridView.AllowUserToAddRows = false;
            employeedata_dataGridView.AllowUserToDeleteRows = false;
            employeedata_dataGridView.ReadOnly = true;
            employeedata_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadComboBoxes()
        {
            rol_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rol_comboBox.Items.Clear();
            rol_comboBox.Items.AddRange(new object[] { "Admin", "Supervisor", "Cashier" });

            shiftassignment_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shiftassignment_comboBox.Items.Clear();
            shiftassignment_comboBox.Items.AddRange(new object[]
            {
                "Morning (6AM-2PM)",
                "Afternoon (2PM-10PM)",
                "Night (10PM-6AM)"
            });

            if (sts_comboBox != null)
            {
                sts_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                sts_comboBox.Items.Clear();
                sts_comboBox.Items.AddRange(new object[] { "Active", "Inactive" });
            }
        }

        private void LoadEmployees()
        {
            const string query = @"
                SELECT
                    e.employee_id,
                    e.user_id,
                    COALESCE(u.full_name, '') AS full_name,
                    u.role,
                    e.shift,
                    u.status
                FROM employees e
                INNER JOIN users u ON u.user_id = e.user_id
                ORDER BY e.employee_id DESC;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                employeedata_dataGridView.DataSource = table;

                if (employeedata_dataGridView.Columns.Contains("user_id"))
                {
                    employeedata_dataGridView.Columns["user_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load employees: {ex.Message}", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSummary()
        {
            const string query = @"
                SELECT
                    COUNT(*) AS total_employees,
                    SUM(CASE WHEN status = 'Active' THEN 1 ELSE 0 END) AS on_duty,
                    SUM(CASE WHEN status <> 'Active' THEN 1 ELSE 0 END) AS off_duty
                FROM users;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    total_emp_db_label.Text = reader.GetInt64("total_employees").ToString();
                    on_duty_db_lbl.Text = reader.GetInt64("on_duty").ToString();
                    off_duty_db_lbl.Text = reader.GetInt64("off_duty").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load summary: {ex.Message}", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeedata_dataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = employeedata_dataGridView.Rows[e.RowIndex];
            _selectedEmployeeId = TryGetInt(row.Cells["employee_id"].Value);
            _selectedUserId = TryGetInt(row.Cells["user_id"].Value);

            fullname_textBox.Text = row.Cells["full_name"].Value?.ToString() ?? string.Empty;
            username_textBox.Text = GetUsernameByUserId(_selectedUserId);
            password_textBox.Clear();
            contactnumber_textBox.Text = GetContactNumberByUserId(_selectedEmployeeId);
            rol_comboBox.SelectedItem = row.Cells["role"].Value?.ToString();
            shiftassignment_comboBox.SelectedItem = GetShiftDisplayText(row.Cells["shift"].Value?.ToString());

            // FIX: We must check Columns.Contains, not Cells.Contains
            if (sts_comboBox != null && employeedata_dataGridView.Columns.Contains("status"))
            {
                sts_comboBox.SelectedItem = row.Cells["status"].Value?.ToString();
            }
        }

        private void btnSaveEmployee_Click(object? sender, EventArgs e)
        {
            var fullName = fullname_textBox.Text.Trim();
            var username = username_textBox.Text.Trim();
            var password = password_textBox.Text;
            var contactNumber = contactnumber_textBox.Text.Trim();
            var role = rol_comboBox.SelectedItem?.ToString();
            var shift = GetShiftValue(shiftassignment_comboBox.SelectedItem?.ToString());
            var status = sts_comboBox?.SelectedItem?.ToString() ?? "Active";

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(contactNumber)
                || string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(shift))
            {
                MessageBox.Show("Please fill in all required fields.", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedEmployeeId is null)
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password is required for a new employee.", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InsertEmployee(fullName, username, password, contactNumber, role, shift, status);
            }
            else
            {
                UpdateEmployee(fullName, username, password, contactNumber, role, shift, status);
            }
        }

        private void InsertEmployee(string fullName, string username, string password, string contactNumber, string role, string shift, string status)
        {
            const string insertUserQuery = @"
                INSERT INTO users (username, password_hash, full_name, role, status, created_at)
                VALUES (@username, @password_hash, @full_name, @role, @status, NOW());";

            const string insertEmployeeQuery = @"
                INSERT INTO employees (user_id, contact_number, shift, avatar_initials, created_at)
                VALUES (@user_id, @contact_number, @shift, @avatar_initials, NOW());";

            try
            {
                using var connection = _database.GetConnection();
                connection.Open();
                using var transaction = connection.BeginTransaction();

                try
                {
                    using var userCommand = new MySqlCommand(insertUserQuery, connection, transaction);
                    userCommand.Parameters.AddWithValue("@username", username);
                    userCommand.Parameters.AddWithValue("@password_hash", HashPassword(password));
                    userCommand.Parameters.AddWithValue("@full_name", fullName);
                    userCommand.Parameters.AddWithValue("@role", role);
                    userCommand.Parameters.AddWithValue("@status", status);
                    userCommand.ExecuteNonQuery();

                    var userId = (int)userCommand.LastInsertedId;

                    using var employeeCommand = new MySqlCommand(insertEmployeeQuery, connection, transaction);
                    employeeCommand.Parameters.AddWithValue("@user_id", userId);
                    employeeCommand.Parameters.AddWithValue("@contact_number", contactNumber);
                    employeeCommand.Parameters.AddWithValue("@shift", shift);
                    employeeCommand.Parameters.AddWithValue("@avatar_initials", GetAvatarInitials(fullName));
                    employeeCommand.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Employee saved successfully.", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                    LoadSummary();
                    ClearFields();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save employee: {ex.Message}", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEmployee(string fullName, string username, string password, string contactNumber, string role, string shift, string status)
        {
            if (_selectedEmployeeId is null || _selectedUserId is null)
            {
                MessageBox.Show("Please select an employee row to edit.", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string updateUserBaseQuery = @"
                UPDATE users
                SET username = @username,
                    full_name = @full_name,
                    role = @role,
                    status = @status
                WHERE user_id = @user_id;";

            const string updateUserWithPasswordQuery = @"
                UPDATE users
                SET username = @username,
                    password_hash = @password_hash,
                    full_name = @full_name,
                    role = @role,
                    status = @status
                WHERE user_id = @user_id;";

            const string updateEmployeeQuery = @"
                UPDATE employees
                SET contact_number = @contact_number,
                    shift = @shift,
                    avatar_initials = @avatar_initials
                WHERE employee_id = @employee_id;";

            try
            {
                using var connection = _database.GetConnection();
                connection.Open();
                using var transaction = connection.BeginTransaction();

                try
                {
                    var userQuery = string.IsNullOrWhiteSpace(password) ? updateUserBaseQuery : updateUserWithPasswordQuery;
                    using var userCommand = new MySqlCommand(userQuery, connection, transaction);
                    userCommand.Parameters.AddWithValue("@username", username);
                    userCommand.Parameters.AddWithValue("@full_name", fullName);
                    userCommand.Parameters.AddWithValue("@role", role);
                    userCommand.Parameters.AddWithValue("@status", status);
                    userCommand.Parameters.AddWithValue("@user_id", _selectedUserId.Value);
                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        userCommand.Parameters.AddWithValue("@password_hash", HashPassword(password));
                    }
                    userCommand.ExecuteNonQuery();

                    using var employeeCommand = new MySqlCommand(updateEmployeeQuery, connection, transaction);
                    employeeCommand.Parameters.AddWithValue("@contact_number", contactNumber);
                    employeeCommand.Parameters.AddWithValue("@shift", shift);
                    employeeCommand.Parameters.AddWithValue("@avatar_initials", GetAvatarInitials(fullName));
                    employeeCommand.Parameters.AddWithValue("@employee_id", _selectedEmployeeId.Value);
                    employeeCommand.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Employee updated successfully.", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                    LoadSummary();
                    ClearFields();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to update employee: {ex.Message}", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedEmployeeId is null || _selectedUserId is null)
            {
                MessageBox.Show("Please select an employee to delete.", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Delete this employee?", "Employees", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            const string deleteEmployeeQuery = "DELETE FROM employees WHERE employee_id = @employee_id;";
            const string deleteUserQuery = "DELETE FROM users WHERE user_id = @user_id;";

            try
            {
                using var connection = _database.GetConnection();
                connection.Open();
                using var transaction = connection.BeginTransaction();

                try
                {
                    using var employeeCommand = new MySqlCommand(deleteEmployeeQuery, connection, transaction);
                    employeeCommand.Parameters.AddWithValue("@employee_id", _selectedEmployeeId.Value);
                    employeeCommand.ExecuteNonQuery();

                    using var userCommand = new MySqlCommand(deleteUserQuery, connection, transaction);
                    userCommand.Parameters.AddWithValue("@user_id", _selectedUserId.Value);
                    userCommand.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Employee deleted successfully.", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                    LoadSummary();
                    ClearFields();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to delete employee: {ex.Message}", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void addemployee_button_Click(object? sender, EventArgs e)
        {
            ClearFields();
            fullname_textBox.Focus();
        }

        private void ClearFields()
        {
            _selectedEmployeeId = null;
            _selectedUserId = null;
            fullname_textBox.Clear();
            username_textBox.Clear();
            password_textBox.Clear();
            contactnumber_textBox.Clear();
            rol_comboBox.SelectedIndex = -1;
            shiftassignment_comboBox.SelectedIndex = -1;

            if (sts_comboBox != null)
            {
                sts_comboBox.SelectedIndex = -1;
            }

            employeedata_dataGridView.ClearSelection();
        }

        private static int? TryGetInt(object? value)
        {
            return value == null || value == DBNull.Value ? null : Convert.ToInt32(value);
        }

        private static string HashPassword(string password)
        {
            var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(bytes).ToLowerInvariant();
        }

        private static string GetAvatarInitials(string fullName)
        {
            var parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (parts.Length == 0)
            {
                return string.Empty;
            }

            if (parts.Length == 1)
            {
                return parts[0].Length >= 2
                    ? parts[0].Substring(0, 2).ToUpperInvariant()
                    : parts[0].Substring(0, 1).ToUpperInvariant();
            }

            return string.Concat(char.ToUpperInvariant(parts[0][0]), char.ToUpperInvariant(parts[1][0]));
        }

        private static string GetShiftDisplayText(string? shift)
        {
            return shift switch
            {
                "Morning" => "Morning (6AM-2PM)",
                "Afternoon" => "Afternoon (2PM-10PM)",
                "Night" => "Night (10PM-6AM)",
                _ => string.Empty
            };
        }

        private static string? GetShiftValue(string? displayText)
        {
            return displayText switch
            {
                "Morning (6AM-2PM)" => "Morning",
                "Afternoon (2PM-10PM)" => "Afternoon",
                "Night (10PM-6AM)" => "Night",
                _ => null
            };
        }

        private string GetUsernameByUserId(int? userId)
        {
            if (!userId.HasValue)
            {
                return string.Empty;
            }

            const string query = "SELECT username FROM users WHERE user_id = @user_id LIMIT 1;";
            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user_id", userId.Value);
                connection.Open();
                var result = command.ExecuteScalar();
                return result?.ToString() ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        private string GetContactNumberByUserId(int? employeeId)
        {
            if (!employeeId.HasValue)
            {
                return string.Empty;
            }

            const string query = "SELECT contact_number FROM employees WHERE employee_id = @employee_id LIMIT 1;";
            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@employee_id", employeeId.Value);
                connection.Open();
                var result = command.ExecuteScalar();
                return result?.ToString() ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        private void totalemployee_dataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e) { }
        private void addemployee_dataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e) { }
        private void totalemployee_dataGridView_CellContentClick_1(object? sender, DataGridViewCellEventArgs e) { }
        private void total_emp_label_Click(object sender, EventArgs e) { }
        private void onDuty_emp_lbl_Click(object sender, EventArgs e) { }
        private void offDuty_emp_lbl_Click(object sender, EventArgs e) { }
        private void total_emp_db_label_Click(object sender, EventArgs e) { }
        private void on_duty_db_lbl_Click(object sender, EventArgs e) { }
        private void off_duty_db_lbl_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}