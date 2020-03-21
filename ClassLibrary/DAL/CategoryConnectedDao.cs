using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.DAL
{
    public class CategoryConnectedDao
    {
        public List<Category> ReadAll()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=OnlineShoppingSystem;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CATEGORIES"))
            {
                connection.Open();
                sqlCommand.Connection = connection;
                SqlDataReader reader = sqlCommand.ExecuteReader();

                // Read all data and add to list
                while (reader.Read())
                {
                    categories.Add(new Category(int.Parse(reader["categoryId"].ToString()), reader["categoryName"].ToString(), 
                        reader["categoryDescription"].ToString()));
                }
            }
            return categories;
        }
    }
}
