using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class AdminManageOrderDetailsDashboard : Form
    {
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;
        public AdminManageOrderDetailsDashboard()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString); // Initialize the SqlConnection object
            LoadData(); // Load data when the form is initialized used for datagrid view
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard home = new AdminDashboard();
            home.Show();
            this.Close();
        }

        private void LoadData()
        {
            try
            {

                conn.Open();

                // Define your SQL query
                string query = "SELECT * FROM Orders";

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

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Retrieve data from the selected row
                string ID = selectedRow.Cells["ID"].Value.ToString();
                string OrderDate = selectedRow.Cells["OrderDate"].Value.ToString();
                string RegID = selectedRow.Cells["RegID"].Value.ToString();
                string Item = selectedRow.Cells["Item"].Value.ToString();
                string Type = selectedRow.Cells["Type"].Value.ToString();
                decimal Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                string PaymentStatus = selectedRow.Cells["PaymentStatus"].Value.ToString();
                string DeliveryStatus = selectedRow.Cells["DeliveryStatus"].Value.ToString();
                string NIC = selectedRow.Cells["NIC"].Value.ToString();


                // Create a new instance of AdminManageOrderDetailsCheckform form
                AdminManageOrderDetailsCheckform CheckOrders = new AdminManageOrderDetailsCheckform();

                // Populate the fields in the form with the data from the selected row             
                CheckOrders.PopulateFields(ID, OrderDate, RegID, Item, Type, Price, PaymentStatus, DeliveryStatus, NIC);


                // Show the AdminManageOrderDetailsCheckform form
                CheckOrders.Show();
                this.Close();

            }
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string ID = txtbxSearchOrderByID.Text;


                // Use parameterized query to prevent SQL injection
                string query = "SELECT * FROM Orders WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // This block will be executed whether an exception occurred or not
                // Ensure that the connection is closed properly
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Define your SQL query to select all data from the Orders table
                string query = "SELECT * FROM Orders";

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

        private void button9_Click(object sender, EventArgs e)
        {
            AdminManageCarsDashboard obj2 = new AdminManageCarsDashboard();
            obj2.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AdminManagePartsDashboard obj3 = new AdminManagePartsDashboard();
            obj3.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminManagePaymentDashboard obj4 = new AdminManagePaymentDashboard();
            obj4.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminManageReportGenaratingDashBoard obj5 = new AdminManageReportGenaratingDashBoard();
            obj5.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminManageHisProfileDetails obj6 = new AdminManageHisProfileDetails();
            obj6.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLoginPage frmLoginPage = new FrmLoginPage();
            frmLoginPage.Show();
            this.Close();
        }
    }
}
