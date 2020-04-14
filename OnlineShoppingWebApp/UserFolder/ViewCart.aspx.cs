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
            GvCartProducts.DataSource = (List<Product>)Session["CartProducts"];
            GvCartProducts.DataBind();
            if (PreviousPage != null && !IsPostBack)
            {
            }
            else
            {
                //Response.Redirect("~/UserFolder/Home.aspx");
            }
        }
    }
}