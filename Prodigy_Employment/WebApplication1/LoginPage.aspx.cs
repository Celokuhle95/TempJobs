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
            bool d,b,c,a;

            int id;
            string firstName;
            string lastName ;
            string address;
            string contactNumbers;
            string altanativeNumber;
            int authenticationLevel ;

            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string message;
            bl.LgnUser(email,Secrecy.HashPassword( password), out d, out b, out message);
           // mbox(d);
            if (d)
            {
                lblErr.Text = message;
             // bl.GetAllRecords(email, out lastName, out address, out contactNumbers, out altanativeNumber, out authenticationLevel, out a);
                bl.GetAllRecords(email, out id, out c, out firstName, out lastName, out address, out contactNumbers, out altanativeNumber, out authenticationLevel,out a);
               
                    if (id != -1)
                    {
                        Session.Add("UserEmail", email);
                        Session.Add("id",id);
                        Session.Add("firstName",firstName);
                        Session.Add("lastName",lastName);
                        Session.Add("address",address);
                        Session.Add("contactNumbers",contactNumbers);
                        Session.Add("altanativeNumber",altanativeNumber);
                        Session.Add("authenticationLevel",altanativeNumber);
                    }

                    Response.Redirect("HomePage.aspx");

            }
            else
            {
                lblErr.Text = message;
            }
        } 
    }
}