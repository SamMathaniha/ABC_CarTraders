using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarTraders
{
    public partial class RegisterPage : Form
    {
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLoginPage obj1 = new FrmLoginPage();
            obj1.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            // Ensure connection is initialized
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Open the connection

                    string Name = txtbxName.Text.Trim();
                    if (!int.TryParse(txtbxPhnNo.Text, out int PhoneNo))
                    {
                        MessageBox.Show("Invalid phone number input. Please enter a valid integer.");
                        return;
                    }

                    string NIC = txtbxNIC.Text;
                    string Address = txtbxAddress.Text;
                    string Password = txtbxPassword.Text;
                    string UserType = "Customer"; // You need to assign a value to UserType

                    if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Password))
                    {
                        MessageBox.Show("Please Fill All the Fields ");
                        return;
                    }

                    // Create an instance of Users and register the user
                    Users RegConrl = new Users(NIC, Name, PhoneNo, Address, Password, UserType);
                    RegConrl.RegisterNewUsers(conn);


                    // Show login form
                    FrmLoginPage Login = new FrmLoginPage();
                    Login.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Handle the exception here, e.g., log it or display an error message
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally { conn.Close(); }
            }
        }


        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
