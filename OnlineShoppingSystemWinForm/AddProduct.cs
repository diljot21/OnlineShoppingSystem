using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary.Entities;
using ClassLibrary.DAL;

namespace OnlineShoppingSystemWinForm
{
    public partial class AddProduct : Form
    {
        private List<Category> _categories;
        private string imageDir;
        private string imageName = "";

        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            CategoryConnectedDao categoryDao = new CategoryConnectedDao();
            _categories = categoryDao.ReadAll();
            CmbProdCategory.DataSource = _categories;
            CmbProdCategory.DisplayMember = "CategoryName";
        }

        private void PbProductImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files (*.jpg; *.jpeg;)|*.jpg; *.jpeg;|All Files(*.*)|*.*";
            open.FilterIndex = 1;
            //open.ShowDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                PbProductImage.Image = new Bitmap(open.FileName);
                imageDir = open.FileName;
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            ProductConnectedDao productDao = new ProductConnectedDao();
            try
            {
                CheckImage();
                Product product = new Product(1, TxtProdName.Text, TxtProdDescription.Text, imageName, 
                    Double.Parse(TxtProdPrice.Text), ((Category)CmbProdCategory.SelectedItem).CategoryId);
                if (imageDir != null)
                {
                    File.Copy(imageDir, Path.Combine(
                        @"C:\Users\diljo\Desktop\C# Project\OnlineShoppingSystem\OnlineShoppingSystem\ClassLibrary\Images\ProductImages\", 
                        imageName), true);
                }
                productDao.AddProduct(product);
                MessageBox.Show("Product has been added!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex);
            }
        }

        private void CheckImage()
        {
            if (imageDir != null)
            {
                imageName = TxtProdName.Text + Path.GetExtension(imageDir);
            }
        }

        private void ClearFields()
        {
            imageDir = "";
            imageName = "";
            TxtProdName.Clear();
            TxtProdPrice.Clear();
            TxtProdDescription.Clear();
            CmbProdCategory.SelectedIndex = 0;
            PbProductImage.Image = null;
        }
    }
}
