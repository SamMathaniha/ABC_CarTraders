using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
    class PaymentController
    {
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        SqlConnection conn = null; // Declare the SqlConnection outside the try block

        public void InsertNewPaidPaymentDetails(Payments PaymentsObj)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                // SQL query with parameterized values to prevent SQL injection
                string sqlInsert = "INSERT INTO Payments(NIC, OrderID, RegID, Item, OrderDate, PaymentDate, Amount) VALUES (@NIC, @OrderID, @RegID, @Item, @OrderDate, @PaymentDate, @Amount)";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@NIC", PaymentsObj.NIC);
                    cmd.Parameters.AddWithValue("@OrderID", PaymentsObj.OrderID);
                    cmd.Parameters.AddWithValue("@RegID", PaymentsObj.RegID);
                    cmd.Parameters.AddWithValue("@Item", PaymentsObj.Item);
                    cmd.Parameters.AddWithValue("@OrderDate", PaymentsObj.OrderDate);
                    cmd.Parameters.AddWithValue("@Amount", PaymentsObj.Amount);

                    DateTime currentDate = DateTime.Now; // Assuming you want the current date
                                                         // Set PaymentDate to 'Current date' by default
                    cmd.Parameters.AddWithValue("@PaymentDate", currentDate);

                    // Execute the SQL command
                    cmd.ExecuteNonQuery();

                    // Update PaymentStatus in Orders table to 'Paid' for the corresponding OrderID
                    string updateSql = "UPDATE Orders SET PaymentStatus = 'Paid' WHERE ID = @OrderID";
                    using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@OrderID", PaymentsObj.OrderID);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show(" Task Done Successfully & Order status updated  ");
                    }
                }
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

        //Update

        public void UpdateDeleiveyStatus(Payments PaymentsObj)
        {
            try
            {


                // Assuming you have a valid connection string defined somewhere accessible
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                // Update DeliveryStatus in Orders table to 'Delivered' for the corresponding OrderID
                string updateSql = "UPDATE Orders SET DeliveryStatus = 'Delivered' WHERE ID = @OrderID";
                using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
                {
                    updateCmd.Parameters.AddWithValue("@OrderID", PaymentsObj.OrderID);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Status updated successfully.");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
                MessageBox.Show("Failed to update status: " + ex.Message);
            }
            finally
            {
                // Ensure that the connection is closed properly
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //Delete

       
    }
}
