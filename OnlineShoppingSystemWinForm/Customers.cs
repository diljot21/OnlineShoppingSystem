using ClassLibrary.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShoppingSystemWinForm
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            CustomerDao customerDao = new CustomerDao();
            DgCustomers.DataSource = customerDao.ReadAll();
        }
    }
}
