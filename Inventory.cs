using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static FuelTrack.UIHelper;
using MySql.Data.MySqlClient;

namespace FuelTrack
{
    public partial class Inventory : Form
    {
        private Color _logoutOriginalColor;
        private readonly Database.Database _database = new Database.Database();
        private DataTable? _inventoryTable;
        public Inventory()
        {
            InitializeComponent();
            UIHelper.MakeCircular(usr_avatar);
            UIHelper.StyleFuelTrackTitle(richTextBox1);
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            UIHelper.setDateLabel(date_label);
            UIHelper.SetButtonActive(inv_btn, true);
            UIHelper.DisableCloseButton(this);
            ConfigureInventoryGrid();
            LoadFuelInventory();
            fuelInventory_label.BringToFront();
            inventory_search.BringToFront();
            inventorysadd_button.BringToFront();
            inventory_search.ForeColor = SystemColors.GrayText;
        }

        private void LoadFuelInventory()
        {
            const string query = @"SELECT fuel_type_id AS `Fuel Type ID`,
       name AS `Fuel type`,
       current_stock_liters AS `Current stock (L)`,
       min_stock_threshold AS `Min threshold (L)`,
       price_per_liter AS `Price/L`,
       status AS `Status`,
       updated_at AS `Updated at`
FROM Fuel_types
ORDER BY fuel_type_id, name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                _inventoryTable = table;
                fuelInventorys_dataGridView.DataSource = _inventoryTable;
                RemoveInventoryDuplicates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load fuel inventory: {ex.Message}", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveInventoryDuplicates()
        {
            if (_inventoryTable == null)
            {
                return;
            }

            var seenIds = new HashSet<int>();
            for (var i = _inventoryTable.Rows.Count - 1; i >= 0; i--)
            {
                var row = _inventoryTable.Rows[i];
                if (!int.TryParse(row["Fuel Type ID"].ToString(), out var id))
                {
                    continue;
                }

                if (!seenIds.Add(id))
                {
                    _inventoryTable.Rows.RemoveAt(i);
                }
            }

            _inventoryTable.AcceptChanges();
        }

        private void ApplyInventoryFilter()
        {
            if (_inventoryTable == null)
            {
                return;
            }

            var searchText = inventory_search.Text.Trim().Replace("'", "''");
            if (string.IsNullOrWhiteSpace(searchText) || searchText.Equals("Search...", StringComparison.OrdinalIgnoreCase))
            {
                _inventoryTable.DefaultView.RowFilter = string.Empty;
                return;
            }

            _inventoryTable.DefaultView.RowFilter = $"[Fuel type] LIKE '%{searchText}%'";
        }

        private void ConfigureInventoryGrid()
        {
            fuelInventorys_dataGridView.AutoGenerateColumns = true;
            fuelInventorys_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fuelInventorys_dataGridView.RowHeadersVisible = false;
            fuelInventorys_dataGridView.AllowUserToAddRows = false;
            fuelInventorys_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            fuelInventorys_dataGridView.ReadOnly = true;
            fuelInventorys_dataGridView.CellFormatting += fuelInventorys_dataGridView_CellFormatting;

            if (fuelInventorys_dataGridView.Columns["Edit"] == null)
            {
                var editColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Action",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };

                fuelInventorys_dataGridView.Columns.Add(editColumn);
            }
        }

        private void fuelInventorys_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = fuelInventorys_dataGridView;
            if (grid.Columns[e.ColumnIndex].Name != "Status")
            {
                return;
            }

            var currentStockCell = grid.Rows[e.RowIndex].Cells["Current stock (L)"];
            var minStockCell = grid.Rows[e.RowIndex].Cells["Min threshold (L)"];

            if (!decimal.TryParse(currentStockCell.Value?.ToString(), out var currentStock)
                || !decimal.TryParse(minStockCell.Value?.ToString(), out var minStock))
            {
                return;
            }

            var cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (minStock > 0 && currentStock < minStock * 0.2m)
            {
                cell.Value = "Critical";
                cell.Style.BackColor = ColorTranslator.FromHtml("#FCEBEB");
                cell.Style.ForeColor = ColorTranslator.FromHtml("#791F1F");
            }
            else if (currentStock > minStock)
            {
                cell.Value = "Normal";
                cell.Style.BackColor = ColorTranslator.FromHtml("#EAF3DE");
                cell.Style.ForeColor = ColorTranslator.FromHtml("#27500A");
            }
            else
            {
                cell.Value = "Low Stock";
                cell.Style.BackColor = ColorTranslator.FromHtml("#FAEEDA");
                cell.Style.ForeColor = ColorTranslator.FromHtml("#633806");
            }
        }

        private void menubar_dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void inventory_search_TextChanged(object sender, EventArgs e)
        {
            ApplyInventoryFilter();
        }

        private void inventory_search_Enter(object sender, EventArgs e)
        {
            if (inventory_search.Text.Equals("Search...", StringComparison.OrdinalIgnoreCase))
            {
                inventory_search.Text = string.Empty;
                inventory_search.ForeColor = SystemColors.WindowText;
            }
        }

        private void inventory_search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventory_search.Text))
            {
                inventory_search.Text = "Search...";
                inventory_search.ForeColor = SystemColors.GrayText;
            }
        }

        private void inventorysadd_button_Click(object sender, EventArgs e)
        {
            using var dialog = new AddFuelTypeDialog();
            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            if (AddFuelType(dialog.FuelName, dialog.CurrentStock, dialog.MinStock, dialog.PricePerLiter))
            {
                LoadFuelInventory();
            }
        }

        private bool AddFuelType(string name, decimal currentStock, decimal minStock, decimal pricePerLiter)
        {
            const string query = @"INSERT INTO Fuel_types (name, current_stock_liters, min_stock_threshold, price_per_liter, status, updated_at)
VALUES (@name, @current_stock, @min_stock, @price_per_liter, @status, NOW());";

            var status = currentStock <= 0
                ? "Out of Stock"
                : currentStock <= minStock
                    ? "Low"
                    : "Available";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@current_stock", currentStock);
                command.Parameters.AddWithValue("@min_stock", minStock);
                command.Parameters.AddWithValue("@price_per_liter", pricePerLiter);
                command.Parameters.AddWithValue("@status", status);

                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to add fuel type: {ex.Message}", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private sealed class AddFuelTypeDialog : Form
        {
            private readonly TextBox _nameTextBox = new TextBox();
            private readonly NumericUpDown _currentStockInput = new NumericUpDown();
            private readonly NumericUpDown _minStockInput = new NumericUpDown();
            private readonly NumericUpDown _priceInput = new NumericUpDown();
            private readonly Button _okButton = new Button();
            private readonly Button _cancelButton = new Button();

            public AddFuelTypeDialog()
            {
                Text = "Add Fuel Type";
                FormBorderStyle = FormBorderStyle.FixedDialog;
                StartPosition = FormStartPosition.CenterParent;
                MaximizeBox = false;
                MinimizeBox = false;
                ClientSize = new Size(320, 230);

                var nameLabel = new Label { Text = "Fuel type", Location = new Point(16, 16), AutoSize = true };
                _nameTextBox.Location = new Point(16, 36);
                _nameTextBox.Width = 280;

                var currentLabel = new Label { Text = "Current stock (L)", Location = new Point(16, 66), AutoSize = true };
                _currentStockInput.Location = new Point(16, 86);
                _currentStockInput.Maximum = 1_000_000;
                _currentStockInput.DecimalPlaces = 2;
                _currentStockInput.Width = 140;

                var minLabel = new Label { Text = "Min level (L)", Location = new Point(176, 66), AutoSize = true };
                _minStockInput.Location = new Point(176, 86);
                _minStockInput.Maximum = 1_000_000;
                _minStockInput.DecimalPlaces = 2;
                _minStockInput.Width = 120;

                var priceLabel = new Label { Text = "Price per liter", Location = new Point(16, 116), AutoSize = true };
                _priceInput.Location = new Point(16, 136);
                _priceInput.Maximum = 1_000_000;
                _priceInput.DecimalPlaces = 2;
                _priceInput.Width = 140;

                _okButton.Text = "Add";
                _okButton.Location = new Point(156, 180);
                _okButton.DialogResult = DialogResult.OK;
                _okButton.Click += (_, _) => ValidateAndClose();

                _cancelButton.Text = "Cancel";
                _cancelButton.Location = new Point(236, 180);
                _cancelButton.DialogResult = DialogResult.Cancel;

                Controls.Add(nameLabel);
                Controls.Add(_nameTextBox);
                Controls.Add(currentLabel);
                Controls.Add(_currentStockInput);
                Controls.Add(minLabel);
                Controls.Add(_minStockInput);
                Controls.Add(priceLabel);
                Controls.Add(_priceInput);
                Controls.Add(_okButton);
                Controls.Add(_cancelButton);

                AcceptButton = _okButton;
                CancelButton = _cancelButton;
            }

            public string FuelName => _nameTextBox.Text.Trim();
            public decimal CurrentStock => _currentStockInput.Value;
            public decimal MinStock => _minStockInput.Value;
            public decimal PricePerLiter => _priceInput.Value;

            private void ValidateAndClose()
            {
                if (string.IsNullOrWhiteSpace(FuelName))
                {
                    MessageBox.Show("Fuel type is required.", "Add Fuel Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
