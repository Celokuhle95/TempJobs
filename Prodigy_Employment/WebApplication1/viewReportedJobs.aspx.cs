using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class viewReportedJobs : System.Web.UI.Page
    {
         localhost1.Service1 localhost;
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost = new localhost1.Service1();
            if (Session["UserID"] != null)
            {
                localhost = new localhost1.Service1();
                DefaultView();
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
        protected void sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = ddlSort.SelectedItem.Value;
            if (selected.Equals("All"))
            {
                DefaultView();
            }
            else if (selected.Equals("Employer"))
            {
                OrderByemployer();
            }
            else if (selected.Equals("MostReported"))
            {
                OrderByJob();
            }
            else if (selected.Equals("Type"))
            {
                OrderJobType();
            }
        }


        private void OrderByemployer()
        {
            foreach (var job in localhost.OrderByEmployer())
            {
                displayJobs(job);
            }
        }

        private void OrderByJob()
        {
            foreach (var job in localhost.OrderByJob())
            {
                displayJobs(job);
            }
        }

        private void OrderJobType()
        {
            foreach (var job in localhost.OrderByJobType())
            {
                displayJobs(job);
            }
        }

        private void DefaultView()
        {
            foreach (var job in localhost.AllJobs())
            {
                displayJobs(job);
            }
        }

        private void displayJobs(localhost1.Job job)
        {
            string htmlText = "<h3 style='text-align'>Reported jobs.</h3>";
            foreach (var reported in localhost.AllReportJobs())
            {
                if(reported.EmployerID.Equals(job.EmployerID))
                {
                    htmlText += "<div class='row' style='border:groove'>";
                    htmlText += "<h2>" + job.Name + "</h2>";
                    htmlText += "<hr style='color:goldenrod'/>";
                    htmlText += "<u>Short Job Description</u>: " + job.Description + "<br/>";
                    htmlText += "<u>Location </u>:" + job.Location + "<br/>";
                    htmlText += "<u>Job Start Day</u>:" + job.StartDate + "<br/>";
                    htmlText += "<u>Daily Starting Time</u>: " + job.StartTime + " <br/>";
                    htmlText += "<u>Daily Knockoff Time</u>: " + job.EndTime + " <br/>";
                    htmlText += "<u>Due date(Apply before this day): </u>:" + job.DueDate + "<br/>";
                    htmlText += "<u>Pay(After the whole job is complete)</u>:<b> R" + job.ToBePaid + "</b><br/>";
                    int numberOfReported = 0;
                    foreach (var rp in localhost.AllJobs())
                    {
                        if (rp.JobID == reported.JobID)
                        {
                            numberOfReported++;
                        }
                    }
                    htmlText += "<u>Number Of reports</u>:<b> R" + numberOfReported + "</b><br/>";
                    string s = string.Format("<a class='btn btn-success' href='RemoveJob.aspx?JobID={0}'>Remove Job</a></br>", job.JobID);
                   /* string j = string.Format("<a style='Colour:Green' href='Profile.aspx?JobID{0}'>View emoployer Profile</a></br>", job.EmployerID);
                    htmlText += j;*/
                    htmlText += s + "<br/></div> <br/>";
                }
            }  
                reportedJobs.InnerHtml = htmlText;
        }
    
    }
}