using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewAllJobInvites : System.Web.UI.Page
    {
        localhost1.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("Admin"))
                {
                    lc = new localhost1.Service1();
                    string dis = "<h3>Job Invites</h3>";
                    dis += "<p>View all the job invites that happened on the system between Job Seekers and Employers</p>";

                    foreach (var inv in lc.GetAllInvites())
                    {
                        dis += "<div class='row'>";
                        var jobSeeker = lc.SingleJobseeker(Convert.ToInt32(inv.JobSeekerID), true);
                        var employer = lc.SingleEmployer(Convert.ToInt32(inv.EmployerID), true);
                        dis += employer.FirstName + " " + employer.LastName + "(Employer)... INVITED... " + jobSeeker.FirstName + " " + jobSeeker.LastName + "(JobSeeker)<br/>";
                        dis += "</div>";
                    }
                    Invites.InnerHtml = dis;
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