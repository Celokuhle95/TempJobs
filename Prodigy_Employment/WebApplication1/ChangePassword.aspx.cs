using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {   
            localhost1.Service1 localhost = new localhost1.Service1();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string cPassword = txtConfirmPassword.Text;

            if(!password.Equals(cPassword))
            {
                lblError.Text = "Make sure the passwords you enter are the same";
                lblError.Visible = true;
            }else
            {
                bool passwordChangeSuccessful,a;
                localhost.ChangeEmployerPassword(username, Secrecy.HashPassword(password), out passwordChangeSuccessful, out a);
                if(!passwordChangeSuccessful)
                {
                    localhost.ChangeJobSeekerPassword(username, Secrecy.HashPassword(password), out passwordChangeSuccessful, out a);
                    if (!passwordChangeSuccessful)
                    {
                        lblError.Text = "Make sure you enter the correct username";
                        lblError.Visible = true;

                    }
                    else
                    {
                        Response.Redirect("LoginPage.aspx");
                    }                   
                }
                else
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
        }
    }
}