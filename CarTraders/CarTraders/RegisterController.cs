using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarTraders
{
     class RegisterController
    {
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
       
        SqlConnection conn = null; // Declare the SqlConnection outside the try block

        //Register
        public void RegisterNewUsers(SystemUsers SystemUsersObj) 
        {
            try
            {

                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();

                // SQL query with parameterized values to prevent SQL injection
                string sqlInsert = "INSERT INTO Users(NIC, Name, PhoneNo, Address, Password, UserType) VALUES (@NIC, @Name,  @PhoneNo, @Address, @Password, @UserType)";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@NIC", SystemUsersObj.NIC);
                    cmd.Parameters.AddWithValue("@Name", SystemUsersObj.Name);
                    cmd.Parameters.AddWithValue("@PhoneNo", SystemUsersObj.PhoneNo);
                    cmd.Parameters.AddWithValue("@Address", SystemUsersObj.Address);
                    cmd.Parameters.AddWithValue("@Password", SystemUsersObj.Password);
                    // Set UserType to 'Customer' by default
                    cmd.Parameters.AddWithValue("@UserType", "Customer");
       


                    // Execute the SQL command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully ");


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

        private string EncryptPassword(string pwd)
        {
            byte[] encode = Encoding.UTF8.GetBytes(pwd);
            return Convert.ToBase64String(encode);
        }

        public void RegisterNewUsersByAdmin(Users SystemUsersObj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query with parameterized values to prevent SQL injection
                    string sqlInsert = "INSERT INTO Users(NIC, Name, PhoneNo, Address, Password, UserType) VALUES (@NIC, @Name,  @PhoneNo, @Address, @Password, @UserType)";

                    using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIC", SystemUsersObj.NIC);
                        cmd.Parameters.AddWithValue("@Name", SystemUsersObj.Name);
                        cmd.Parameters.AddWithValue("@PhoneNo", SystemUsersObj.PhoneNo);
                        cmd.Parameters.AddWithValue("@Address", SystemUsersObj.Address);

                        // Encrypt the password before storing it in the database
                        string encryptedPassword = EncryptPassword(SystemUsersObj.Password);
                        cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                        cmd.Parameters.AddWithValue("@UserType", SystemUsersObj.UserType);

                        // Execute the SQL command
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registered Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }



        //update user
        public void UpdateSystemUser(Users SystemUsersObjs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlUpdate = @"UPDATE Users 
                             SET 
                                 Name = @Name,
                                 PhoneNo = @PhoneNo, 
                                 Address = @Address, 
                                 Password = @Password, 
                                 UserType = @UserType
                             WHERE NIC = @NIC";

                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIC", SystemUsersObjs.NIC);
                        cmd.Parameters.AddWithValue("@Name", SystemUsersObjs.Name);
                        cmd.Parameters.AddWithValue("@PhoneNo", SystemUsersObjs.PhoneNo);
                        cmd.Parameters.AddWithValue("@Address", SystemUsersObjs.Address);

                        // Encrypt the password before updating it in the database
                        string encryptedPassword = EncryptPassword(SystemUsersObjs.Password);
                        cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                        cmd.Parameters.AddWithValue("@UserType", SystemUsersObjs.UserType);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update User");
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





        //Delete  user


        public void DeleteSystemUser(string NIC)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlDelete = @"DELETE FROM Users WHERE NIC = @NIC";

                    using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIC", NIC);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete User");
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
