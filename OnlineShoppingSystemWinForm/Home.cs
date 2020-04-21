using ClassLibrary.DAL;
using ClassLibrary.Entities;
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
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }
        

        private void BtnViewProducts_Click(object sender, EventArgs e)
        {
            ViewProducts frm = new ViewProducts();
            frm.ShowDialog();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            Orders frm = new Orders();
            frm.ShowDialog();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            Customers frm = new Customers();
            frm.ShowDialog();
        }
    }
}
