using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
    public class OrderDao
    {
        public void AddOrder(List<Product> cartItems, int customerId)
        {
            int newId = 0;
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=OnlineShoppingSystem;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand($"insert into [Order] (CustomerId, OrderDate, OrderTotal) values (@OCustId, @OOrderDate, @OOrderTotal); SELECT SCOPE_IDENTITY()")
            )
            {
                connection.Open();
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.AddWithValue("@OCustId", customerId);
                sqlCommand.Parameters.AddWithValue("@OOrderDate", DateTime.Now.ToString());
                sqlCommand.Parameters.AddWithValue("@OOrderTotal", "32");
                //sqlCommand.ExecuteNonQuery();

                newId = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }

            AddOrderProduct(cartItems, newId);
        }

        public void AddOrderProduct(List<Product> cartItems, int newId)
        {

            foreach (Product product in cartItems)
            {
                using (SqlConnection connection = new SqlConnection(
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=OnlineShoppingSystem;Integrated Security=True"))
                using (SqlCommand sqlCommand = new SqlCommand($"INSERT INTO [OrderProduct] (OrderId, ProductId, Quantity) " +
                    $"VALUES (@OOrderId, @OProductId, @OQuantity)")
                )
                {
                    connection.Open();
                    sqlCommand.Connection = connection;
                    sqlCommand.Parameters.AddWithValue("OOrderId", newId);
                    sqlCommand.Parameters.AddWithValue("OProductId", product.ProductId);
                    sqlCommand.Parameters.AddWithValue("OQuantity", product.Quantity);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
