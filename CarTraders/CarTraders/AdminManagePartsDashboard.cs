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
    public partial class AdminManagePartsDashboard : Form
    {
        // Connection string
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;
        SqlCommand cmd;
        SqlDataReader dr;

        public AdminManagePartsDashboard()
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
                string query = "SELECT * FROM CarParts";

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
            {
                try
                {
                    conn.Open();

                    // Define your SQL query
                    string query = "SELECT DISTINCT Category, Product, Brand FROM CarParts";

                    // Create a command object
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        // Execute the command and read the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create HashSet to store unique values
                            HashSet<string> categorySet = new HashSet<string>();
                            Dictionary<string, HashSet<string>> categoryProductMap = new Dictionary<string, HashSet<string>>();
                            Dictionary<string, HashSet<string>> productBrandMap = new Dictionary<string, HashSet<string>>();

                            // Loop through the results and add them to the corresponding HashSet and Dictionary
                            while (reader.Read())
                            {
                                string category = reader["Category"].ToString();
                                string product = reader["Product"].ToString();
                                string brand = reader["Brand"].ToString();

                                categorySet.Add(category);

                                if (!categoryProductMap.ContainsKey(category))
                                    categoryProductMap[category] = new HashSet<string>();

                                categoryProductMap[category].Add(product);

                                string categoryProduct = category + "|" + product;

                                if (!productBrandMap.ContainsKey(categoryProduct))
                                    productBrandMap[categoryProduct] = new HashSet<string>();

                                productBrandMap[categoryProduct].Add(brand);
                            }

                            // Clear existing items in the ComboBoxes
                            CbbxCategory.Items.Clear();
                            CbbxProduct.Items.Clear();
                            CbbxBrand.Items.Clear();

                            // Add unique values from HashSet to ComboBoxes
                            foreach (string category in categorySet)
                            {
                                CbbxCategory.Items.Add(category);
                            }

                            // Handle ComboBox selected index changed event for CbbxCategory
                            CbbxCategory.SelectedIndexChanged += (sender, e) =>
                            {
                                string selectedCategory = CbbxCategory.SelectedItem.ToString();
                                UpdateDataGridView(selectedCategory, null, null);
                                CbbxProduct.Items.Clear();
                                CbbxBrand.Items.Clear();

                                if (categoryProductMap.ContainsKey(selectedCategory))
                                {
                                    foreach (string product in categoryProductMap[selectedCategory])
                                    {
                                        CbbxProduct.Items.Add(product);
                                    }
                                }
                            };

                            // Handle ComboBox selected index changed event for CbbxProduct
                            CbbxProduct.SelectedIndexChanged += (sender, e) =>
                            {
                                string selectedCategory = CbbxCategory.SelectedItem.ToString();
                                string selectedProduct = CbbxProduct.SelectedItem.ToString();
                                UpdateDataGridView(selectedCategory, selectedProduct, null);
                                CbbxBrand.Items.Clear();

                                string selectedCategoryProduct = selectedCategory + "|" + selectedProduct;
                                if (productBrandMap.ContainsKey(selectedCategoryProduct))
                                {
                                    foreach (string brand in productBrandMap[selectedCategoryProduct])
                                    {
                                        CbbxBrand.Items.Add(brand);
                                    }
                                }
                            };

                            // Handle ComboBox selected index changed event for CbbxBrand
                            CbbxBrand.SelectedIndexChanged += (sender, e) =>
                            {
                                string selectedCategory = CbbxCategory.SelectedItem.ToString();
                                string selectedProduct = CbbxProduct.SelectedItem.ToString();
                                string selectedBrand = CbbxBrand.SelectedItem.ToString();
                                UpdateDataGridView(selectedCategory, selectedProduct, selectedBrand);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard obj1 = new AdminDashboard();
            obj1.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminManageCarsDashboard obj2 = new AdminManageCarsDashboard();
            obj2.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminManagePartsAddNewProduct obj3 = new AdminManagePartsAddNewProduct();
            obj3.Show();
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Retrieve data from the selected row
                string Reg_ID = selectedRow.Cells["Reg_ID"].Value.ToString();
                string Product = selectedRow.Cells["Product"].Value.ToString();
                string Category = selectedRow.Cells["Category"].Value.ToString();
                string Brand = selectedRow.Cells["Brand"].Value.ToString();
                decimal Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                string Compatibility = selectedRow.Cells["Compatibility"].Value.ToString();
                string Condition = selectedRow.Cells["Condition"].Value.ToString();
                int Stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);
                string imageName = selectedRow.Cells["ImageName"].Value.ToString(); // Assuming "ImageName" is the column name for the image name

                // Construct the full path to the image
                string imagePath = Path.Combine(@"F:\A\Car Traders\Images\CarPartsImages", imageName);

                // Create a new instance of AdminManageCarViewDeleteUpdate form
                AdminManagePartsViewDeleteProduct addNewCarpartsForm = new AdminManagePartsViewDeleteProduct();

                // Populate the fields in the form with the data from the selected row             
                addNewCarpartsForm.PopulateFields(Reg_ID, Product, Category, Brand, Price, Compatibility, Condition, Stock, imageName, imagePath);


                // Load and display the image in the form
                addNewCarpartsForm.LoadImage(imagePath);

                // Show the AdminManageCarViewDeleteUpdate form
                addNewCarpartsForm.Show();
                this.Close();

            }
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string Reg_ID = txtbxSearchCarByID.Text;


                // Use parameterized query to prevent SQL injection
                string query = "SELECT * FROM CarParts WHERE Reg_ID = @Reg_ID";
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


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Define your SQL query to select all data from the CarParts table
                string query = "SELECT * FROM CarParts";

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

        // Method to update DataGridView based on selected values
        public void UpdateDataGridView(string Category, string Product, string Brand = null)
        {
            try
            {
                conn.Open();

                // Define your SQL query
                string query = "SELECT * FROM CarParts WHERE Category = @Category";
                if (!string.IsNullOrEmpty(Product))
                    query += " AND Product = @Product";
                if (!string.IsNullOrEmpty(Brand))
                    query += " AND Brand = @Brand";

                // Create a command object
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Category", Category);
                    if (!string.IsNullOrEmpty(Product))
                        command.Parameters.AddWithValue("@Product", Product);
                    if (!string.IsNullOrEmpty(Brand))
                        command.Parameters.AddWithValue("@Brand", Brand);

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

        private void AdminManagePartsDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            AdminManageUsersDashboard Obj3 = new AdminManageUsersDashboard();
            Obj3.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AdminManageOrderDetailsDashboard Obj4 = new AdminManageOrderDetailsDashboard();
            Obj4.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminManagePaymentDashboard Obj5 = new AdminManagePaymentDashboard();
            Obj5.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminManageReportGenaratingDashBoard Obj6 = new AdminManageReportGenaratingDashBoard();
            Obj6.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminManageHisProfileDetails obj7 = new AdminManageHisProfileDetails();
            obj7.Show();
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
