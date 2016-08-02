using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        localhost1.Service1 lc = new localhost1.Service1();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"] != null)
            {
                int userID = (int)Session["UserID"];
                string usertype = (string)Session["UserType"];
                if (usertype.Equals("Employer"))
                {
                    lblPostJob.Visible = true;
                    lblViewJobseekers.Visible = true;
                    lblLogin.Visible = false;
                    lblRes.Visible = false;
                    lblLogout.Visible = true;
                }
                else if (usertype.Equals("JobSeeker"))
                {
                    lblViewJobs.Visible = true;
                    lblProfile.Visible = true;
                    lblLogin.Visible = false;
                    lblRes.Visible = false;
                    lblLogout.Visible = true;
                }

                

            }
        }
    }
}