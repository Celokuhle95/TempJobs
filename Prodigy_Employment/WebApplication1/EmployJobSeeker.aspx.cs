using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class EmployJobSeeker : System.Web.UI.Page
    {
        localhost1.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Session["UserType"].Equals("Employer") || Session["UserID"] != null )
            {
                lc = new localhost1.Service1();
                int JobSeekerID = Convert.ToInt32(Request.QueryString["JobSeekrID"]);
                //employ also send notification to notify JobSeeker about the employment opportunity.

            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }     
        }
    }
}