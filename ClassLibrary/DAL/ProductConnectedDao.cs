using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using ClassLibrary.Entities;

namespace ClassLibrary.DAL
{
    public class ProductConnectedDao
    {
        public List<Product> ReadAll()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=OnlineShoppingSystem;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PRODUCT"))
            {
                connection.Open();
                sqlCommand.Connection = connection;
                SqlDataReader reader = sqlCommand.ExecuteReader();

                // Read all data and add to list
                while (reader.Read())
                {
                    products.Add(new Product(reader.GetInt32(0), reader.GetString(1), reader["productDescription"].ToString(), 
                        reader["productImage"].ToString(), reader.GetDouble(4), reader.GetInt32(5)));
                }
            }
            return products;
        }

        public void AddProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=OnlineShoppingSystem;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand($"insert into product (productName, productDescription, productImage, " +
                $"productPrice, categoryId) values (@PName, @PDesc, @PImage, @PPrice, @PCatId)")
            )
            {
                connection.Open();
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.AddWithValue("PName", product.ProductName);
                sqlCommand.Parameters.AddWithValue("PDesc", product.ProductDescription);
                sqlCommand.Parameters.AddWithValue("PImage", product.ProductImage);
                sqlCommand.Parameters.AddWithValue("PPrice", product.ProductPrice);
                sqlCommand.Parameters.AddWithValue("PCatId", product.CategoryId);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=OnlineShoppingSystem;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand($"DELETE FROM Product WHERE productId = @PId")
            )
            {
                connection.Open();
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.AddWithValue("PId", productId);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {

        }
    }
}
