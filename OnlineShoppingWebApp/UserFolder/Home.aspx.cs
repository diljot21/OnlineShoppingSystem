using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary.DAL;

namespace OnlineShoppingWebApp.UserFolder
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductConnectedDao productConnectedDao = new ProductConnectedDao();
            Session["ProductList"] = productConnectedDao.ReadAll();
        }
    }
}