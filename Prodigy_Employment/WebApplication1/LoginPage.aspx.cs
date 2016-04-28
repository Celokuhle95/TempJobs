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
        public localhost.Service1 bl;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            bl = new localhost.Service1();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {          
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            int id;
            bool a, b;
            bool canLogin;

            bl.LgnUser(userName, Secrecy.HashPassword(password), out id, out a, out canLogin, out b);
            
            if (canLogin)
            {
                Session.Add("id", id);
                var user = bl.SingleUserDetails(id, true); //get details of curr user
                if (user.authinticationLevel.Equals(1))//check user auth to dee if user is an employer or jobseeker
                {
                    Session.Add("UserType", "Employer");
                }
                else if (user.authinticationLevel.Equals(2))
                {
                    Session.Add("UserType", "JobSeeker");
                }
                Response.Redirect("Homepage.aspx");
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