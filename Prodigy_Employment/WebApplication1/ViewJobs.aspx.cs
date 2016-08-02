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
            string htmlText = "<h3 style='text-align'>Available jobs.</h3>";
            localhost1.Service1 localhost = new localhost1.Service1();
            foreach(var job in localhost.AllJobs())
            {
                htmlText += "<div class='row' style='border:groove'>";
                htmlText += "<h2>"+job.Name+"</h2>";
                htmlText += "<hr style='color:goldenrod'/>";
                htmlText += "<u>Description</u>: " + job.Description + "<br/>";
                htmlText += "<u>Location </u>:" + job.Location + "<br/>";
                htmlText += "<u>Daily Starting Time</u>: " + job.StartTime + " <br/>";
                htmlText += "<u>Daily Knockoff Time</u>: " + job.EndTime + " <br/>";
                htmlText += "<u>Pay(After the whole job is complete)</u>:<b> R" + job.ToBePaid + "</b><br/>";
                string s = string.Format("<a class='btn btn-success' href='ConfirmJobApplication.aspx?JobID={0}'>Apply for job</a></br>", job.JobID);
                htmlText += s + "<br/></div> <br/>";
            }
            JobDetails.InnerHtml = htmlText;
        }
    }
}