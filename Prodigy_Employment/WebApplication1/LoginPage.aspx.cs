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
            int id;
            bool d, b, idSpicified;
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string message;
            bl.LgnUser(userName, Secrecy.HashPassword(password), out d, out b, out message, out id, out idSpicified);
            // mbox(d);
            if (d)
            {
                if (id == -1)
                {
                    lblErr.Text = message;
                    lblErr.Visible = true;
                    return;             
                }
                else
                {
                    Session.Add("id", id);
                    var user = bl.SingleUserDetails(id, true); //get details of curr user
                    if (user.authinticationLevel.Equals(1))//check user auth to dee if user is an employer or jobseeker
                    {
                        Session.Add("UserType", "Employer");
                        if (Session["EmployerID"] == null)
                        {
                            bl.storeEmployers(0, true, 0, true, "", "true", id, true);
                            foreach(var employer in bl.ReadEmployers())
                            {
                                if(employer.UserData_ID == id)
                                {
                                    Session.Add("EmployerID", employer.Employer_Id);
                                }
                            }
                           
                        }
                    }
                    else if (user.authinticationLevel.Equals(2))
                    {
                        Session.Add("UserType", "JobSeeker");
                    }
                    

                    Response.Redirect("Homepage.aspx");
                }

            }
            else
            {
                lblErr.Text = message;
                lblErr.Visible = true;
            }
        } 
    }
}