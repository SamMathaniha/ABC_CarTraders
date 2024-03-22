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
    public partial class AdminManageHisProfileDetails : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn;
        public AdminManageHisProfileDetails()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);

            LabelName.Text = UserSession.Name; // Display the user's name from UserSession
            LabelNameNIC.Text = UserSession.NIC; // Display the user's name from UserSession

            try
            {
                conn.Open();
                string query = "SELECT Name, PhoneNo, Address FROM Users WHERE NIC = @NIC";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NIC", UserSession.NIC);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtbxUserName.Text = reader["Name"].ToString();
                    txtbcUserPhoneNo.Text = reader["PhoneNo"].ToString();
                    txtbxUserAddress.Text = reader["Address"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminDashboard back = new AdminDashboard();
            back.Show();
            this.Close();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            // Ensure all fields are filled before updating
            if (string.IsNullOrWhiteSpace(txtbxUserName.Text) || string.IsNullOrWhiteSpace(txtbcUserPhoneNo.Text) || string.IsNullOrWhiteSpace(txtbxUserAddress.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Confirm with the user before updating
            DialogResult result = MessageBox.Show("Are you sure you want to update your information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    // Update query to update user's information
                    string updateQuery = "UPDATE Users SET Name = @Name, PhoneNo = @PhoneNo, Address = @Address WHERE NIC = @NIC";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                    updateCommand.Parameters.AddWithValue("@Name", txtbxUserName.Text);
                    updateCommand.Parameters.AddWithValue("@PhoneNo", txtbcUserPhoneNo.Text);
                    updateCommand.Parameters.AddWithValue("@Address", txtbxUserAddress.Text);
                    updateCommand.Parameters.AddWithValue("@NIC", UserSession.NIC);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully.");

                        // Update the label after successful update
                        LabelName.Text = txtbxUserName.Text;
                    }
                    else
                    {
                        MessageBox.Show("No user found with the provided NIC.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Update operation canceled.");
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string nic = UserSession.NIC; // Retrieve NIC from UserSession

            // Retrieve old, new, and confirm passwords from textboxes
            string oldPassword = txtbxUserOldPwd.Text;
            string newPassword = txtbxUserNewPwd.Text;
            string confirmPassword = txtbxUserConfirmPwd.Text;

            // Decrypt the stored password for comparison
            string storedEncryptedPassword = RetrievePasswordFromDatabase(nic);
            string storedPassword = DecryptPassword(storedEncryptedPassword);

            if (storedPassword != oldPassword)
            {
                MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the new password and confirm password match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Encrypt the new password before updating in the database
            string newEncryptedPassword = EncryptPassword(newPassword);

            // Update the password in the database
            if (UpdatePasswordInDatabase(nic, newEncryptedPassword))
            {
                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear the textboxes
                txtbxUserOldPwd.Clear();
                txtbxUserNewPwd.Clear();
                txtbxUserConfirmPwd.Clear();
            }
            else
            {
                MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to retrieve the password associated with the NIC from the database
        private string RetrievePasswordFromDatabase(string nic)
        {
            string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Password FROM Users WHERE NIC = @nic";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nic", nic);

                string storedEncryptedPassword = (string)cmd.ExecuteScalar();

                return storedEncryptedPassword;
            }
        }

        // Method to update the password associated with the NIC in the database
        private bool UpdatePasswordInDatabase(string nic, string newPassword)
        {
            string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Users SET Password = @newPassword WHERE NIC = @nic";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@nic", nic);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        // Method to decrypt the password
        private string DecryptPassword(string encryptedPassword)
        {
            byte[] data = Convert.FromBase64String(encryptedPassword);
            string decryptedPassword = Encoding.UTF8.GetString(data);
            return decryptedPassword;
        }

        // Method to encrypt the password
        private string EncryptPassword(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            string encryptedPassword = Convert.ToBase64String(data);
            return encryptedPassword;
        }

        private void AdminManageHisProfileDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
