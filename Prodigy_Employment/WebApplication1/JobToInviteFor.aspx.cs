using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class JobToInviteFor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.Service1 lc = new localhost.Service1();
            if (Session["UserID"] != null && Session["UserType"] != null)
            {             
                if (((string)Session["UserType"]).Equals("Employer"))//get emplyerID correctly
                {
                    int EmployerID = (int)Session["UserID"];
                    string htmlText = "";
                    htmlText = "<div class='page-header'><h1>Your jobs.</h1>";
                    htmlText += "<p class='text-muted'>Select a job that you would like this job seeker to be invited to. After the invitation the job seeker will view details of this job, and if the job seeker is interested  they will apply for this job. Ensure that the due date of the job that you select has not passed. </p>";
                    htmlText += "</div>";
                    htmlText += "<div class='card-columns'>";
                    foreach (var job in lc.EmployerSpecificJobs(EmployerID, true))
                    {
                        htmlText += "<div class='card'>";
                        htmlText += "<h3 class='card-header'>" + job.Name + "</h3>";
                        htmlText += "<p class='card-subtitle text-muted'> Date posted:" + job.DatePosted + "</p>";
                        htmlText += "<ul class='list-group list-group-flush'>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><b>Short description:</b> " + job.Description + "</li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><b>Required skill:</b> " + job.RequiredSkill + "</li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><b>Location:</b> " + job.Location + "</li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><b>Number of working days:</b> " + job.NumberOfDays + "</li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><b>Start date:</b> " + job.StartDate + "</li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><b>Daily starting time:</b> " + job.StartTime + "</li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><b>Daily knockoff time:</b> " + job.EndTime + "</li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><b>This job pays:</b> R" + job.ToBePaid + " after competion</li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><b>Apply before:</b> " + job.DueDate + "</li>";
                        string s = string.Format("<br/><a class='btn btn-success' style='border-radius:initial;' href='ConfirmInvite.aspx?JobID={0}'>Select job</a></br>", job.JobID);
                        htmlText += s;
                        htmlText += "</ul>";
                        htmlText += "</div>";
                    }
                    htmlText += "</div>";
                    JobsDisplay.InnerHtml = htmlText;
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