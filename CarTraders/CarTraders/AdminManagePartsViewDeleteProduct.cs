using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class AdminManagePartsViewDeleteProduct : Form
    {
        private string imagePath; // Class-level variable to store the image path
        private OpenFileDialog openFileDialog; // Declare OpenFileDialog at class level
        public AdminManagePartsViewDeleteProduct()
        {
            InitializeComponent();
            // Initialize the OpenFileDialog
            openFileDialog = new OpenFileDialog();

        }

        // Creating a method to populate fields and display image
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
            txtbxImageName.Text = imageName.ToString();

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

        private void txtbxImageName_TextChanged(object sender, EventArgs e)
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
            CarPartsController PartsCtl = new CarPartsController();
            CarParts T1 = new CarParts(txtbxPartsRegID.Text, txtbxPartsProduct.Text, txtbxPartsCategory.Text, txtbxPartsBrand.Text, decimal.Parse(txtbxPartsPrice.Text), txtbxPartsCompatibility.Text, txtbxPartsCondition.Text, int.Parse(txtbxPartsStock.Text), txtbxImageName.Text);
            PartsCtl.UpdateProductPart(T1);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CarPartsController carpartsCntrl = new CarPartsController();
            string regIdToDelete = txtbxPartsRegID.Text;
            carpartsCntrl.DeleteProductparts(regIdToDelete);
        }

        private void AdminManagePartsViewDeleteProduct_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManagePartsDashboard closebtn = new AdminManagePartsDashboard();
            closebtn.Show();
            this.Close();
        }
    }
}
