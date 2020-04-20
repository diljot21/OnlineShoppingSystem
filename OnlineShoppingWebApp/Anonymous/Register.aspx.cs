using ClassLibrary.DAL;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShoppingWebApp.Anonymous
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("~/UserFolder/Home.aspx");
            }
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            CustomerDao customerDao = new CustomerDao();
            if (!customerDao.UsernameDuplicateCheck(TxtUsername.Text))
            {
                try
                {
                    Customer customer = new Customer(TxtUsername.Text, TxtPassword.Text, TxtEmail.Text, TxtFirstName.Text,
                        TxtLastName.Text, long.Parse(TxtPhoneNumber.Text), TxtAddress.Text, TxtPostalCode.Text);
                    customerDao.AddCustomer(customer);
                    Response.Redirect("Login.aspx");
                } 
                catch(Exception ex)
                {
                    LblStatus.Text = ex.Message;
                }
            }
            else
            {
                LblStatus.Text = "Email already registered";
            }
        }
    }
}