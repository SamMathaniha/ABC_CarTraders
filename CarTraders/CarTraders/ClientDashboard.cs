using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class ClientDashboard : Form
    {
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";

        SqlConnection conn = null; // Declare the SqlConnection outside the try block

        private int totalSystemUsersCount = 0; // Total count of Users from the database
        private int totalCarsCount = 0; // Total count of Cars from the database
        private int totalPartsCount = 0; // Total count of PArts from the database
        public ClientDashboard()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString); // Initialize the SqlConnection object

            label2.Text = "Welcome, " + UserSession.Name; // Display the user's name from UserSession
                                                          // Set the label's horizontal position to the center of the form
            label2.Location = new Point((ClientSize.Width - label2.Width) / 2, label2.Location.Y);

            // Attach the Load event handler to ReportsForm_Load
            this.Load += new EventHandler(COuntForm_Load);
        }

        private void COuntForm_Load(object sender, EventArgs e)  // Get Count of following Data
        {
            try
            {
                conn.Open();

                // Retrieve the total count of SystemUsers
                string SystemUsersQuery = "SELECT COUNT(*) FROM Users";
                SqlCommand SystemUsersCommand = new SqlCommand(SystemUsersQuery, conn);
                totalSystemUsersCount = Convert.ToInt32(SystemUsersCommand.ExecuteScalar());          

                // Retrieve the total count of Cars
                string CarsQuery = "SELECT COUNT(*) FROM Cars";
                SqlCommand CarsCommand = new SqlCommand(CarsQuery, conn);
                totalCarsCount = Convert.ToInt32(CarsCommand.ExecuteScalar());

                // Retrieve the total count of Parts
                string PartsQuery = "SELECT COUNT(*) FROM CarParts";
                SqlCommand PartsCommand = new SqlCommand(PartsQuery, conn);
                totalPartsCount = Convert.ToInt32(PartsCommand.ExecuteScalar());

                // Display the counts in labels or any other appropriate controls
                labelUserCount.Text = totalSystemUsersCount.ToString();
                labelUserCount.TextAlign = ContentAlignment.MiddleCenter; // Center horizontally and vertically
                labelCarCount.Text = totalCarsCount.ToString();
                labelCarCount.TextAlign = ContentAlignment.MiddleCenter; // Center horizontally and vertically
                labelPartsCount.Text = totalPartsCount.ToString();
                labelPartsCount.TextAlign = ContentAlignment.MiddleCenter; // Center horizontally and vertically
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the database operation
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection if it's open
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmLoginPage closebtn = new FrmLoginPage();
            closebtn.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientViewCarDetails carsView = new ClientViewCarDetails();
            carsView.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientViewPartsDetails PartsView = new ClientViewPartsDetails();
            PartsView.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientOrderDetails ordersView = new ClientOrderDetails();
            ordersView.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {
            CarController carController = new CarController();
            int carCount = carController.GetCarsCount();
            MessageBox.Show($"Total number of cars: {carCount}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientMyProfile profile = new ClientMyProfile();
            profile.Show();
            this.Close( );
        }
    }
}
