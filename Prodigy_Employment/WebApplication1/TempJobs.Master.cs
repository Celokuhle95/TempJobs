using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prodigy_Employment
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        WebApplication1.localhost.Service1 lc = new WebApplication1.localhost.Service1();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["id"] != null)
            {
                int userID = (int)Session["id"];
                string usertype = (string)Session["UserType"];
                if(usertype.Equals("Employer"))
                {
                    lblPostJob.Visible = true;
                    lblViewJobseekers.Visible = true;
                }
                else if(usertype.Equals("JobSeeker"))
                {
                    lblViewJobs.Visible = true;
                    lblProfile.Visible = true;
                }

                lblLogin.Visible = false;
                lblRes.Visible = false;
                lblLogout.Visible = true;
                   
            }
        }
    }
}