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
    public partial class AdminManageCarsDashboard : Form
    {
        // Connection string
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;
        SqlCommand cmd;
        SqlDataReader dr;

        public AdminManageCarsDashboard()
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
                string query = "SELECT * FROM Cars";

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
            AdminDashboard adminDashbd = new AdminDashboard();
            adminDashbd.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminManageCarAddNewCar addNewCar = new AdminManageCarAddNewCar();
            addNewCar.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string Reg_ID = txtbxSearchCarByID.Text;


                // Use parameterized query to prevent SQL injection
                string query = "SELECT * FROM Cars WHERE Reg_ID = @Reg_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Reg_ID", Reg_ID);

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
                string query = "SELECT * FROM Cars WHERE Brand = @Brand";
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Define your SQL query to select all data from the Cars table
                string query = "SELECT * FROM Cars";

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
                string RegID = selectedRow.Cells["Reg_ID"].Value.ToString();
                string brand = selectedRow.Cells["Brand"].Value.ToString();
                string model = selectedRow.Cells["Model"].Value.ToString();
                int year = Convert.ToInt32(selectedRow.Cells["Year"].Value);
                string colour = selectedRow.Cells["Colour"].Value.ToString();
                string codition = selectedRow.Cells["Codition"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                string transmission = selectedRow.Cells["Transmission"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();
                int stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);
                string imageName = selectedRow.Cells["ImageName"].Value.ToString(); // Assuming "ImageName" is the column name for the image name

                // Construct the full path to the image
                string imagePath = Path.Combine(@"F:\A\Car Traders\Images\CarImages", imageName);

                // Create a new instance of AdminManageCarViewDeleteUpdate form
                AdminManageCarViewDeleteUpdate addNewCarForm = new AdminManageCarViewDeleteUpdate();

                // Populate the fields in the form with the data from the selected row             
                addNewCarForm.PopulateFields(RegID, brand, model, year, colour, codition, price, transmission, description, stock, imageName, imagePath);


                // Load and display the image in the form
                addNewCarForm.LoadImage(imagePath);

                // Show the AdminManageCarViewDeleteUpdate form
                addNewCarForm.Show();
                this.Close();

            }

        }

        private void AdminManageCarsDashboard_Load(object sender, EventArgs e)
        {

        }

        private void CbbxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AdminManagePartsDashboard obj3 = new AdminManagePartsDashboard();
            obj3.Show();
            this.Close();
            ;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AdminManageUsersDashboard obj4 = new AdminManageUsersDashboard();
            obj4.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AdminManageOrderDetailsDashboard obj5 = new AdminManageOrderDetailsDashboard();
            obj5.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminManagePaymentDashboard obj6 = new AdminManagePaymentDashboard();
            obj6.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminManageReportGenaratingDashBoard obj7 = new AdminManageReportGenaratingDashBoard();
            obj7.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminManageHisProfileDetails obj8 = new AdminManageHisProfileDetails();
            obj8.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLoginPage obj9 = new FrmLoginPage();
            obj9.Show();
            this.Close();
        }
    }


}
