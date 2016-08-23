using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewAllJobApplications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["UserID"] != null && Session["UserType"] != null)
            //{
            //    if (((string)Session["UserType"]).Equals("Admin"))
            //    {
            //        localhost1.Service1 lc = new localhost1.Service1();
            //        string dis = "<h3>Job Applications</h3>";
            //        dis += "<p>View all the applications that happened on the system</p>";

            //        foreach(var app in lc.GetAllApplications())
            //        {
            //            dis += "<div class='row'>";
            //            var jobSeeker = lc.SingleJobseeker(Convert.ToInt32(app.JobSeekerID), true);
            //            dis += jobSeeker.FirstName + " " + jobSeeker.LastName + "Applied for a job <br/>";
            //            dis += "</div>";
            //        }
            //        Applications.InnerHtml = dis;
            //    }
            //    else
            //    {
            //        Response.Redirect("LoginPage.aspx");
            //    }
            //}
            //else
            //{
            //    Response.Redirect("LoginPage.aspx");
            //}
        }
    }
}