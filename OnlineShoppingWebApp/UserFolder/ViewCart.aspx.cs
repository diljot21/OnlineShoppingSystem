using ClassLibrary.DAL;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShoppingWebApp.UserFolder
{
    public partial class ViewCart : System.Web.UI.Page
    {
        private List<Product> _products;
        protected void Page_Load(object sender, EventArgs e)
        {
            _products = (List<Product>)Session["CartProducts"];
            GvCartProducts.DataSource = _products;
            GvCartProducts.DataBind();
        }

        protected void BtnCheckout_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/UserFolder/Home.aspx");
            foreach (GridViewRow row in GvCartProducts.Rows)
            {
                TextBox tb = (TextBox)row.FindControl("Quantity");
                int quantity = int.Parse(tb.Text);
                _products.Find(prod => prod.ProductName == row.Cells[1].Text).Quantity = quantity;
            }
            OrderDao orderDao = new OrderDao();
            orderDao.AddOrder(_products);
        }
    }
}