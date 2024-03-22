using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarTraders
{
    public partial class AdminManageCarViewDeleteUpdate : Form
    {
        private string imagePath; // Class-level variable to store the image path
        private OpenFileDialog openFileDialog; // Declare OpenFileDialog at class level
        public AdminManageCarViewDeleteUpdate()
        {
            InitializeComponent();

            // Initialize the OpenFileDialog
            openFileDialog = new OpenFileDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // Creating a method to populate fields and display image
        public void PopulateFields(string regId, string brand, string model, int year, string colour, string condition, decimal price, string transmission, string description, int stock, string imageName, string imagePath)
        {
            // Populate the fields in the form with the provided data
            txtbxRegID.Text = regId;
            txtbxBrand.Text = brand;
            txtbxModel.Text = model;
            txtbxYear.Text = year.ToString();
            txtbxColour.Text = colour;
            txtbxCondition.Text = condition;
            txtbxPrice.Text = price.ToString();
            txtbxTransmission.Text = transmission;
            txtbxDescription.Text = description;
            txtbxAvailableStock.Text = stock.ToString();
            txtbxImageName.Text = imageName.ToString();

            // Load and display the image in the PictureBox
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set PictureBox size mode to Zoom
            pictureBox.Image = Image.FromFile(imagePath);
        }

        //this to check whether image works correctly
        public void LoadImage(string imagePath)
        {
            // Check if the file exists
            if (File.Exists(imagePath))
            {
                // Load the image into the PictureBox
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set PictureBox size mode to Zoom
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Display a message if the image file does not exist
                MessageBox.Show("Image file not found: " + imagePath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManageCarsDashboard obj2 = new AdminManageCarsDashboard();
            obj2.Show();
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            CarController CarCtl = new CarController();
            Cars T1 = new Cars(txtbxRegID.Text, txtbxBrand.Text, txtbxModel.Text, int.Parse(txtbxYear.Text), txtbxColour.Text, txtbxCondition.Text, decimal.Parse(txtbxPrice.Text), txtbxTransmission.Text, txtbxDescription.Text, int.Parse(txtbxAvailableStock.Text), txtbxImageName.Text);
            CarCtl.UpdateCar(T1);


        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            CarController carController = new CarController();
            string regIdToDelete = txtbxRegID.Text;
            carController.DeleteCar(regIdToDelete);
        }

        private void AdminManageCarViewDeleteUpdate_Load(object sender, EventArgs e)
        {

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
    }
}
