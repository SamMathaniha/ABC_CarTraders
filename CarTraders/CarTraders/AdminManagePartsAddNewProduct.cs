using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class AdminManagePartsAddNewProduct : Form
    {
        private string imagePath; // Class-level variable to store the image path
        private OpenFileDialog openFileDialog; // Declare OpenFileDialog at class level
        public AdminManagePartsAddNewProduct()
        {
            InitializeComponent();

            // Initialize the OpenFileDialog
            openFileDialog = new OpenFileDialog();

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(txtbxPartsRegID.Text) ||
                string.IsNullOrWhiteSpace(txtbxPartsProduct.Text) ||
                string.IsNullOrWhiteSpace(txtbxPartsCategory.Text) ||
                string.IsNullOrWhiteSpace(txtbxPartsBrand.Text) ||
                string.IsNullOrWhiteSpace(txtbxPartsPrice.Text) ||
                string.IsNullOrWhiteSpace(txtbxPartsCompatibility.Text) ||
                string.IsNullOrWhiteSpace(txtbxPartsCondition.Text) ||
                string.IsNullOrWhiteSpace(txtbxPartsStock.Text) ||
                pictureBoxParts.Image == null) // Check if an image is uploaded
            {
                MessageBox.Show("Please fill in all the fields and upload an image.");
                return;  // exit the method if fields are not filled
            }

            try
            {
                CarPartsController carCtrl = new CarPartsController();

                // Generate a unique image name with PNG extension
                string imageName = Guid.NewGuid().ToString() + ".png";
                string imagePath = Path.Combine(@"F:\A\Car Traders\Images\CarPartsImages", imageName);

                // Save the image to the specified directory in PNG format
                pictureBoxParts.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);

                // Convert string values to appropriate data types
                string RegID = txtbxPartsRegID.Text;
                string Product = txtbxPartsProduct.Text;
                string Category = txtbxPartsCategory.Text;
                string Brand = txtbxPartsBrand.Text;
                decimal price = decimal.Parse(txtbxPartsPrice.Text);
                string Compatibility = txtbxPartsCompatibility.Text;
                string Condition = txtbxPartsCondition.Text;
                int Stock = int.Parse(txtbxPartsStock.Text);

                // Create a new Cars object with converted values
                CarParts newProduct = new CarParts(RegID, Product, Category, Brand, price, Compatibility, Condition, Stock, imageName);

                // Add the new car using the CarController
                carCtrl.AddNewProductParts(newProduct);
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            // Set filters to only show image files
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            // Display the OpenFileDialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the selected image file path and store it in the class-level variable
                    imagePath = openFileDialog.FileName;

                    // Display the image in the PictureBox
                    pictureBoxParts.SizeMode = PictureBoxSizeMode.Zoom; // Set PictureBox size mode to Zoom
                    pictureBoxParts.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur while loading the image
                    MessageBox.Show("Error loading the image: " + ex.Message);
                }

            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtbxPartsRegID.Clear();
            txtbxPartsStock.Clear();
            txtbxPartsCondition.Clear();
            txtbxPartsProduct.Clear();
            txtbxPartsCategory.Clear();
            txtbxPartsBrand.Clear();
            txtbxPartsCompatibility.Clear();
            txtbxPartsPrice.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManagePartsDashboard closebtn = new AdminManagePartsDashboard();
            closebtn.Show();
            this.Close();
        }
    }
}
