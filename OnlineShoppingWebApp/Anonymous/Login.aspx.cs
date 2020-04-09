using ClassLibrary.DAL;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShoppingWebApp.Anonymous
{
    public partial class Login : System.Web.UI.Page
    {
        private CustomerDao _customerDao = new CustomerDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("~/UserFolder/Home.aspx");
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsername.Text) && !string.IsNullOrEmpty(TxtPassword.Text))
            {
                Customer isAuthenticated = _customerDao.MemberLogin(TxtUsername.Text, TxtPassword.Text);
                if (isAuthenticated != null)
                {
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(isAuthenticated.FirstName, false, 10);
                    string encTicket = FormsAuthentication.Encrypt(ticket);
                    Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
                    if (Session["User"] == null)
                    {
                        Session["User"] = isAuthenticated;
                    }
                    FormsAuthentication.RedirectFromLoginPage(isAuthenticated.FirstName, false);
                }
                else
                {
                    LblLoginStatus.Text = "Incorrect username or password";
                }
            }
            else
            {
                LblLoginStatus.Text = "Username or Password cannot be empty!";
            }
        }
    }
}