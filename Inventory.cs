using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static FuelTrack.UIHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace FuelTrack
{
    public partial class Inventory : Form
    {
        private Color _logoutOriginalColor;
        private readonly Database.Database _database = new Database.Database();
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
        }

        private void LoadFuelInventory()
        {
            const string query = @"SELECT name AS `Fuel type`,
       current_stock_liters AS `Current stock (L)`,
       min_stock_threshold AS `Min threshold (L)`,
       price_per_liter AS `Price/L`,
       status AS `Status`,
       updated_at AS `Updated at`
       FROM Fuel_types
       ORDER BY name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                fuelInventorys_dataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load fuel inventory: {ex.Message}", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
