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
    public partial class ViewProducts : Form
    {
        ProductConnectedDao pcd = new ProductConnectedDao();
        List<Product> products = new List<Product>();

        public ViewProducts()
        {
            InitializeComponent();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            ShowProductList();
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dgProducts.CurrentRow.DataBoundItem;
            UpdateProduct frm = new UpdateProduct(selectedProduct);
            frm.ShowDialog();
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete This Product?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                Product selectedProduct = (Product)dgProducts.CurrentRow.DataBoundItem;
                ProductConnectedDao productDao = new ProductConnectedDao();
                pcd.DeleteProduct(selectedProduct.ProductId);
                ShowProductList();
            }
        }

        private void ShowProductList()
        {
            products = pcd.ReadAll();
            dgProducts.DataSource = products;
            dgProducts.Refresh();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct();
            frm.ShowDialog();
        }
    }
}
