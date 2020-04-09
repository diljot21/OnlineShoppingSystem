using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShoppingWebApp.MasterContent
{
    public partial class UserWeb : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.Request.IsAuthenticated)//gets the request status from HttpRequest
            {
                LblMessage.Text = $"Welcome {Context.User.Identity.Name}";
            }
            else
            {
                LblMessage.Text = "Welcome user";
            }
            //BLogin.Visible = !Context.Request.IsAuthenticated;
            BLogout.Visible = Context.Request.IsAuthenticated;
        }

        protected void OnLogout(object sender, EventArgs e)
        {
            //removes the authentication ticket form browser, so that subsequent requests are not "authenticated"
            FormsAuthentication.SignOut();
            Session.Abandon();
            //Moving away from the page that is not accessible any more
            Response.Redirect("~/Anonymous/Login.aspx");
        }
    }
}