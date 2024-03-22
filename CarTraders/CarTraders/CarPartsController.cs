using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
     class CarPartsController
    {
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";

        SqlConnection conn = null; // Declare the SqlConnection outside the try block

        //Add New Cars parts
        public void AddNewProductParts(CarParts CarPartsObj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlInsert = @"INSERT INTO CarParts(Reg_ID, Product, Category, Brand, Price, Compatibility, Condition, Stock, ImageName) 
                                 VALUES (@Reg_ID, @Product, @Category, @Brand, @Price, @Compatibility, @Condition, @Stock, @ImageName)";

                    using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@Reg_ID", CarPartsObj.Reg_ID);
                        cmd.Parameters.AddWithValue("@Product", CarPartsObj.Product);
                        cmd.Parameters.AddWithValue("@Category", CarPartsObj.Category);
                        cmd.Parameters.AddWithValue("@Brand", CarPartsObj.Brand);
                        cmd.Parameters.AddWithValue("@Price", CarPartsObj.Price);
                        cmd.Parameters.AddWithValue("@Compatibility", CarPartsObj.Compatibility);
                        cmd.Parameters.AddWithValue("@Condition", CarPartsObj.Condition);
                        cmd.Parameters.AddWithValue("@Stock", CarPartsObj.Stock);
                        cmd.Parameters.AddWithValue("@ImageName", CarPartsObj.ImageName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Added New Product Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add new Product");
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

        public void UpdateProductPart(CarParts CarPartsObj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlUpdate = @"UPDATE CarParts 
                    SET 
                        Product = @Product, 
                        Category = @Category,
                        Brand = @Brand, 
                        Price = @Price, 
                        Compatibility = @Compatibility, 
                        Condition = @Condition, 
                        Stock = @Stock, 
                        ImageName = @ImageName
                    WHERE Reg_ID = @Reg_ID";


                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@Reg_ID", CarPartsObj.Reg_ID);
                        cmd.Parameters.AddWithValue("@Product", CarPartsObj.Product);
                        cmd.Parameters.AddWithValue("@Category", CarPartsObj.Category);
                        cmd.Parameters.AddWithValue("@Brand", CarPartsObj.Brand);
                        cmd.Parameters.AddWithValue("@Price", CarPartsObj.Price);
                        cmd.Parameters.AddWithValue("@Compatibility", CarPartsObj.Compatibility);
                        cmd.Parameters.AddWithValue("@Condition", CarPartsObj.Condition);
                        cmd.Parameters.AddWithValue("@Stock", CarPartsObj.Stock);
                        cmd.Parameters.AddWithValue("@ImageName", CarPartsObj.ImageName);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Product");
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

        public void DeleteProductparts(string regId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlDelete = @"DELETE FROM CarParts WHERE Reg_ID = @Reg_ID";

                    using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("@Reg_ID", regId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete Product");
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
