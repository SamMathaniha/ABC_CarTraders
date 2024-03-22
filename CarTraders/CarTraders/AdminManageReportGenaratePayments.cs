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
    public partial class AdminManageReportGenaratePayments : Form
    {
        // Connection string
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;
        public AdminManageReportGenaratePayments()
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
                string query = "SELECT  PayID, NIC, OrderID, Amount, PaymentDate FROM Payments ORDER BY PayID";

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

                        decimal totalAmount = 0;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (row["Amount"] != DBNull.Value)
                            {
                                totalAmount += Convert.ToDecimal(row["Amount"]);
                            }
                        }

                        txtbxTotalAmount.Text = $"Rs {totalAmount}"; // Fix formatting
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


        private void btnLoadBetweenDate_Click(object sender, EventArgs e) // load by the Dates
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT PayID, NIC, OrderID,  Amount, PaymentDate FROM Payments WHERE PaymentDate BETWEEN @dtFromDate AND @dtToDate ORDER BY PaymentDate DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@dtFromDate", dtFrom.Value);
                        cmd.Parameters.AddWithValue("@dtToDate", dtTo.Value);

                        DataTable dt = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(dt);

                        dataGridView.DataSource = dt;

                        decimal totalAmount = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["Amount"] != DBNull.Value)
                            {
                                totalAmount += Convert.ToDecimal(row["Amount"]);
                            }
                        }

                        txtbxTotalAmount.Text = $"Rs {totalAmount}"; // Fix formatting
                        LabelTotalRecords.Text = $"Total records: {dataGridView.RowCount}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float width = e.MarginBounds.Width;
            float height = 0;

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            SolidBrush headerBrush = new SolidBrush(Color.Black);

            height = headerFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Payment Report", headerFont, headerBrush, x, y);
            y += height;

            Font regularFont = new Font("Arial", 10);
            SolidBrush regularBrush = new SolidBrush(Color.Black);

            string[] headers = new string[dataGridView.Columns.Count];
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                headers[i] = dataGridView.Columns[i].HeaderText;
            }

            height = regularFont.GetHeight(e.Graphics);
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], regularFont, regularBrush, x, y);
                x += width / headers.Length;
            }

            y += height;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                x = e.MarginBounds.Left;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        e.Graphics.DrawString(cell.Value.ToString(), regularFont, regularBrush, x, y);
                    }
                    x += width / headers.Length;
                }
                y += height;
            }

            // Assuming TotalAmount is a TextBox control, you can get its text and display it.
            string totalAmountText = txtbxTotalAmount.Text;

            // Create a new Font for the total income message
            Font totalFont = new Font("Arial", 10, FontStyle.Bold);

            // Create a red brush for the total income message
            SolidBrush totalBrush = new SolidBrush(Color.Red);

            // Calculate the position to display the total income message
            x = e.MarginBounds.Left;
            y += height; // Move down by the height of the last row

            // Display the total income message
            string totalIncomeMessage = "Total income is: " + totalAmountText;
            e.Graphics.DrawString(totalIncomeMessage, totalFont, totalBrush, x, y);

            // Dispose of the fonts and brushes
            headerFont.Dispose();
            headerBrush.Dispose();
            regularFont.Dispose();
            regularBrush.Dispose();
            totalFont.Dispose();
            totalBrush.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManageReportGenaratingDashBoard rtn = new AdminManageReportGenaratingDashBoard();
            rtn.Show();
            this.Close();
        }

        private void txtbxTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
