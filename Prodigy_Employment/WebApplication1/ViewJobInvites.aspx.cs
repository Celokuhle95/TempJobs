using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewJobInvites : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("JobSeeker"))
                {
                    string htmlText = "<h3 style='text-align'>Job Invitation.</h3>";
                    htmlText += "<br/><p>You have an invite from an Employer who viewed your profile and currently has a job posted that you can apply for. Recieving this invite means the Employer is interested employing you for the job they currently have posted.";
                    htmlText += "The employer must have saw that your skills are neccessarry for the job, which means that if you apply for this job you have a higher chance of actually geting employer</p>";
                    htmlText += "<p>Below is a list of jobs the employer currently has posterd</p><br/><br/>";

                    localhost1.Service1 localhost = new localhost1.Service1();
                    foreach (var job in localhost.EmployerSpecificJobs(EmployerID))
                    {
                        htmlText += "<div class='row' style='border:groove'>";
                        htmlText += "<h2>" + job.Name + "</h2>";
                        htmlText += "<hr style='color:goldenrod'/>";
                        htmlText += "<u>Description</u>: " + job.Description + "<br/>";
                        htmlText += "<u>Location </u>:" + job.Location + "<br/>";
                        htmlText += "<u>Daily Starting Time</u>: " + job.StartTime + " <br/>";
                        htmlText += "<u>Daily Knockoff Time</u>: " + job.EndTime + " <br/>";
                        htmlText += "<u>Pay(After the whole job is complete)</u>:<b> R" + job.ToBePaid + "</b><br/>";
                        string s = string.Format("<a class='btn btn-success' href='ConfirmJobApplication.aspx?JobID={0}'>Apply for job</a></br>", job.JobID);
                        htmlText += s + "<br/></div> <br/>";
                    }
                   ViewInvites.InnerHtml = htmlText;
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