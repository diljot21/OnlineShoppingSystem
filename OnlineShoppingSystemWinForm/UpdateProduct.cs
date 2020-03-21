using ClassLibrary.Entities;
using System;
using System.IO;
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
    public partial class UpdateProduct : Form
    {
        private Product _product;

        public UpdateProduct(Product product)
        {
            _product = product;
            InitializeComponent();
        }

        private void FillData()
        {
            TxtProdId.Text = _product.ProductId.ToString();
            TxtProdName.Text = _product.ProductName;
            TxtProdPrice.Text = _product.ProductPrice.ToString();
            TxtProdDescription.Text = _product.ProductDescription;
            CmbProdCategory.Text = _product.CategoryId.ToString();
            if (!string.IsNullOrEmpty(_product.ProductImage))
            {
                FillProductImage();
            }
        }

        private void FillProductImage()
        {
            try
            {
                Image image = Image.FromFile(
                @"C:\Users\diljo\Desktop\C# Project\OnlineShoppingSystem\OnlineShoppingSystem\ClassLibrary\Images\ProductImages\" +
                _product.ProductImage);
                PbProductImage.Image = image;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Image" + _product.ProductImage + " not found.");
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            FillData();
        }

    }
}
