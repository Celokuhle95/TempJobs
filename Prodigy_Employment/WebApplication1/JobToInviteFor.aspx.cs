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
                    htmlText += "<h2>Jobs<h2><br/>";
                    htmlText += "<p>Select a job that you would like this job seeker to be invited to. After the invitation the job seeker will view details of this job, and if the job seeker is interested  they will apply for this job. Ensure that the due date of the job that you select has not passed. </p>";
                    htmlText += "<div class='row' style='border:groove'>";
                    foreach (var job in lc.EmployerSpecificJobs(EmployerID, true))
                    {
                        htmlText += "<div class='col-md-4'>";                        
                        htmlText += "<h2>" + job.Name + "</h2>";
                        htmlText += "<hr style='color:goldenrod'/>";
                        htmlText += "<u>Short Job Description</u>: " + job.Description + "<br/>";
                        htmlText += "<u>Location </u>:" + job.Location + "<br/>";
                        htmlText += "<u>Job Start Day</u>:" + job.StartDate + "<br/>";
                        htmlText += "<u>Daily Starting Time</u>: " + job.StartTime + " <br/>";
                        htmlText += "<u>Daily Knockoff Time</u>: " + job.EndTime + " <br/>";
                        htmlText += "<u>Due date(Apply before this day): </u>:" + job.DueDate + "<br/>";
                        htmlText += "<u>Pay(After the whole job is complete)</u>:<b> R" + job.ToBePaid;
                        string s = string.Format("<a class='btn btn-success' href='ConfirmInvite.aspx?JobID={0}'>Invite to this job</a></br>", job.JobID);
                        htmlText += s;
                        htmlText += "</b><br/></div>";
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