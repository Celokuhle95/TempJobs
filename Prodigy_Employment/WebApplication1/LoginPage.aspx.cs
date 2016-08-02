using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LoginPage : System.Web.UI.Page
    {
        public localhost1.Service1 bl;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            bl = new localhost1.Service1();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {          
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            int userID;
            bool a, b;
            bool canLogin;

            bl.LoginEmployer(userName, Secrecy.HashPassword(password), out userID, out a, out canLogin, out b);
            if(canLogin)
            {
                Session.Add("UserID", userID);
                Session.Add("UserType", "Employer");
                Response.Redirect("Home.aspx");
            }
            else
            {
                bl.LoginJobSeeker(userName, Secrecy.HashPassword(password), out userID, out a, out canLogin, out b);
                if(canLogin)
                {
                    Session.Add("UserID", userID);
                    Session.Add("UserType", "JobSeeker");
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    bl.LoginAdmin(userName, Secrecy.HashPassword(password), out userID, out a, out canLogin, out b);
                    if(canLogin)
                    {
                        Session.Add("UserID", userID);
                        Session.Add("UserType", "Admin");
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        lblErr.Text = "Username/password incorrect";
                        lblErr.Visible = true;
                        return;
                    }
                }
            }
        } 
    }
}