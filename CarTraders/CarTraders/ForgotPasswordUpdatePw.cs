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
    public partial class ForgotPasswordUpdatePw : Form
    {
        // Add a constructor that takes a parameter
        public ForgotPasswordUpdatePw(string nic)
        {
            InitializeComponent();
            txtbxNIC.Text = nic;  //taken from forgotpassword form
        }
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmLoginPage obj1 = new FrmLoginPage();
            obj1.Show();
            this.Close();
        }

        private void btnUpdateConfirmPw_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = txtbxUpdateNewPw.Text;
                string confirmNewPassword = txtbxUpdateConfirmPw.Text;

                if (newPassword.Equals(confirmNewPassword))
                {
                    // Encrypt the new password
                    string encryptedPassword = EncryptPassword(newPassword);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Use your logic to update the password in the database
                        string sqlUpdate = "UPDATE Users SET Password = @Password WHERE NIC = @NIC";

                        using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("@Password", encryptedPassword);
                            cmd.Parameters.AddWithValue("@NIC", txtbxNIC.Text); // Assuming txtbxNIC contains the NIC value

                            cmd.ExecuteNonQuery();
                        }

                        // Show messagebox with options
                        DialogResult result = MessageBox.Show("Password updated successfully. Do you want to login now?", "Password Updated", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            // Close this form and open FrmLoginPage
                            FrmLoginPage loginForm = new FrmLoginPage();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            // Clear the fields and stay in the current form
                            txtbxUpdateNewPw.Text = string.Empty;
                            txtbxUpdateConfirmPw.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    // Passwords do not match, show messagebox
                    MessageBox.Show("New password and confirm password do not match. Please try again.");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private string EncryptPassword(string pwd)
        {
            byte[] encode = Encoding.UTF8.GetBytes(pwd);
            return Convert.ToBase64String(encode);
        }

        private void ForgotPasswordUpdatePw_Load(object sender, EventArgs e)
        {

        }
    }
}
