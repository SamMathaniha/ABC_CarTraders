using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class FrmLoginPage : Form
    {
        private string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";
        private SqlConnection conn = null;

        public FrmLoginPage()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString); // Initialize the SqlConnection object
        }

        private string DecryptPassword(string encryptedPassword)
        {
            byte[] data = Convert.FromBase64String(encryptedPassword);
            string decryptedPassword = Encoding.UTF8.GetString(data);
            return decryptedPassword;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtbxNIC.Text.Trim();
            string userPassword = txtbxPwd.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Please provide both username and password");
                return;
            }

            try
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE NIC = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    string storedPassword = dataTable.Rows[0]["password"].ToString();
                    string decryptedPassword = DecryptPassword(storedPassword);

                    // For debugging purposes, you can display the decrypted password
                    // MessageBox.Show("Decrypted Password: " + decryptedPassword);

                    if (userPassword == decryptedPassword)
                    {
                        string userType = dataTable.Rows[0]["UserType"].ToString();

                        // Set UserSession properties
                        UserSession.NIC = dataTable.Rows[0]["NIC"].ToString();
                        UserSession.Name = dataTable.Rows[0]["Name"].ToString();

                        if (userType == "Admin")
                        {
                            MessageBox.Show("Admin login successful....");
                            AdminDashboard adminDash = new AdminDashboard();
                            adminDash.Show();
                        }
                        else if (userType == "Customer")
                        {
                            MessageBox.Show("Customer login successful....");
                            ClientDashboard CustomerDash = new ClientDashboard();
                            CustomerDash.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbxNIC.Clear();
                        txtbxPwd.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbxNIC.Clear();
                    txtbxPwd.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            RegisterPage obj2 = new RegisterPage();
            obj2.Show();
            this.Hide();
        }

        private void ChbxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            txtbxPwd.PasswordChar = ChbxShowPwd.Checked ? '\0' : '*';
        }

        private void LbForgotPwd_Click(object sender, EventArgs e)
        {
            ForgotPassword obj2 = new ForgotPassword();
            obj2.Show();
            this.Hide();
        }

        private void label4_Click(object sender, MouseEventArgs e)
        {

        }

        private void RegisterPage_Click(object sender, EventArgs e)
        {
            RegisterPage obj9 = new RegisterPage();
            obj9.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
