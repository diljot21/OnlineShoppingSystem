using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
    public class CustomerDao
    {
        private List<Customer> _customers;
        public Customer MemberLogin(string email, string password)
        {
            _customers = ReadAll();
            foreach (Customer customer in _customers)
            {
                if (customer.Username == email && customer.Password == password) return customer;
            }
            return null;
        }

        public void AddCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=OnlineShoppingSystem;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand($"insert into product (Username, Password, Email, FirstName, LastName, " +
                $"Phone, Address, PostalCode) values (@CUsername, @CPassword, @CEmail, @CFirstName, @CLastName, @CPhone, @CAddress, @CPostalCode)")
            )
            {
                connection.Open();
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.AddWithValue("CUsername", customer.Username);
                sqlCommand.Parameters.AddWithValue("CPassword", customer.Password);
                sqlCommand.Parameters.AddWithValue("CEmail", customer.Email);
                sqlCommand.Parameters.AddWithValue("CFirstName", customer.FirstName);
                sqlCommand.Parameters.AddWithValue("CLastName", customer.LastName);
                sqlCommand.Parameters.AddWithValue("CPhone", customer.Phone);
                sqlCommand.Parameters.AddWithValue("CAddress", customer.Address);
                sqlCommand.Parameters.AddWithValue("CPostalCode", customer.PostalCode);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public List<Customer> ReadAll()
        {
            _customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=OnlineShoppingSystem;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CUSTOMER"))
            {
                connection.Open();
                sqlCommand.Connection = connection;
                SqlDataReader reader = sqlCommand.ExecuteReader();

                // Read all data and add to list
                while (reader.Read())
                {
                    _customers.Add(new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                         reader.GetString(4), reader.GetString(5), reader.GetInt64(6), reader.GetString(7), reader.GetString(8)));
                }
            }
            return _customers;
        }
    }
}
