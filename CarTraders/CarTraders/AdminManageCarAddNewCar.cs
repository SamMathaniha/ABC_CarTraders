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
    public partial class AdminManageCarAddNewCar : Form
    {
        private string imagePath; // Class-level variable to store the image path
        private OpenFileDialog openFileDialog; // Declare OpenFileDialog at class level
        public AdminManageCarAddNewCar()
        {
            InitializeComponent();

            // Initialize the OpenFileDialog
            openFileDialog = new OpenFileDialog();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(txtbxRegID.Text) ||
                string.IsNullOrWhiteSpace(txtbxBrand.Text) ||
                string.IsNullOrWhiteSpace(txtbxModel.Text) ||
                string.IsNullOrWhiteSpace(txtbxYear.Text) ||
                string.IsNullOrWhiteSpace(txtbxColour.Text) ||
                string.IsNullOrWhiteSpace(txtbxCondition.Text) ||
                string.IsNullOrWhiteSpace(txtbxPrice.Text) ||
                string.IsNullOrWhiteSpace(txtbxTransmission.Text) ||
                string.IsNullOrWhiteSpace(txtbxDescription.Text) ||
                string.IsNullOrWhiteSpace(txtbxAvailableStock.Text) ||
                pictureBox.Image == null) // Check if an image is uploaded
            {
                MessageBox.Show("Please fill in all the fields and upload an image.");
                return;  // exit the method if fields are not filled
            }

            try
            {
                CarController carCtrl = new CarController();

                // Generate a unique image name with PNG extension
                string imageName = Guid.NewGuid().ToString() + ".png";
                string imagePath = Path.Combine(@"F:\A\Car Traders\Images\CarImages", imageName);

                // Save the image to the specified directory in PNG format
                pictureBox.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);

                // Convert string values to appropriate data types
                string RegID = txtbxRegID.Text;
                string brand = txtbxBrand.Text;
                string model = txtbxModel.Text;
                int year = int.Parse(txtbxYear.Text);
                string colour = txtbxColour.Text;
                string condition = txtbxCondition.Text;
                decimal price = decimal.Parse(txtbxPrice.Text);
                string transmission = txtbxTransmission.Text;
                string description = txtbxDescription.Text;
                int availableStock = int.Parse(txtbxAvailableStock.Text);

                // Create a new Cars object with converted values
                Cars newCar = new Cars(RegID, brand, model, year, colour, condition, price, transmission, description, availableStock, imageName);

                // Add the new car using the CarController
                carCtrl.AddNewCars(newCar);
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtbxRegID.Clear();
            txtbxBrand.Clear();
            txtbxModel.Clear();
            txtbxAvailableStock.Clear();
            txtbxTransmission.Clear();
            txtbxDescription.Clear();
            txtbxColour.Clear();
            txtbxCondition.Clear();
            txtbxPrice.Clear();
            txtbxYear.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManageCarsDashboard onb2 = new AdminManageCarsDashboard();
            onb2.Show();
            this.Close();
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
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set PictureBox size mode to Zoom
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur while loading the image
                    MessageBox.Show("Error loading the image: " + ex.Message);
                }

            }
        }

        private void AdminManageCarAddNewCar_Load(object sender, EventArgs e)
        {

        }

       

    }
}

