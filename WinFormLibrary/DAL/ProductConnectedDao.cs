using System;
using System.Collections.Generic;
using System.Text;
using WinFormLibrary.Entities;

namespace WinFormLibrary.DAL
{
    public class ProductConnectedDao
    {
        public List<Product> ReadAll()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=CollegeDb;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM STUDENT"))
            {
                connection.Open();
                sqlCommand.Connection = connection;
                SqlDataReader reader = sqlCommand.ExecuteReader();

                // Read all data and add to list
                while (reader.Read())
                {
                    students.Add(new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
            }
            return students;
        }
    }
}
