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
    public partial class ClientViewCarDetails : Form
    {

        // Connection string
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;

        public ClientViewCarDetails(string userNIC = "")
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
                string query = "SELECT *FROM Cars WHERE Brand = @Brand";
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




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientViewCarDetails_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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
                ClientViewCarOrder CarOrder = new ClientViewCarOrder();

                // Populate the fields in the form with the data from the selected row             
                CarOrder.PopulateFields(RegID, brand, model, year, colour, codition, price, transmission, description, stock, imageName, imagePath);


                // Load and display the image in the form
                CarOrder.LoadImage(imagePath);

                // Show the AdminManageCarViewDeleteUpdate form
                CarOrder.Show();


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClientDashboard backbutton = new ClientDashboard();
            backbutton.Show();
            this.Close();
        }


        private void labelUserNIC_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientViewPartsDetails partsView = new ClientViewPartsDetails();
            partsView.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientOrderDetails ordersView = new ClientOrderDetails();
            ordersView.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
