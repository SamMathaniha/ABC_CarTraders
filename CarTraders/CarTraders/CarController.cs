using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CarTraders
{
    class CarController
    {
        // Connection
        string connectionString = @"Data Source=DESKTOP-NVNSFIE;Initial Catalog=CarRentalTraders;Integrated Security=True";

        SqlConnection conn = null; // Declare the SqlConnection outside the try block

        //Add New Cars
        public void AddNewCars(Cars CarsObj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlInsert = @"INSERT INTO Cars(Reg_ID, Brand, Model, Year, Colour, Codition, Price, Transmission, Description, Stock, ImageName) 
                                 VALUES (@Reg_ID, @Brand, @Model, @Year, @Colour, @Codition, @Price, @Transmission, @Description, @Stock, @ImageName)";

                    using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@Reg_ID", CarsObj.Reg_ID);
                        cmd.Parameters.AddWithValue("@Brand", CarsObj.Brand);
                        cmd.Parameters.AddWithValue("@Model", CarsObj.Model);
                        cmd.Parameters.AddWithValue("@Year", CarsObj.Year);
                        cmd.Parameters.AddWithValue("@Colour", CarsObj.Colour);
                        cmd.Parameters.AddWithValue("@Codition", CarsObj.Codition);
                        cmd.Parameters.AddWithValue("@Price", CarsObj.Price);
                        cmd.Parameters.AddWithValue("@Transmission", CarsObj.Transmission);
                        cmd.Parameters.AddWithValue("@Description", CarsObj.Description);
                        cmd.Parameters.AddWithValue("@Stock", CarsObj.Stock);
                        cmd.Parameters.AddWithValue("@ImageName", CarsObj.ImageName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Added New Car Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add new car");
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

        public void UpdateCar(Cars CarsObj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlUpdate = @"UPDATE Cars 
                    SET 
                        Brand = @Brand,
                        Model = @Model, 
                        Year = @Year,
                        Colour = @Colour, 
                        Codition = @Codition, 
                        Price = @Price, 
                        Transmission = @Transmission, 
                        Description = @Description, 
                        Stock = @Stock, 
                        ImageName = @ImageName
                    WHERE Reg_ID = @Reg_ID";


                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@Reg_ID", CarsObj.Reg_ID);
                        cmd.Parameters.AddWithValue("@Brand", CarsObj.Brand);
                        cmd.Parameters.AddWithValue("@Model", CarsObj.Model);
                        cmd.Parameters.AddWithValue("@Year", CarsObj.Year);
                        cmd.Parameters.AddWithValue("@Colour", CarsObj.Colour);
                        cmd.Parameters.AddWithValue("@Codition", CarsObj.Codition);
                        cmd.Parameters.AddWithValue("@Price", CarsObj.Price);
                        cmd.Parameters.AddWithValue("@Transmission", CarsObj.Transmission);
                        cmd.Parameters.AddWithValue("@Description", CarsObj.Description);
                        cmd.Parameters.AddWithValue("@Stock", CarsObj.Stock);
                        cmd.Parameters.AddWithValue("@ImageName", CarsObj.ImageName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update car");
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

        public void DeleteCar(string regId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlDelete = @"DELETE FROM Cars WHERE Reg_ID = @Reg_ID";

                    using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("@Reg_ID", regId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete car");
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

        public int GetCarsCount()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT COUNT(*) FROM Cars";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception handling code
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return count;
        }






    }
}
