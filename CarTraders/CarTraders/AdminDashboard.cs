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
    public partial class AdminDashboard : Form
    {
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        SqlConnection conn = null; // Declare the SqlConnection outside the try block

        private int totalSystemUsersCount = 0; // Total count of Users from the database
        private int totalOrdersCount = 0; // Total count of Order from the database
        private int totalCarsCount = 0; // Total count of Cars from the database
        private int totalPartsCount = 0; // Total count of PArts from the database
        public AdminDashboard()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString); // Initialize the SqlConnection object

            label5.Text = "Welcome ADMIN, " + UserSession.Name; // Display the user's name from UserSession
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Attach the Load event handler to ReportsForm_Load
            this.Load += new EventHandler(ReportsForm_Load);
        }

        private void ReportsForm_Load(object sender, EventArgs e)  // Get Count of following Data
        {
            try
            {
                conn.Open();

                // Retrieve the total count of SystemUsers
                string SystemUsersQuery = "SELECT COUNT(*) FROM Users";
                SqlCommand SystemUsersCommand = new SqlCommand(SystemUsersQuery, conn);
                totalSystemUsersCount = Convert.ToInt32(SystemUsersCommand.ExecuteScalar());

                // Retrieve the total count of Orders
                string OrdersQuery = "SELECT COUNT(*) FROM Orders";
                SqlCommand OrdersCommand = new SqlCommand(OrdersQuery, conn);
                totalOrdersCount = Convert.ToInt32(OrdersCommand.ExecuteScalar());

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
                labelOrderCount.Text = totalOrdersCount.ToString();
                labelOrderCount.TextAlign = ContentAlignment.MiddleCenter; // Center horizontally and vertically
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

        private void button10_Click(object sender, EventArgs e)
        {
            AdminManagePartsDashboard obj3 = new AdminManagePartsDashboard();
            obj3.Show();
            this.Close();
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
            FrmLoginPage logout = new FrmLoginPage();
            logout.Show();
            this.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelUserCount_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
