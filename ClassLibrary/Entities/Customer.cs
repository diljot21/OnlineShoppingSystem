using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Phone { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public Customer(int customerId, string username, string password, string email, string firstName, string lastName, 
            long phone, string address, string postalCode)
        {
            CustomerId = customerId;
            Username = username;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Address = address;
            PostalCode = postalCode;
        }
    }
}
