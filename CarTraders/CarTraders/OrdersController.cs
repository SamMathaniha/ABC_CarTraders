using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
     class OrdersController
    {
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        public void DeleteOrder(string ID)
        {
            try
            {
                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check user's choice
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string sqlDelete = @"DELETE FROM Orders WHERE ID = @ID";

                        using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", ID);

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
                }
                else
                {
                    // User canceled the operation
                    MessageBox.Show("Deletion canceled by user");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public void SearchbyID()
        {

        }
    }
}
