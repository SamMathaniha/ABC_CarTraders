using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class ClientViewPartsOrder : Form
    {
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";



        public ClientViewPartsOrder()
        {
            InitializeComponent();
        }

        public void PopulateFields(string Reg_ID, string Product, string Category, string Brand, decimal Price, string Compatibility, string Condition, int Stock, string imageName, string imagePath)
        {
            // Populate the fields in the form with the provided data
            txtbxPartsRegID.Text = Reg_ID;
            txtbxPartsProduct.Text = Product;
            txtbxPartsCategory.Text = Category;
            txtbxPartsBrand.Text = Brand;
            txtbxPartsPrice.Text = Price.ToString();
            txtbxPartsCompatibility.Text = Compatibility;
            txtbxPartsCondition.Text = Condition;
            txtbxPartsStock.Text = Stock.ToString();

            // Load and display the image in the PictureBox
            pictureBoxParts.SizeMode = PictureBoxSizeMode.Zoom; // Set PictureBox size mode to Zoom
            pictureBoxParts.Image = Image.FromFile(imagePath);
        }

        //this to check whether image works correctly
        public void LoadImage(string imagePath)
        {
            // Check if the file exists
            if (File.Exists(imagePath))
            {
                // Load the image into the PictureBox
                pictureBoxParts.SizeMode = PictureBoxSizeMode.Zoom; // Set PictureBox size mode to Zoom
                pictureBoxParts.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Display a message if the image file does not exist
                MessageBox.Show("Image file not found: " + imagePath);
            }
        }

        private void pictureBoxParts_Click(object sender, EventArgs e)
        {
            // Open a new form to display the image in a larger size
            Form imageForm = new Form();
            imageForm.StartPosition = FormStartPosition.CenterScreen;
            imageForm.Size = new Size(800, 600); // Set the size of the form as per your requirement

            PictureBox enlargedPictureBox = new PictureBox();
            enlargedPictureBox.Dock = DockStyle.Fill;
            enlargedPictureBox.Image = pictureBoxParts.Image;
            enlargedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            imageForm.Controls.Add(enlargedPictureBox);

            imageForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int InsertOrderAndGetID(string regId, string model, string brand, decimal price, string paymentStatus, string deliveryStatus, string userNIC)
        {
            int insertedID = -1; // Default value if insertion fails
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Orders (OrderDate, RegID, Item, Type, Price, PaymentStatus, DeliveryStatus, NIC) " +
                               "VALUES (@OrderDate, @RegID, @Item, @Type, @Price, @PaymentStatus, @DeliveryStatus, @NIC);" +
                               "SELECT SCOPE_IDENTITY();"; // Retrieve the newly inserted ID
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                command.Parameters.AddWithValue("@RegID", regId);
                command.Parameters.AddWithValue("@Item", model);
                command.Parameters.AddWithValue("@Type", brand);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                command.Parameters.AddWithValue("@DeliveryStatus", deliveryStatus);
                command.Parameters.AddWithValue("@NIC", userNIC);

                try
                {
                    connection.Open();
                    insertedID = Convert.ToInt32(command.ExecuteScalar()); // Get the inserted ID
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return insertedID;
        }

        private void PrintReceipt(int ID, DateTime orderDate, string regId, string model, string brand, decimal price, string paymentStatus, string deliveryStatus, string userNIC)
        {
            // Title
            string title = "ABC Car Traders";

            // Create receipt content
            StringBuilder receiptContent = new StringBuilder();
            receiptContent.AppendLine(title);
            receiptContent.AppendLine("Order Details");
            receiptContent.AppendLine($"Order ID: {ID}");
            receiptContent.AppendLine($"Order Date: {orderDate}");
            receiptContent.AppendLine($"Reg ID: {regId}");
            receiptContent.AppendLine($"Item: {model}");
            receiptContent.AppendLine($"Type: {brand}");
            receiptContent.AppendLine($"Payment Status: {paymentStatus}");
            receiptContent.AppendLine($"Delivery Status: {deliveryStatus}");
            receiptContent.AppendLine($"NIC: {userNIC}");
            receiptContent.AppendLine($"Price: Rs. {price}");
            receiptContent.AppendLine("Please Provide this recipt to administrator and do your Payments");

            // Calculate the width and height of the receipt
            int width = 300;
            int height = 200;

            // Print receipt
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += (s, ev) =>
            {
                // Set up formatting
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;

                // Draw receipt content
                ev.Graphics.DrawString(receiptContent.ToString(), new Font("Arial", 10), Brushes.Black, new RectangleF(0, 0, width, height), format);
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to place the order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string userNIC = UserSession.NIC; // getting the user's name from UserSession

                // Get data from the form fields
                string regId = txtbxPartsRegID.Text;
                string model = txtbxPartsCategory.Text;
                string brand = txtbxPartsBrand.Text;
                decimal price = Convert.ToDecimal(txtbxPartsPrice.Text);

                // Set default values
                string paymentStatus = "Pending";
                string deliveryStatus = "Pending";

                // Insert data into the database and get the inserted ID
                int insertedID = InsertOrderAndGetID(regId, model, brand, price, paymentStatus, deliveryStatus, userNIC);
                if (insertedID != -1)
                {
                    MessageBox.Show("Order placed successfully! Now you can download your Receipt");
                    // Print receipt
                    PrintReceipt(insertedID, DateTime.Now, regId, model, brand, price, paymentStatus, deliveryStatus, userNIC);
                }
                else
                {
                    MessageBox.Show("Failed to place order.");
                }
            }
            else if (result == DialogResult.No)
            {
                // Do nothing or show a message indicating that the order was not placed
                MessageBox.Show("The order was not placed.");
            }
        }

        private void btnDownloadReceipt_Click(object sender, EventArgs e)
        {
            // Show message box indicating that the receipt can be downloaded
            MessageBox.Show("Receipt can be downloaded.");
        }

        private void ClientViewPartsOrder_Load(object sender, EventArgs e)
        {

        }
    }
}