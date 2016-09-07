using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewJobs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                string htmlText = "<div style='page-header'><h1>Available jobs.</h1></div>";
                localhost.Service1 localhost = new localhost.Service1();
                htmlText += "<div class='card-columns'>";
                foreach (var job in localhost.AllJobs())
                {                  
                    htmlText += "<div class='card'>";
                    htmlText += "<h3 card='card-header'>" + job.Name + "</h3>";
                    htmlText += "<p class='card-subtitle text-muted'> Date posted:" + job.DatePosted + "</p>";
                    htmlText += "<div class='card-block'><b>Short description:</b> " + job.Description + "</div>";
                    htmlText += "<div class='card-block'><b>Required skill:</b> " + job.RequiredSkill + "</div>";
                    htmlText += "<div class='card-block'><b>Location:</b> " + job.Location + "</div>";
                    htmlText += "<div class='card-block'><b>Number of working days:</b> " + job.NumberOfDays + "</div>";
                    htmlText += "<div class='card-block'><b>Start date:</b> " + job.StartDate + "</div>";
                    htmlText += "<div class='card-block'><b>Daily starting time:</b> " + job.StartTime + "</div>";
                    htmlText += "<div class='card-block'><b>Daily knockoff time:</b> " + job.EndTime + "</div>";
                    htmlText += "<div class='card-block'><b>This job pays:</b> R" + job.ToBePaid + " after competion</div>";
                    htmlText += "<div class='card-block'><b>Apply before:</b> " + job.DueDate + "</div>";
                  
                    if (((string)Session["UserType"]).Equals("JobSeeker"))
                    {
                        string s = string.Format("<a class='btn btn-primary' style='border-radius:initial' href='ConfirmJobApplication.aspx?JobID={0}'>Apply</a></br>", job.JobID);
                        htmlText += "<div class='card-block'>" + s +"</div>";
                    }
                    if (((string)Session["UserType"]).Equals("Admin"))
                    {
                        string s = string.Format("<a class='btn btn-danger' style='border-radius:initial' href='DeleteJob.aspx?JobID={0}'>Delete</a></br>", job.JobID);
                        htmlText += "<div class='card-block'>" + s + "</div>";
                    }
                    htmlText += "</div>";
                }
                htmlText += "</div>";
                JobDetails.InnerHtml = htmlText;
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}