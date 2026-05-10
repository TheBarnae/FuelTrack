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
    public partial class Suppliers : Form
    {
        private readonly Database.Database _database = new Database.Database();
        private DataTable? _supplierTable;
        private Label? _totalSuppliersValueLabel;
        private Label? _activeContractsValueLabel;
        private Label? _pendingDeliveriesValueLabel;

        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            status_comboBox.Items.Clear();
            status_comboBox.Items.AddRange(new object[] { "Active", "Inactive" });
            status_comboBox.SelectedIndex = 0;
            InitializeSummaryPanels();
            ConfigureSupplierGrids();
            InitializeSupplierControls();
            LoadSuppliers();
            LoadSupplierStats();
            LoadDeliveryHistory();
        }

        private void ConfigureSupplierGrids()
        {
            supplierdata_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            supplierdata_dataGridView.RowHeadersVisible = false;
            supplierdata_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            supplierdata_dataGridView.ReadOnly = true;

            deliveryhistory_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            deliveryhistory_dataGridView.RowHeadersVisible = false;
            deliveryhistory_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            deliveryhistory_dataGridView.ReadOnly = true;
        }

        private void InitializeSupplierControls()
        {
            supplier_textBox.ForeColor = SystemColors.GrayText;
            LoadSupplierDropdowns();
            LoadFuelTypeDropdowns();
        }

        private void InitializeSummaryPanels()
        {
            _totalSuppliersValueLabel = CreateSummaryValueLabel(total_suppliers_pnl);
            _activeContractsValueLabel = CreateSummaryValueLabel(active_contracts_pnl);
            _pendingDeliveriesValueLabel = CreateSummaryValueLabel(pending_deliver_pnl);
        }

        private static Label CreateSummaryValueLabel(Control parent)
        {
            var valueLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                Location = new Point(12, 18),
                Text = "0"
            };

            parent.Controls.Add(valueLabel);
            return valueLabel;
        }

        private void LoadSupplierStats()
        {
            const string totalQuery = "SELECT COUNT(*) FROM Suppliers;";
            const string activeQuery = "SELECT COUNT(*) FROM Suppliers WHERE status = 'Active';";
            const string pendingQuery = "SELECT COUNT(*) FROM Deliveries WHERE status = 'Pending';";

            try
            {
                _totalSuppliersValueLabel!.Text = ExecuteScalarCount(totalQuery).ToString();
                _activeContractsValueLabel!.Text = ExecuteScalarCount(activeQuery).ToString();
                _pendingDeliveriesValueLabel!.Text = ExecuteScalarCount(pendingQuery).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load supplier stats: {ex.Message}", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ExecuteScalarCount(string query)
        {
            using var connection = _database.GetConnection();
            using var command = new MySqlCommand(query, connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private void LoadSuppliers()
        {
            const string query = @"SELECT supplier_id AS `Supplier ID`,
       company_name AS `Supplier name`,
       contact_person AS `Contact person`,
       contact_number AS `Phone`,
       email AS `Email`,
       status AS `Status`
FROM Suppliers
ORDER BY company_name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                _supplierTable = table;
                supplierdata_dataGridView.DataSource = _supplierTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load suppliers: {ex.Message}", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSupplierDropdowns()
        {
            const string query = "SELECT supplier_id, company_name FROM Suppliers ORDER BY company_name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                supplier_comboBox.DisplayMember = "company_name";
                supplier_comboBox.ValueMember = "supplier_id";
                supplier_comboBox.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load suppliers list: {ex.Message}", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFuelTypeDropdowns()
        {
            const string query = "SELECT fuel_type_id, name FROM Fuel_types ORDER BY name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                fueltype_comboBox.DisplayMember = "name";
                fueltype_comboBox.ValueMember = "fuel_type_id";
                fueltype_comboBox.DataSource = table;
                fueltypesupplied_comboBox.DisplayMember = "name";
                fueltypesupplied_comboBox.ValueMember = "fuel_type_id";
                fueltypesupplied_comboBox.DataSource = table.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load fuel types: {ex.Message}", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySupplierFilter()
        {
            if (_supplierTable == null)
            {
                return;
            }

            var searchText = supplier_textBox.Text.Trim().Replace("'", "''");
            if (string.IsNullOrWhiteSpace(searchText) || searchText.Equals("Search...", StringComparison.OrdinalIgnoreCase))
            {
                _supplierTable.DefaultView.RowFilter = string.Empty;
                return;
            }

            _supplierTable.DefaultView.RowFilter =
                $"[Supplier name] LIKE '%{searchText}%' OR [Contact person] LIKE '%{searchText}%'";
        }

        private void supplierdata_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (supplierdata_dataGridView.CurrentRow?.DataBoundItem is not DataRowView rowView)
            {
                return;
            }

            suppliername_textBox.Text = rowView["Supplier name"].ToString();
            contactperson_textBox.Text = rowView["Contact person"].ToString();
            phonenumber_textBox.Text = rowView["Phone"].ToString();
            email_textBox.Text = rowView["Email"].ToString();
            status_comboBox.SelectedItem = rowView["Status"].ToString();
        }

        private void SaveSupplier()
        {
            var companyName = suppliername_textBox.Text.Trim();
            var contactPerson = contactperson_textBox.Text.Trim();
            var contactNumber = phonenumber_textBox.Text.Trim();
            var email = email_textBox.Text.Trim();
            var status = status_comboBox.SelectedItem?.ToString() ?? "Active";

            if (string.IsNullOrWhiteSpace(companyName))
            {
                MessageBox.Show("Supplier name is required.", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedId = GetSelectedSupplierId();
            var query = selectedId.HasValue
                ? @"UPDATE Suppliers
SET company_name = @company_name,
    contact_person = @contact_person,
    contact_number = @contact_number,
    email = @email,
    status = @status
WHERE supplier_id = @supplier_id;"
                : @"INSERT INTO Suppliers (company_name, contact_person, contact_number, email, status)
VALUES (@company_name, @contact_person, @contact_number, @email, @status);";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@company_name", companyName);
                command.Parameters.AddWithValue("@contact_person", contactPerson);
                command.Parameters.AddWithValue("@contact_number", contactNumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@status", status);
                if (selectedId.HasValue)
                {
                    command.Parameters.AddWithValue("@supplier_id", selectedId.Value);
                }

                connection.Open();
                command.ExecuteNonQuery();
                LoadSuppliers();
                LoadSupplierStats();
                LoadSupplierDropdowns();
                ClearSupplierFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save supplier: {ex.Message}", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSupplier()
        {
            var selectedId = GetSelectedSupplierId();
            if (!selectedId.HasValue)
            {
                MessageBox.Show("Select a supplier to delete.", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Delete the selected supplier?", "Suppliers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            const string query = "DELETE FROM Suppliers WHERE supplier_id = @supplier_id;";
            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@supplier_id", selectedId.Value);

                connection.Open();
                command.ExecuteNonQuery();
                LoadSuppliers();
                LoadSupplierStats();
                LoadSupplierDropdowns();
                ClearSupplierFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to delete supplier: {ex.Message}", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? GetSelectedSupplierId()
        {
            if (supplierdata_dataGridView.CurrentRow?.DataBoundItem is not DataRowView rowView)
            {
                return null;
            }

            return int.TryParse(rowView["Supplier ID"].ToString(), out var id) ? id : null;
        }

        private void ClearSupplierFields()
        {
            suppliername_textBox.Clear();
            contactperson_textBox.Clear();
            phonenumber_textBox.Clear();
            email_textBox.Clear();
            status_comboBox.SelectedIndex = 0;
        }

        private void LoadDeliveryHistory()
        {
            const string query = @"SELECT d.delivery_date AS `Date`,
       s.company_name AS `Supplier`,
       f.name AS `Fuel type`,
       d.volume_liters AS `Volume (L)`,
       d.price_per_liter AS `Price/L`,
       d.dr_number AS `DR No.`,
       d.status AS `Status`
FROM Deliveries d
INNER JOIN Suppliers s ON s.supplier_id = d.supplier_id
INNER JOIN Fuel_types f ON f.fuel_type_id = d.fuel_type_id
ORDER BY d.delivery_date DESC;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                deliveryhistory_dataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load delivery history: {ex.Message}", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecordDelivery()
        {
            if (supplier_comboBox.SelectedValue == null || fueltype_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Select a supplier and fuel type.", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(volumeddeliveried_textBox.Text, out var volume) || volume <= 0)
            {
                MessageBox.Show("Enter a valid volume.", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceperliter_textBox.Text, out var pricePerLiter) || pricePerLiter < 0)
            {
                MessageBox.Show("Enter a valid price per liter.", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string query = @"INSERT INTO Deliveries (supplier_id, fuel_type_id, dr_number, volume_liters, delivery_date, price_per_liter, status)
VALUES (@supplier_id, @fuel_type_id, @dr_number, @volume_liters, @delivery_date, @price_per_liter, @status);";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@supplier_id", supplier_comboBox.SelectedValue);
                command.Parameters.AddWithValue("@fuel_type_id", fueltype_comboBox.SelectedValue);
                command.Parameters.AddWithValue("@dr_number", invoicenum_textBox.Text.Trim());
                command.Parameters.AddWithValue("@volume_liters", volume);
                command.Parameters.AddWithValue("@delivery_date", deliverydate_dateTimePicker.Value);
                command.Parameters.AddWithValue("@price_per_liter", pricePerLiter);
                command.Parameters.AddWithValue("@status", "Pending");

                connection.Open();
                command.ExecuteNonQuery();
                LoadDeliveryHistory();
                LoadSupplierStats();
                ClearDeliveryFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to record delivery: {ex.Message}", "Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDeliveryFields()
        {
            supplier_comboBox.SelectedIndex = -1;
            fueltype_comboBox.SelectedIndex = -1;
            volumeddeliveried_textBox.Clear();
            priceperliter_textBox.Clear();
            invoicenum_textBox.Clear();
            remarks_textBox.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplySupplierFilter();
        }

        private void add_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSupplier();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void supplier_textBox_Enter(object sender, EventArgs e)
        {
            if (supplier_textBox.Text.Equals("Search...", StringComparison.OrdinalIgnoreCase))
            {
                supplier_textBox.Text = string.Empty;
                supplier_textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void supplier_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(supplier_textBox.Text))
            {
                supplier_textBox.Text = "Search...";
                supplier_textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void clearsupplier_button_Click(object sender, EventArgs e)
        {
            ClearSupplierFields();
        }

        private void deletesupplier_button_Click(object sender, EventArgs e)
        {
            DeleteSupplier();
        }

        private void confirmdelivery_button_Click(object sender, EventArgs e)
        {
            RecordDelivery();
        }

        private void canceldelivery_button_Click(object sender, EventArgs e)
        {
            ClearDeliveryFields();
        }

        private void remarks_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
