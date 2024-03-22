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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";

      
        private void button1_Click(object sender, EventArgs e)
        {
            FrmLoginPage obj1 = new FrmLoginPage();
            obj1.Show();
            this.Close();
        }

        private void btnSubmitForPw_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from textboxes
                string nic = txtbxNICForPw.Text;
                string phoneNo = txtbxPhoneNoForPw.Text;

                // Create SqlConnection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to check if NIC and PhoneNo match
                    string sqlSelect = "SELECT COUNT(*) FROM Users WHERE NIC = @NIC AND PhoneNo = @PhoneNo";

                    using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // NIC and PhoneNo match, open ForgotPasswordUpdatePw form
                            this.Hide(); // Hide the current form instead of closing it
                            ForgotPasswordUpdatePw form = new ForgotPasswordUpdatePw(nic);
                            form.ShowDialog();
                            this.Close(); // Close the current form when the ForgotPasswordUpdatePw form is closed
                        }
                        else
                        {
                            // NIC and PhoneNo do not match, show messagebox
                            MessageBox.Show("NIC and Phone number not matched. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
