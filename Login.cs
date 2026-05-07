using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FuelTrack.Database;
using MySql.Data.MySqlClient;

namespace FuelTrack
{
    public partial class Login : Form
    {
        private readonly Database.Database _database = new Database.Database();
        private bool _isPasswordVisible;
        private Image? _showPasswordImage;
        private Image? _hidePasswordImage;

        public Login()
        {
            InitializeComponent();
            UIHelper.SetRadius(login_btn, 6);
            UIHelper.SetRadius(user_txtbox, 3);
            UIHelper.SetRadius(pass_txtbox, 3);
            pass_txtbox.UseSystemPasswordChar = true;
            LoadPasswordToggleImages();
            UpdatePasswordToggleIcon();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_toggle_Click(object sender, EventArgs e)
        {
            _isPasswordVisible = !_isPasswordVisible;
            pass_txtbox.UseSystemPasswordChar = !_isPasswordVisible;
            UpdatePasswordToggleIcon();
        }

        private void LoadPasswordToggleImages()
        {
            _showPasswordImage = Properties.Resources.ResourceManager.GetObject("visible") as Image;
            _hidePasswordImage = Properties.Resources.ResourceManager.GetObject("hide") as Image;

            if (_showPasswordImage != null && _hidePasswordImage != null)
            {
                return;
            }

            _showPasswordImage = LoadImageFromProject("visible.png") ?? _showPasswordImage;
            _hidePasswordImage = LoadImageFromProject("hide.png") ?? _hidePasswordImage;
        }

        private static Image? LoadImageFromProject(string fileName)
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var current = new DirectoryInfo(baseDirectory);

            while (current != null)
            {
                var candidate = Path.Combine(current.FullName, "img", fileName);
                if (File.Exists(candidate))
                {
                    return Image.FromFile(candidate);
                }

                current = current.Parent;
            }

            return null;
        }

        private void UpdatePasswordToggleIcon()
        {
            password_toggle.Image = _isPasswordVisible ? _hidePasswordImage : _showPasswordImage;
            password_toggle.Visible = password_toggle.Image != null;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //LOGIN FOR ADMIN IS username: admin, password: Admin123!
            var username = user_txtbox.Text.Trim();
            var password = pass_txtbox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userSession = AuthenticateUser(username, password);
            if (userSession == null)
            {
                MessageBox.Show("Invalid username or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!InsertAttendance(userSession.EmployeeId))
            {
                MessageBox.Show("Login succeeded, but attendance could not be recorded.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!InsertAuditLog(userSession.UserId, "Auth", "Login", $"{userSession.DisplayName} logged in."))
            {
                MessageBox.Show("Login succeeded, but audit log could not be recorded.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SessionContext.SetUser(userSession);

            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private UserSession? AuthenticateUser(string username, string password)
        {
            const string query = @"SELECT u.user_id,
                   e.employee_id,
                   u.username,
                   u.full_name,
                   u.role
                FROM Users u
                INNER JOIN Employees e ON e.user_id = u.user_id
                WHERE u.username = @username
                  AND u.password_hash = SHA2(@password, 256)
                  AND u.status = 'Active'
                LIMIT 1;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                using var reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }

                var userId = reader.GetInt32("user_id");
                var employeeId = reader.GetInt32("employee_id");
                var dbUsername = reader.GetString("username");
                var fullName = reader.IsDBNull(reader.GetOrdinal("full_name"))
                    ? string.Empty
                    : reader.GetString("full_name");
                var role = reader.GetString("role");

                return new UserSession(userId, employeeId, dbUsername, fullName, role);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while logging in: {ex.Message}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool InsertAttendance(int employeeId)
        {
            const string query = "INSERT INTO attendance (employee_id, login_time) VALUES (@employee_id, @login_time);";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@employee_id", employeeId);
                command.Parameters.AddWithValue("@login_time", DateTime.Now);

                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving attendance: {ex.Message}", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool InsertAuditLog(int userId, string module, string actionType, string description)
        {
            const string query = @"INSERT INTO audit_trail (user_id, module, action_type, description, action_date)
VALUES (@user_id, @module, @action_type, @description, @action_date);";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user_id", userId);
                command.Parameters.AddWithValue("@module", module);
                command.Parameters.AddWithValue("@action_type", actionType);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@action_date", DateTime.Now);

                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
