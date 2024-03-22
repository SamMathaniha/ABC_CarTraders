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
    public partial class AdminManageReportGenarateOrders : Form
    {
        // Connection string
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;
        public AdminManageReportGenarateOrders()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString); // Initialize the SqlConnection object
            LoadData(); // Load data when the form is initialized used for datagrid view
        }

        private void LoadData()
        {
            try
            {
                conn.Open();

                // Define your SQL query
                string query = "SELECT ID, NIC, RegID, Item, Price, OrderDate FROM Orders ORDER BY OrderDate";

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


        private void button3_Click(object sender, EventArgs e)
        {
            AdminManageReportGenaratingDashBoard back = new AdminManageReportGenaratingDashBoard();
            back.Show();
            this.Close();
        }

        private void AdminManageReportGenarateOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadBetweenDate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ID, NIC, RegID, Item, Price, OrderDate FROM Orders WHERE OrderDate BETWEEN @dtFromDate AND @dtToDate ORDER BY OrderDate DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@dtFromDate", dtFrom.Value);
                        cmd.Parameters.AddWithValue("@dtToDate", dtTo.Value);

                        DataTable dt = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(dt);

                        dataGridView.DataSource = dt;

                        LabelTotalRecords.Text = $"Total records: {dataGridView.RowCount}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
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
            e.Graphics.DrawString("Orders Report", headerFont, headerBrush, headerRectRegular, stringFormat);

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
    }
}
