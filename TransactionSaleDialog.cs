using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FuelTrack
{
    internal sealed class TransactionSaleDialog : Form
    {
        private readonly Database.Database _database;
        private readonly ComboBox _pumpComboBox = new();
        private readonly ComboBox _fuelTypeComboBox = new();
        private readonly ComboBox _employeeComboBox = new();
        private readonly ComboBox _paymentMethodComboBox = new();
        private readonly NumericUpDown _litersNumeric = new();
        private readonly NumericUpDown _amountNumeric = new();
        private readonly Button _saveButton = new();
        private readonly Button _cancelButton = new();
        private decimal _currentPricePerLiter;
        private bool _isUpdatingTotals;

        public TransactionSaleDialog(Database.Database database)
        {
            _database = database;
            InitializeForm();
            Load += TransactionSaleDialog_Load;
        }

        private void InitializeForm()
        {
            Text = "FuelTrack — New Sale";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(460, 320);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 7,
                Padding = new Padding(16),
                AutoSize = true
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            layout.Controls.Add(CreateLabel("Pump:"), 0, 0);
            layout.Controls.Add(_pumpComboBox, 1, 0);
            layout.Controls.Add(CreateLabel("Fuel type:"), 0, 1);
            layout.Controls.Add(_fuelTypeComboBox, 1, 1);
            layout.Controls.Add(CreateLabel("Employee:"), 0, 2);
            layout.Controls.Add(_employeeComboBox, 1, 2);
            layout.Controls.Add(CreateLabel("Payment method:"), 0, 3);
            layout.Controls.Add(_paymentMethodComboBox, 1, 3);
            layout.Controls.Add(CreateLabel("Liters dispensed:"), 0, 4);
            layout.Controls.Add(_litersNumeric, 1, 4);
            layout.Controls.Add(CreateLabel("Amount paid:"), 0, 5);
            layout.Controls.Add(_amountNumeric, 1, 5);

            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(0),
                WrapContents = false
            };

            _saveButton.Text = "Save";
            _saveButton.Width = 90;
            _saveButton.Click += SaveButton_Click;

            _cancelButton.Text = "Cancel";
            _cancelButton.Width = 90;
            _cancelButton.DialogResult = DialogResult.Cancel;

            buttonPanel.Controls.Add(_saveButton);
            buttonPanel.Controls.Add(_cancelButton);
            layout.Controls.Add(buttonPanel, 0, 6);
            layout.SetColumnSpan(buttonPanel, 2);

            _pumpComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _pumpComboBox.Width = 260;
            _pumpComboBox.SelectedIndexChanged += PumpComboBox_SelectedIndexChanged;

            _fuelTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _fuelTypeComboBox.Width = 260;
            _fuelTypeComboBox.SelectedIndexChanged += FuelTypeComboBox_SelectedIndexChanged;

            _employeeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _employeeComboBox.Width = 260;

            _paymentMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _paymentMethodComboBox.Width = 260;
            _paymentMethodComboBox.Items.AddRange(new object[] { "Cash", "Card", "GCash" });
            _paymentMethodComboBox.SelectedIndex = 0;

            _litersNumeric.DecimalPlaces = 2;
            _litersNumeric.Maximum = 1000000;
            _litersNumeric.Width = 260;
            _litersNumeric.ThousandsSeparator = true;
            _litersNumeric.ValueChanged += LitersNumeric_ValueChanged;

            _amountNumeric.DecimalPlaces = 2;
            _amountNumeric.Maximum = 100000000;
            _amountNumeric.Width = 260;
            _amountNumeric.ThousandsSeparator = true;
            _amountNumeric.ValueChanged += AmountNumeric_ValueChanged;

            AcceptButton = _saveButton;
            CancelButton = _cancelButton;
            Controls.Add(layout);
        }

        private static Label CreateLabel(string text)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Anchor = AnchorStyles.Left,
                Margin = new Padding(0, 8, 12, 8)
            };
        }

        private void TransactionSaleDialog_Load(object? sender, EventArgs e)
        {
            LoadFuelTypes();
            LoadPumps();
            LoadEmployees();
        }

        private void LoadFuelTypes()
        {
            const string query = @"
                SELECT fuel_type_id, name, price_per_liter, current_stock_liters
                FROM fuel_types
                ORDER BY name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                var fuelTypes = new List<FuelTypeLookup>();
                while (reader.Read())
                {
                    fuelTypes.Add(new FuelTypeLookup(
                        reader.GetInt32("fuel_type_id"),
                        reader.GetString("name"),
                        reader.IsDBNull(reader.GetOrdinal("price_per_liter"))
                            ? 0m
                            : reader.GetDecimal("price_per_liter"),
                        reader.IsDBNull(reader.GetOrdinal("current_stock_liters"))
                            ? 0m
                            : reader.GetDecimal("current_stock_liters")));
                }

                _fuelTypeComboBox.DataSource = fuelTypes;
                _fuelTypeComboBox.DisplayMember = nameof(FuelTypeLookup.DisplayText);
                _fuelTypeComboBox.ValueMember = nameof(FuelTypeLookup.FuelTypeId);
                _fuelTypeComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load fuel types: {ex.Message}", "New Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPumps()
        {
            const string query = @"
                SELECT
                    p.pump_id,
                    p.pump_label,
                    p.fuel_type_id,
                    ft.name AS fuel_type_name
                FROM pumps p
                LEFT JOIN fuel_types ft ON ft.fuel_type_id = p.fuel_type_id
                ORDER BY p.pump_label;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                var pumps = new List<PumpLookup>();
                while (reader.Read())
                {
                    pumps.Add(new PumpLookup(
                        reader.GetInt32("pump_id"),
                        reader.IsDBNull(reader.GetOrdinal("fuel_type_id")) ? null : reader.GetInt32("fuel_type_id"),
                        reader.GetString("pump_label"),
                        reader.IsDBNull(reader.GetOrdinal("fuel_type_name")) ? "Unknown" : reader.GetString("fuel_type_name")));
                }

                _pumpComboBox.DataSource = pumps;
                _pumpComboBox.DisplayMember = nameof(PumpLookup.DisplayText);

                _pumpComboBox.SelectedIndex = -1;

                if (pumps.Count == 0)
                {
                    MessageBox.Show(
                        "No pumps were found in the database. Add at least one pump record before creating a sale.",
                        "New Sale",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load pumps: {ex.Message}", "New Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployees()
        {
            const string query = @"
                SELECT
                    e.employee_id,
                    COALESCE(u.full_name, u.username, CONCAT('Employee #', e.employee_id)) AS employee_name
                FROM employees e
                LEFT JOIN users u ON u.user_id = e.user_id
                WHERE u.status = 'Active' OR u.user_id IS NULL
                ORDER BY employee_name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                var employees = new List<EmployeeLookup>();
                while (reader.Read())
                {
                    employees.Add(new EmployeeLookup(
                        reader.GetInt32("employee_id"),
                        reader.GetString("employee_name")));
                }

                _employeeComboBox.DataSource = employees;
                _employeeComboBox.DisplayMember = nameof(EmployeeLookup.DisplayText);

                var currentEmployeeId = SessionContext.CurrentUser?.EmployeeId;
                if (currentEmployeeId.HasValue)
                {
                    var matchIndex = employees.FindIndex(employee => employee.EmployeeId == currentEmployeeId.Value);
                    if (matchIndex >= 0)
                    {
                        _employeeComboBox.SelectedIndex = matchIndex;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load employees: {ex.Message}", "New Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PumpComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_pumpComboBox.SelectedItem is PumpLookup pump)
            {
                if (pump.FuelTypeId.HasValue)
                {
                    _fuelTypeComboBox.SelectedValue = pump.FuelTypeId.Value;
                }

                return;
            }

            _fuelTypeComboBox.SelectedIndex = -1;
        }

        private void FuelTypeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_fuelTypeComboBox.SelectedItem is FuelTypeLookup fuelType)
            {
                _currentPricePerLiter = fuelType.PricePerLiter;

                // FIX: Stop limiting the box to 0 if stock is 0. 
                // Always allow typing up to a million. Validation handles stock limits when saving.
                _litersNumeric.Maximum = 1000000m;

                RecalculateAmountFromLiters();
                return;
            }

            _currentPricePerLiter = 0m;

            // FIX: Always allow typing up to a million.
            _litersNumeric.Maximum = 1000000m;
            RecalculateAmountFromLiters();
        }

        private void LitersNumeric_ValueChanged(object? sender, EventArgs e)
        {
            if (_isUpdatingTotals)
            {
                return;
            }

            RecalculateAmountFromLiters();
        }

        private void AmountNumeric_ValueChanged(object? sender, EventArgs e)
        {
            if (_isUpdatingTotals)
            {
                return;
            }

            RecalculateLitersFromAmount();
        }

        private void RecalculateAmountFromLiters()
        {
            _isUpdatingTotals = true;

            // FIX: Only auto-calculate if there is a real price greater than 0.
            // This prevents it from automatically deleting your numbers!
            if (_currentPricePerLiter > 0m)
            {
                _amountNumeric.Value = Math.Round(_litersNumeric.Value * _currentPricePerLiter, 2);
            }

            _isUpdatingTotals = false;
        }

        private void RecalculateLitersFromAmount()
        {
            _isUpdatingTotals = true;

            // FIX: Only auto-calculate if there is a real price greater than 0.
            if (_currentPricePerLiter > 0m)
            {
                _litersNumeric.Value = Math.Round(_amountNumeric.Value / _currentPricePerLiter, 2);
            }

            _isUpdatingTotals = false;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // TransactionSaleDialog
            // 
            ClientSize = new Size(284, 261);
            Name = "TransactionSaleDialog";
            Load += TransactionSaleDialog_Load_1;
            ResumeLayout(false);

        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            this.ValidateChildren();

            if (_pumpComboBox.SelectedItem is not PumpLookup pump ||
                _fuelTypeComboBox.SelectedItem is not FuelTypeLookup fuelType ||
                _employeeComboBox.SelectedItem is not EmployeeLookup employee)
            {
                MessageBox.Show("Please fill in all required fields.", "New Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_litersNumeric.Value <= 0 || _amountNumeric.Value <= 0)
            {
                MessageBox.Show("Liters and amount must be greater than zero.", "New Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_litersNumeric.Value > fuelType.CurrentStock)
            {
                MessageBox.Show($"Not enough stock. Current stock: {fuelType.CurrentStock}L", "New Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var connection = _database.GetConnection();
            connection.Open();
            using var transaction = connection.BeginTransaction(); // Start transaction to ensure both updates happen

            try
            {
                // 1. Insert the Transaction Record
                const string insertQuery = @"
            INSERT INTO transactions (pump_id, employee_id, fuel_type_id, liters_dispensed, amount_paid, payment_method, transaction_date)
            VALUES (@pump_id, @employee_id, @fuel_type_id, @liters_dispensed, @amount_paid, @payment_method, NOW());";

                using var cmdInsert = new MySqlCommand(insertQuery, connection, transaction);
                cmdInsert.Parameters.AddWithValue("@pump_id", pump.PumpId);
                cmdInsert.Parameters.AddWithValue("@employee_id", employee.EmployeeId);
                cmdInsert.Parameters.AddWithValue("@fuel_type_id", fuelType.FuelTypeId);
                cmdInsert.Parameters.AddWithValue("@liters_dispensed", _litersNumeric.Value);
                cmdInsert.Parameters.AddWithValue("@amount_paid", _amountNumeric.Value);
                cmdInsert.Parameters.AddWithValue("@payment_method", _paymentMethodComboBox.Text);
                cmdInsert.ExecuteNonQuery();

                // 2. Deduct from Inventory (Update fuel_types table)
                const string updateStockQuery = @"
            UPDATE Fuel_types 
            SET current_stock_liters = current_stock_liters - @liters,
                updated_at = NOW()
            WHERE fuel_type_id = @id;";

                using var cmdUpdate = new MySqlCommand(updateStockQuery, connection, transaction);
                cmdUpdate.Parameters.AddWithValue("@liters", _litersNumeric.Value);
                cmdUpdate.Parameters.AddWithValue("@id", fuelType.FuelTypeId);
                cmdUpdate.ExecuteNonQuery();

                transaction.Commit(); // Finalize both actions

                MessageBox.Show("Transaction saved and stock updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback(); // If anything fails, undo the changes
                MessageBox.Show($"Error processing sale: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private sealed class PumpLookup
        {
            public PumpLookup(int pumpId, int? fuelTypeId, string pumpLabel, string fuelTypeName)
            {
                PumpId = pumpId;
                FuelTypeId = fuelTypeId;
                PumpLabel = pumpLabel;
                FuelTypeName = fuelTypeName;
            }

            public int PumpId { get; }
            public int? FuelTypeId { get; }
            public string PumpLabel { get; }
            public string FuelTypeName { get; }
            public string DisplayText => $"{PumpLabel} - {FuelTypeName}";
            public override string ToString() => DisplayText;
        }

        private sealed class FuelTypeLookup
        {
            public FuelTypeLookup(int fuelTypeId, string name, decimal pricePerLiter, decimal currentStock)
            {
                FuelTypeId = fuelTypeId;
                Name = name;
                PricePerLiter = pricePerLiter;
                CurrentStock = currentStock;
            }

            public int FuelTypeId { get; }
            public string Name { get; }
            public decimal PricePerLiter { get; }
            public decimal CurrentStock { get; }
            public string DisplayText => $"{FuelTypeId} - {Name}";
            public override string ToString() => DisplayText;
        }

        private sealed class EmployeeLookup
        {
            public EmployeeLookup(int employeeId, string employeeName)
            {
                EmployeeId = employeeId;
                EmployeeName = employeeName;
            }

            public int EmployeeId { get; }
            public string EmployeeName { get; }
            public string DisplayText => $"{EmployeeId} - {EmployeeName}";
            public override string ToString() => DisplayText;
        }

        private void TransactionSaleDialog_Load_1(object sender, EventArgs e)
        {
                
        }
    }
}