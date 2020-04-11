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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && !IsPostBack)
            {
                GvCartProducts.DataSource = (List<Product>)Session["CartProducts"];
                GvCartProducts.DataBind();
            }
            else
            {
                Response.Redirect("~/UserFolder/Home.aspx");
            }
        }
    }
}