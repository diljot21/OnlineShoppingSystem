using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Entities
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private string _productDescription;
        private string _productImage;
        private double _productPrice;
        private int _categoryId;
        private int _quantity;

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public string ProductDescription
        {
            get { return _productDescription; }
            set { _productDescription = value; }
        }
        public string ProductImage
        {
            get { return _productImage; }
            set { _productImage = value; }
        }
        public double ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }
        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public Product(int productId, string productName, string productDescription, string productImage, 
            double productPrice, int categoryId, int quantity=0)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductImage = productImage;
            ProductPrice = productPrice;
            CategoryId = categoryId;
            Quantity = quantity;
        }
    }
}
