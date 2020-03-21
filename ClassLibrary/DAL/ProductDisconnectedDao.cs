using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
    public class ProductDisconnectedDao
    {

        SqlDataAdapter _dataAdapter = null;
        DataTable _productTable = new DataTable();

        public ProductDisconnectedDao()
        {
            _dataAdapter = new SqlDataAdapter("SELECT * FROM PRODUCT",
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=OnlineShoppingSystem;Integrated Security=True");
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_dataAdapter);//generates the Insert, Update and Delete commands
            _dataAdapter.Fill(_productTable);
        }

        public List<Product> ReadAll()
        {
            List<Product> products = new List<Product>();
            foreach (DataRow productRow in _productTable.Rows)
            {
                products.Add(new Product(Convert.ToInt32(productRow[0]), productRow[1].ToString(), productRow[2].ToString(), 
                    productRow[3].ToString(), Convert.ToDouble(productRow[4]), Convert.ToInt32(productRow[5])));
            }
            return products;
        }
    }
}
