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
                string htmlText = "<div class='page-header'><h1>Available jobs.</h1></div>";
                localhost.Service1 localhost = new localhost.Service1();
                htmlText += "<div class='card-columns'>";
                foreach (var job in localhost.AllJobs())
                {                  
                    htmlText += "<div class='card'>";
                    htmlText += "<h3 card='card-header'>" + job.Name + "</h3>";
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
                    
                    if (((string)Session["UserType"]).Equals("JobSeeker"))
                    {
                        string s = string.Format("<a class='btn btn-primary' style='border-radius:initial' href='ConfirmJobApplication.aspx?JobID={0}'>Apply</a></br>", job.JobID);
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'>" + s + "</li>";
                    }
                    if (((string)Session["UserType"]).Equals("Admin"))
                    {
                        string s = string.Format("<a class='btn btn-danger' style='border-radius:initial' href='DeleteJob.aspx?JobID={0}'>Delete</a></br>", job.JobID);
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'>" + s + "</li>";
                    }
                    htmlText += " </ul>";
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