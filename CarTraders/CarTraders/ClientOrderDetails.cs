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
    public partial class ClientOrderDetails : Form
    {
        // Connection string
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;

        public ClientOrderDetails()
        {
            InitializeComponent();
            LoadData(); // Load data when the form is initialized used for datagrid view
        }

        private void LoadData()
        {
            try
            {
                conn = new SqlConnection(connectionString); // Initialize the SqlConnection object
                conn.Open();

                // Define your SQL query with a parameterized query to prevent SQL injection
                string query = "SELECT * FROM Orders WHERE NIC = @NIC ORDER BY OrderDate DESC";


                // Create a command object
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@NIC", UserSession.NIC);

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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClientDashboard backbtn = new ClientDashboard();
            backbtn.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientViewCarDetails carview = new ClientViewCarDetails();
            carview.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientViewPartsDetails partsview = new ClientViewPartsDetails();
            partsview.Show();
            this.Close();
        }
    }
}
