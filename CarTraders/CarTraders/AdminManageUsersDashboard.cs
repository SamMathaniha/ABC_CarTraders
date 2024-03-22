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


    public partial class AdminManageUsersDashboard : Form
    {
        // Connection string
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;
        public AdminManageUsersDashboard()
        {
            InitializeComponent();

            conn = new SqlConnection(connectionString); // Initialize the SqlConnection object
            LoadData(); // Load data when the form is initialized used for datagrid view

            // Wire up the CellDoubleClick event handler
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
        }

        private void LoadData()
        {
            try
            {

                conn.Open();

                // Define your SQL query
                string query = "SELECT * FROM Users";

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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard obj1 = new AdminDashboard();
            obj1.Show();
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(txtbxNIC.Text) ||
                string.IsNullOrWhiteSpace(txtbxName.Text) ||
                string.IsNullOrWhiteSpace(txtbxAddress.Text) ||
                string.IsNullOrWhiteSpace(txtbxPhoneNo.Text) ||
                string.IsNullOrWhiteSpace(txtbxPassword.Text) ||
                string.IsNullOrWhiteSpace(CbbxUserType.Text))
            {
                MessageBox.Show("Please fill in all the fields ");
                return;  // exit the method if fields are not filled
            }
            RegisterController Users = new RegisterController();
            Users use = new Users(txtbxNIC.Text, txtbxName.Text, int.Parse(txtbxPhoneNo.Text), txtbxAddress.Text, txtbxPassword.Text, CbbxUserType.Text);
            Users.RegisterNewUsersByAdmin(use);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RegisterController UserUpdateCtl = new RegisterController();
            Users T1 = new Users(txtbxNIC.Text, txtbxName.Text, int.Parse(txtbxPhoneNo.Text), txtbxAddress.Text, txtbxPassword.Text, CbbxUserType.Text);
            UserUpdateCtl.UpdateSystemUser(T1);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Define your SQL query to select all data from the CarParts table
                string query = "SELECT * FROM Users";

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

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string NIC = txtbxSearchUserByNIC.Text;


                // Use parameterized query to prevent SQL injection
                string query = "SELECT * FROM Users WHERE NIC = @NIC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NIC", NIC);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RegisterController UserCntl = new RegisterController();
            string regIdToDelete = txtbxNIC.Text;
            UserCntl.DeleteSystemUser(regIdToDelete);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the double-clicked cell is within the row bounds
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Populate the text boxes with values from the selected row
                txtbxNIC.Text = selectedRow.Cells["NIC"].Value.ToString();
                txtbxName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtbxPhoneNo.Text = selectedRow.Cells["PhoneNo"].Value.ToString();
                txtbxAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtbxPassword.Text = selectedRow.Cells["Password"].Value.ToString();
                CbbxUserType.Text = selectedRow.Cells["UserType"].Value.ToString();

            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtbxNIC.Clear();
            txtbxName.Clear();
            txtbxPhoneNo.Clear();
            txtbxAddress.Clear();
            txtbxPassword.Clear();
            CbbxUserType.SelectedIndex = -1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminManageCarsDashboard obj1 = new AdminManageCarsDashboard();
            obj1.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AdminManagePartsDashboard obj2 = new AdminManagePartsDashboard();
            obj2.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AdminManageOrderDetailsDashboard obj3 = new AdminManageOrderDetailsDashboard();
            obj3.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminManagePaymentDashboard obj4 = new AdminManagePaymentDashboard();
            obj4.Show();
            this.Close();
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
