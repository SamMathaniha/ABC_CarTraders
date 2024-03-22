using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
     class Users
    {
        //Properties
        public string NIC { get; set; }
        public string Name { get; set; }
        public int PhoneNo { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }


        // Creating Constructor
        public Users(string nic, string name, int phnNo, string ads, string pwd,string userType)
        {
            this.NIC = nic;
            this.Name = name;
            this.PhoneNo = phnNo;
            this.Address = ads;
            this.Password = EncryptPassword(pwd);
            this.UserType = userType;

        }
        private string EncryptPassword(string pwd)
        {
            byte[] encode = Encoding.UTF8.GetBytes(pwd);
            return Convert.ToBase64String(encode);
        }

        public void RegisterNewUsers(SqlConnection conn)
        {

                // SQL query with parameterized values to prevent SQL injection
                string sqlInsert = "INSERT INTO Users(NIC, Name, PhoneNo, Address, Password, UserType) VALUES (@NIC, @Name,  @PhoneNo, @Address, @Password, @UserType)";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@NIC", NIC);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    // Set UserType to 'Customer' by default
                    cmd.Parameters.AddWithValue("@UserType", "Customer");



                    // Execute the SQL command
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You Have Successfully Registered, You can Login now ");


                }
           
        }
    }
}