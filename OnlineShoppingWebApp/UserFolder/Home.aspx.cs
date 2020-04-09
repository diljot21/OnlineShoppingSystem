using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary.DAL;
using ClassLibrary.Entities;

namespace OnlineShoppingWebApp.UserFolder
{
    public partial class Home : System.Web.UI.Page
    {
        private List<Product> _products; 
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductConnectedDao productConnectedDao = new ProductConnectedDao();
            _products = productConnectedDao.ReadAll();
            Session["ProductList"] = concatImage();
            if (!IsPostBack)
            {
                GvProducts.DataSource = (List<Product>) Session["ProductList"];
                GvProducts.DataBind();
            }
        }

        protected List<Product> concatImage()
        {
            List<Product> concatProd = new List<Product>();
            foreach(Product product in _products)
            {
                product.ProductImage = @"~\ClassLibrary\Images\ProductImages\" + product.ProductImage;
                concatProd.Add(product);
            }
            return concatProd;
        }
    }
}