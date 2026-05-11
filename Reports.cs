using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FuelTrack
{
    public partial class Reports : Form
    {
        private readonly Database.Database _database = new Database.Database();
        private DataTable? _currentReportTable;
        private string _lastReportType = string.Empty;
        private DateTime _lastDateStart = DateTime.Today;
        private DateTime _lastDateEnd = DateTime.Today.AddDays(1);
        private int? _lastFuelTypeId;

        private static readonly string[] ReportTypes =
        [
            "Daily Sales Summary",
            "Monthly Revenue Report",
            "Inventory Movement Report",
            "Shift & Employee Report",
            "Supplier Delivery Log",
            "Fuel Price History",
            "Audit Trail Log"
        ];

        public Reports()
        {
            InitializeComponent();
            Load += Reports_Load;
            button1.Click += btnGenerate_Click;
            exportpdf_button.Click += btnExportPDF_Click;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            UIHelper.setDateLabel(date_label);
            UIHelper.SetButtonActive(reports_Btn, true);
            UIHelper.DisableCloseButton(this);
            ConfigureGrids();
            PopulateReportTypes();
            PopulateFuelTypes();
            button1.Text = "Generate";
            if (reporttype_comboBox.Items.Count > 0)
            {
                reporttype_comboBox.SelectedIndex = 0;
            }
        }

        private void ConfigureGrids()
        {
            generatereport_dataGridView.AutoGenerateColumns = true;
            generatereport_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            generatereport_dataGridView.RowHeadersVisible = false;
            generatereport_dataGridView.ReadOnly = true;
            generatereport_dataGridView.AllowUserToAddRows = false;
            generatereport_dataGridView.AllowUserToDeleteRows = false;
            generatereport_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            reporttypes_dataGridView.AutoGenerateColumns = true;
            reporttypes_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reporttypes_dataGridView.RowHeadersVisible = false;
            reporttypes_dataGridView.ReadOnly = true;
            reporttypes_dataGridView.AllowUserToAddRows = false;
            reporttypes_dataGridView.AllowUserToDeleteRows = false;
            reporttypes_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void PopulateReportTypes()
        {
            reporttype_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            reporttype_comboBox.Items.Clear();
            reporttype_comboBox.Items.AddRange(ReportTypes);

            var table = new DataTable();
            table.Columns.Add("Report Type");
            foreach (var reportType in ReportTypes)
            {
                table.Rows.Add(reportType);
            }

            reporttypes_dataGridView.DataSource = table;
        }

        private void PopulateFuelTypes()
        {
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Clear();
            comboBox2.Items.Add(new FuelTypeItem(null, "All Fuel Types"));

            const string query = @"
                SELECT fuel_type_id, name
                FROM fuel_types
                ORDER BY name;";

            try
            {
                using var connection = _database.GetConnection();
                using var command = new MySqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(new FuelTypeItem(
                        reader.GetInt32("fuel_type_id"),
                        reader.GetString("name")));
                }

                comboBox2.DisplayMember = nameof(FuelTypeItem.DisplayText);
                comboBox2.ValueMember = nameof(FuelTypeItem.FuelTypeId);
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load fuel types: {ex.Message}", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object? sender, EventArgs e)
        {
            if (reporttype_comboBox.SelectedItem is not string reportType)
            {
                MessageBox.Show("Please select a report type.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDate = daterange_dateTimePicker.Value.Date;
            var fuelTypeId = GetSelectedFuelTypeId();
            var (startDate, endDate) = GetReportDateWindow(reportType, selectedDate);

            try
            {
                var table = BuildReportTable(reportType, startDate, endDate, fuelTypeId);
                _currentReportTable = table;
                _lastReportType = reportType;
                _lastDateStart = startDate;
                _lastDateEnd = endDate;
                _lastFuelTypeId = fuelTypeId;
                generatereport_dataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to generate report: {ex.Message}", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable BuildReportTable(string reportType, DateTime startDate, DateTime endDate, int? fuelTypeId)
        {
            return reportType switch
            {
                "Daily Sales Summary" => LoadDailySalesSummary(startDate, endDate, fuelTypeId),
                "Monthly Revenue Report" => LoadMonthlyRevenueReport(startDate, endDate, fuelTypeId),
                "Inventory Movement Report" => LoadInventoryMovementReport(fuelTypeId),
                "Shift & Employee Report" => LoadShiftEmployeeReport(startDate, endDate),
                "Supplier Delivery Log" => LoadSupplierDeliveryLog(startDate, endDate, fuelTypeId),
                "Fuel Price History" => LoadFuelPriceHistory(startDate, endDate, fuelTypeId),
                "Audit Trail Log" => LoadAuditTrailLog(startDate, endDate),
                _ => throw new InvalidOperationException("Unknown report type.")
            };
        }

        private DataTable LoadDailySalesSummary(DateTime startDate, DateTime endDate, int? fuelTypeId)
        {
            const string query = @"
                SELECT
                    t.transaction_id AS `Transaction ID`,
                    DATE_FORMAT(t.transaction_date, '%Y-%m-%d %H:%i') AS `Transaction Date`,
                    ft.name AS `Fuel Type`,
                    t.liters_dispensed AS `Liters Dispensed`,
                    t.amount_paid AS `Amount Paid`,
                    t.payment_method AS `Payment Method`
                FROM transactions t
                INNER JOIN fuel_types ft ON ft.fuel_type_id = t.fuel_type_id
                WHERE t.transaction_date >= @start_date
                  AND t.transaction_date < @end_date
                  AND (@fuel_type_id IS NULL OR t.fuel_type_id = @fuel_type_id)
                ORDER BY t.transaction_date DESC;";

            return ExecuteTable(query, startDate, endDate, fuelTypeId);
        }

        private DataTable LoadMonthlyRevenueReport(DateTime startDate, DateTime endDate, int? fuelTypeId)
        {
            const string query = @"
                SELECT
                    DATE_FORMAT(t.transaction_date, '%Y-%m') AS `Month`,
                    COUNT(*) AS `Transactions`,
                    SUM(t.amount_paid) AS `Total Revenue`
                FROM transactions t
                WHERE t.transaction_date >= @start_date
                  AND t.transaction_date < @end_date
                  AND (@fuel_type_id IS NULL OR t.fuel_type_id = @fuel_type_id)
                GROUP BY DATE_FORMAT(t.transaction_date, '%Y-%m')
                ORDER BY `Month` DESC;";

            return ExecuteTable(query, startDate, endDate, fuelTypeId);
        }

        private DataTable LoadInventoryMovementReport(int? fuelTypeId)
        {
            const string query = @"
                SELECT
                    fuel_type_id AS `Fuel Type ID`,
                    name AS `Fuel Type`,
                    current_stock_liters AS `Current Stock (L)`,
                    min_stock_threshold AS `Min Threshold (L)`,
                    status AS `Status`,
                    updated_at AS `Updated At`
                FROM fuel_types
                WHERE (@fuel_type_id IS NULL OR fuel_type_id = @fuel_type_id)
                ORDER BY name;";

            return ExecuteTable(query, fuelTypeId: fuelTypeId);
        }

        private DataTable LoadShiftEmployeeReport(DateTime startDate, DateTime endDate)
        {
            const string query = @"
                SELECT
                    e.employee_id AS `Employee ID`,
                    u.full_name AS `Full Name`,
                    u.username AS `Username`,
                    u.role AS `Role`,
                    e.shift AS `Shift`,
                    u.status AS `Status`,
                    e.created_at AS `Created At`
                FROM employees e
                INNER JOIN users u ON u.user_id = e.user_id
                WHERE e.created_at >= @start_date
                  AND e.created_at < @end_date
                ORDER BY e.employee_id DESC;";

            return ExecuteTable(query, startDate, endDate);
        }

        private DataTable LoadSupplierDeliveryLog(DateTime startDate, DateTime endDate, int? fuelTypeId)
        {
            const string query = @"
                SELECT
                    d.delivery_id AS `Delivery ID`,
                    s.company_name AS `Supplier`,
                    ft.name AS `Fuel Type`,
                    d.dr_number AS `DR Number`,
                    d.volume_liters AS `Volume (L)`,
                    DATE_FORMAT(d.delivery_date, '%Y-%m-%d %H:%i') AS `Delivery Date`,
                    u.full_name AS `Received By`
                FROM deliveries d
                LEFT JOIN suppliers s ON s.supplier_id = d.supplier_id
                LEFT JOIN fuel_types ft ON ft.fuel_type_id = d.fuel_type_id
                LEFT JOIN users u ON u.user_id = d.received_by
                WHERE d.delivery_date >= @start_date
                  AND d.delivery_date < @end_date
                  AND (@fuel_type_id IS NULL OR d.fuel_type_id = @fuel_type_id)
                ORDER BY d.delivery_date DESC;";

            return ExecuteTable(query, startDate, endDate, fuelTypeId);
        }

        private DataTable LoadFuelPriceHistory(DateTime startDate, DateTime endDate, int? fuelTypeId)
        {
            const string query = @"
                SELECT
                    fuel_type_id AS `Fuel Type ID`,
                    name AS `Fuel Type`,
                    price_per_liter AS `Price/L`,
                    updated_at AS `Updated At`
                FROM fuel_types
                WHERE updated_at >= @start_date
                  AND updated_at < @end_date
                  AND (@fuel_type_id IS NULL OR fuel_type_id = @fuel_type_id)
                ORDER BY updated_at DESC;";

            return ExecuteTable(query, startDate, endDate, fuelTypeId);
        }

        private DataTable LoadAuditTrailLog(DateTime startDate, DateTime endDate)
        {
            const string query = @"
                SELECT
                    a.audit_id AS `Audit ID`,
                    u.full_name AS `User`,
                    a.module AS `Module`,
                    a.action_type AS `Action Type`,
                    a.description AS `Description`,
                    DATE_FORMAT(a.action_date, '%Y-%m-%d %H:%i') AS `Action Date`
                FROM audit_trail a
                LEFT JOIN users u ON u.user_id = a.user_id
                WHERE a.action_date >= @start_date
                  AND a.action_date < @end_date
                ORDER BY a.action_date DESC;";

            return ExecuteTable(query, startDate, endDate);
        }

        private DataTable ExecuteTable(string query, DateTime? startDate = null, DateTime? endDate = null, int? fuelTypeId = null)
        {
            using var connection = _database.GetConnection();
            using var command = new MySqlCommand(query, connection);

            if (startDate.HasValue)
            {
                command.Parameters.AddWithValue("@start_date", startDate.Value);
            }

            if (endDate.HasValue)
            {
                command.Parameters.AddWithValue("@end_date", endDate.Value);
            }

            command.Parameters.AddWithValue("@fuel_type_id", fuelTypeId.HasValue ? fuelTypeId.Value : DBNull.Value);

            using var adapter = new MySqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private static (DateTime Start, DateTime End) GetReportDateWindow(string reportType, DateTime selectedDate)
        {
            return reportType == "Monthly Revenue Report"
                ? (new DateTime(selectedDate.Year, selectedDate.Month, 1), new DateTime(selectedDate.Year, selectedDate.Month, 1).AddMonths(1))
                : (selectedDate.Date, selectedDate.Date.AddDays(1));
        }

        private int? GetSelectedFuelTypeId()
        {
            if (comboBox2.SelectedItem is not FuelTypeItem fuelType)
            {
                return null;
            }

            return fuelType.FuelTypeId;
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (_currentReportTable == null || _currentReportTable.Rows.Count == 0)
            {
                MessageBox.Show("Generate a report first.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Export Report to PDF",
                FileName = $"{_lastReportType}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                ExportTableToPdf(_currentReportTable, saveFileDialog.FileName, _lastReportType, _lastDateStart, _lastDateEnd, _lastFuelTypeId);
                SaveReportRecord(saveFileDialog.FileName);
                MessageBox.Show("PDF exported successfully.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to export PDF: {ex.Message}", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportTableToPdf(DataTable table, string filePath, string reportType, DateTime startDate, DateTime endDate, int? fuelTypeId)
        {
            using var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            var document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
            var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, stream);
            document.Open();

            var titleFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 16);
            var headerFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 9);
            var bodyFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8);

            document.Add(new iTextSharp.text.Paragraph(reportType, titleFont));
            document.Add(new iTextSharp.text.Paragraph($"Date Range: {startDate:yyyy-MM-dd} to {endDate.AddTicks(-1):yyyy-MM-dd}", bodyFont));
            document.Add(new iTextSharp.text.Paragraph($"Fuel Type: {GetFuelTypeText(fuelTypeId)}", bodyFont));
            document.Add(new iTextSharp.text.Paragraph($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", bodyFont));
            document.Add(new iTextSharp.text.Paragraph(" "));

            var pdfTable = new iTextSharp.text.pdf.PdfPTable(GetVisibleColumnCount(table));
            pdfTable.WidthPercentage = 100;

            foreach (DataColumn column in table.Columns)
            {
                var cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.ColumnName, headerFont));
                pdfTable.AddCell(cell);
            }

            foreach (DataRow row in table.Rows)
            {
                foreach (var value in row.ItemArray)
                {
                    pdfTable.AddCell(new iTextSharp.text.Phrase(value?.ToString() ?? string.Empty, bodyFont));
                }
            }

            document.Add(pdfTable);
            document.Close();
            writer.Close();
        }

        private static int GetVisibleColumnCount(DataTable table)
        {
            return table.Columns.Count;
        }

        private void SaveReportRecord(string filePath)
        {
            const string query = @"
                INSERT INTO reports (generated_by, report_type, date_range_start, date_range_end, generated_at, export_path)
                VALUES (@generated_by, @report_type, @date_range_start, @date_range_end, NOW(), @export_path);";

            using var connection = _database.GetConnection();
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@generated_by", GetCurrentUserId());
            command.Parameters.AddWithValue("@report_type", _lastReportType);
            command.Parameters.AddWithValue("@date_range_start", _lastDateStart);
            command.Parameters.AddWithValue("@date_range_end", _lastDateEnd);
            command.Parameters.AddWithValue("@export_path", filePath);
            connection.Open();
            command.ExecuteNonQuery();
        }

        private int GetCurrentUserId()
        {
            if (SessionContext.CurrentUser is null)
            {
                throw new InvalidOperationException("No logged-in user is available.");
            }

            const string query = @"
                SELECT u.user_id
                FROM employees e
                INNER JOIN users u ON u.user_id = e.user_id
                WHERE e.employee_id = @employee_id
                LIMIT 1;";

            using var connection = _database.GetConnection();
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@employee_id", SessionContext.CurrentUser.EmployeeId);
            connection.Open();
            var result = command.ExecuteScalar();
            if (result == null || result == DBNull.Value)
            {
                throw new InvalidOperationException("Unable to determine the current user id.");
            }

            return Convert.ToInt32(result);
        }

        private static string GetFuelTypeText(int? fuelTypeId)
        {
            return fuelTypeId.HasValue ? $"Fuel Type ID {fuelTypeId.Value}" : "All Fuel Types";
        }

        private sealed class FuelTypeItem
        {
            public FuelTypeItem(int? fuelTypeId, string name)
            {
                FuelTypeId = fuelTypeId;
                Name = name;
            }

            public int? FuelTypeId { get; }
            public string Name { get; }
            public string DisplayText => Name;
            public override string ToString() => Name;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void Reports_Load_1(object sender, EventArgs e)
        {

        }
    }
}
