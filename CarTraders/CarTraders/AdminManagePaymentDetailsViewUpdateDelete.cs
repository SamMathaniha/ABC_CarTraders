using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class AdminManagePaymentDetailsViewUpdateDelete : Form
    {
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        SqlConnection conn = null; // Declare the SqlConnection outside the try block
        public AdminManagePaymentDetailsViewUpdateDelete()
        {
            InitializeComponent();
        }
        // retrive data
        public void PopulateFields(string PayID, string NIC, string OrderID, string RegID, string Item, DateTime OrderDate, DateTime PaymentDate, Decimal Amount)
        {
            // Populate the fields in the form with the provided data
            txtbxPayID.Text = PayID;
            txtbxNIC.Text = NIC;
            txtbxOrderID.Text = OrderID;
            txtbxRegID.Text = RegID;
            txtbxItem.Text = Item;
            txtbxOrderDate.Text = OrderDate.ToString();
            txtbxPayDate.Text = PaymentDate.ToString();
            txtbxAmount.Text = Amount.ToString();
        }


        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Display confirmation dialog
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    string payID = txtbxPayID.Text;

                    // Check if payID is not empty
                    if (string.IsNullOrEmpty(payID))
                    {
                        MessageBox.Show("Please provide a PayID to delete the order.");
                        return;
                    }

                    // Check user's choice
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();

                        string sqlDelete = @"DELETE FROM Payments WHERE PayID = @ID";

                        using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", payID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Order deleted successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete Order");
                            }
                        }
                    }
                    else
                    {
                        // User canceled the operation
                        MessageBox.Show("Deletion canceled by user");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

        private void AdminManagePaymentDetailsViewUpdateDelete_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManagePaymentDashboard obj1 = new AdminManagePaymentDashboard();
            obj1.Show();
            this.Close();
        }
    }
}
