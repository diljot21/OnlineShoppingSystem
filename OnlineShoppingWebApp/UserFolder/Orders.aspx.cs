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
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OrderDao orderDao = new OrderDao();
                GvCustomerOrders.DataSource = orderDao.SpecificCustomerOrders(((Customer)Session["User"]).CustomerId);
                GvCustomerOrders.DataBind();
            }
        }
    }
}