using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class AdminManageReportGenarateCars : Form
    {
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;
        public AdminManageReportGenarateCars()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString); // Initialize the SqlConnection object
            LoadData(); // Load data when the form is initialized used for datagrid view
            FilterData();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();

                // Define your SQL query
                string query = "SELECT  Reg_ID, Brand, Model, Year, Colour, Price, Stock FROM Cars";

                // Create a command object
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Create a data adapter to retrieve the data
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the database
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        LabelTotalRecords.Text = $"Total records: {dataGridView.RowCount}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Close the connection
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Define your SQL query to select all data from the Cars table
                string query = "SELECT  Reg_ID, Brand, Model, Year, Colour, Price, Stock FROM Cars";

                // Create a command object
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Create a data adapter to retrieve the data
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the database
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        LabelTotalRecords.Text = $"Total records: {dataGridView.RowCount}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Close the connection
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterData() // get data to combo box
        {
            try
            {
                conn.Open();

                // Define your SQL query
                string query = "SELECT DISTINCT Brand, Model, Year FROM Cars";

                // Create a command object
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Execute the command and read the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Create HashSet to store unique values
                        HashSet<string> brandSet = new HashSet<string>();
                        Dictionary<string, HashSet<string>> brandModelMap = new Dictionary<string, HashSet<string>>();
                        Dictionary<string, HashSet<string>> modelYearMap = new Dictionary<string, HashSet<string>>();

                        // Loop through the results and add them to the corresponding HashSet and Dictionary
                        while (reader.Read())
                        {
                            string brand = reader["Brand"].ToString();
                            string model = reader["Model"].ToString();
                            string year = reader["Year"].ToString();

                            brandSet.Add(brand);

                            if (!brandModelMap.ContainsKey(brand))
                                brandModelMap[brand] = new HashSet<string>();

                            brandModelMap[brand].Add(model);

                            string brandModel = brand + "|" + model;

                            if (!modelYearMap.ContainsKey(brandModel))
                                modelYearMap[brandModel] = new HashSet<string>();

                            modelYearMap[brandModel].Add(year);
                        }

                        // Clear existing items in the ComboBox
                        CbbxBrand.Items.Clear();
                        CbbxModel.Items.Clear();
                        CbbxYear.Items.Clear();

                        // Add unique values from HashSet to ComboBox
                        foreach (string brand in brandSet)
                        {
                            CbbxBrand.Items.Add(brand);
                        }

                        // Handle ComboBox selected index changed event for CbbxBrand
                        CbbxBrand.SelectedIndexChanged += (sender, e) =>
                        {
                            string selectedBrand = CbbxBrand.SelectedItem.ToString();
                            UpdateDataGridView(selectedBrand, null, null);
                            CbbxModel.Items.Clear();
                            CbbxYear.Items.Clear();

                            if (brandModelMap.ContainsKey(selectedBrand))
                            {
                                foreach (string model in brandModelMap[selectedBrand])
                                {
                                    CbbxModel.Items.Add(model);
                                }
                            }
                        };

                        // Handle ComboBox selected index changed event for CbbxModel
                        CbbxModel.SelectedIndexChanged += (sender, e) =>
                        {
                            string selectedBrand = CbbxBrand.SelectedItem.ToString();
                            string selectedModel = CbbxModel.SelectedItem.ToString();
                            UpdateDataGridView(selectedBrand, selectedModel, null);
                            CbbxYear.Items.Clear();

                            string selectedBrandModel = selectedBrand + "|" + selectedModel;
                            if (modelYearMap.ContainsKey(selectedBrandModel))
                            {
                                foreach (string year in modelYearMap[selectedBrandModel])
                                {
                                    CbbxYear.Items.Add(year);
                                }
                            }
                        };

                        // Handle ComboBox selected index changed event for CbbxYear
                        CbbxYear.SelectedIndexChanged += (sender, e) =>
                        {
                            string selectedBrand = CbbxBrand.SelectedItem.ToString();
                            string selectedModel = CbbxModel.SelectedItem.ToString();
                            string selectedYear = CbbxYear.SelectedItem.ToString();
                            UpdateDataGridView(selectedBrand, selectedModel, selectedYear);

                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Close the connection
            }
        }

        // Method to update DataGridView based on selected values
        private void UpdateDataGridView(string brand, string model, string year)
        {
            try
            {
                conn.Open();

                // Define your SQL query
                string query = "SELECT  Reg_ID, Brand, Model, Year, Colour, Price, Stock FROM Cars WHERE Brand = @Brand";
                if (!string.IsNullOrEmpty(model))
                    query += " AND Model = @Model";
                if (!string.IsNullOrEmpty(year))
                    query += " AND Year = @Year";

                // Create a command object
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Brand", brand);
                    if (!string.IsNullOrEmpty(model))
                        command.Parameters.AddWithValue("@Model", model);
                    if (!string.IsNullOrEmpty(year))
                        command.Parameters.AddWithValue("@Year", year);

                    // Create a data adapter to retrieve the data
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the database
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        LabelTotalRecords.Text = $"Total records: {dataGridView.RowCount}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Close the connection
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define the print area and margins
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float width = e.MarginBounds.Width;
            float height = 0;

            // Define the header font and brush for BIG header
            Font BIGheaderFont = new Font("Arial", 18, FontStyle.Bold);
            SolidBrush BIGheaderBrush = new SolidBrush(Color.DarkBlue); // Change color to dark blue

            // Define the header font and brush for regular header
            Font headerFont = new Font("Arial", 15, FontStyle.Bold | FontStyle.Underline); // Add underline to regular font
            SolidBrush headerBrush = new SolidBrush(Color.Black);

            // Define string format for center alignment
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // Calculate the height of the BIG header
            float bigHeaderHeight = BIGheaderFont.GetHeight(e.Graphics);

            // Draw the BIG header text
            RectangleF bigHeaderRect = new RectangleF(x, y, width, bigHeaderHeight);
            e.Graphics.DrawString("ABC CAR TRADERS", BIGheaderFont, BIGheaderBrush, bigHeaderRect, stringFormat);

            // Move the y position down for the next line after BIG header
            y += bigHeaderHeight;

            // Calculate the height of the regular header
            float headerHeightRegular = headerFont.GetHeight(e.Graphics); // Rename to avoid conflict

            // Draw the regular header text
            RectangleF headerRectRegular = new RectangleF(x, y, width, headerHeightRegular); // Rename to avoid conflict
            e.Graphics.DrawString("Cars Details", headerFont, headerBrush, headerRectRegular, stringFormat);

            // Add more space between header and table
            y += headerHeightRegular * 2;

            // Define the regular font and brush
            Font regularFont = new Font("Arial", 10);
            SolidBrush regularBrush = new SolidBrush(Color.Black);

            // Define the table headers font and brush
            Font tableHeaderFont = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush tableHeaderBrush = new SolidBrush(Color.Black);

            // Calculate the height of the table row (including headers)
            height = regularFont.GetHeight(e.Graphics);

            // Define the table headers
            string[] headers = dataGridView.Columns.Cast<DataGridViewColumn>()
                                                    .Select(c => c.HeaderText)
                                                    .ToArray();

            // Loop through each row in the DataGridView and print the data
            for (int rowIndex = 0; rowIndex < dataGridView.Rows.Count; rowIndex++)
            {
                if (rowIndex == 0) // Skip the first row (header row)
                {
                    // Draw the table headers
                    for (int i = 0; i < headers.Length; i++)
                    {
                        e.Graphics.DrawString(headers[i], tableHeaderFont, tableHeaderBrush, x, y);

                        // Move x to the right for the next cell
                        x += width / headers.Length;
                    }

                    // Move y down for the next row
                    y += height;
                }
                else
                {
                    DataGridViewRow row = dataGridView.Rows[rowIndex];

                    // Reset x
                    x = e.MarginBounds.Left;

                    // Loop through each cell in the row and print the data
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            e.Graphics.DrawString(cell.Value.ToString(), regularFont, regularBrush, x, y);
                        }

                        // Move x to the right for the next cell
                        x += width / headers.Length;
                    }

                    // Move y down for the next row
                    y += height;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManageReportGenaratingDashBoard objback = new AdminManageReportGenaratingDashBoard();
            objback.Show();
            this.Close();
        }

        private void AdminManageReportGenarateCars_Load(object sender, EventArgs e)
        {

        }
    }
}
