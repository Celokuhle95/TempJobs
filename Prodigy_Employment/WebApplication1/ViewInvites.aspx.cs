﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewInvites : System.Web.UI.Page
    {      
        protected void Page_Load(object sender, EventArgs e)
        {
            //localhost.Service1 localhost;
            //if (Session["UserID"] != null && Session["UserType"] != null)
            //{
            //    if (((string)Session["UserType"]).Equals("JobSeeker"))
            //    {
            //        localhost = new localhost1.Service1();
            //        int JobSeekerID = (int)Session["UserID"];

            //        string htmlText = "<h3 style='text-align'>Job invites.</h3><br/>";
            //        htmlText += "<p>Job invites are a way employers try to get you to apply for their job that they have posted. Invites means the employer, after viewing your profile, felt that you have the right skills and equipment to complete this job. So if you choose to apply for this job your chances of getting employment are really high.</p><br/>";
            //        foreach(var EmployerID in localhost.Invitation_Employers(JobSeekerID, true))
            //        {
            //            foreach(var job in localhost.EmployerSpecificJobs(EmployerID, true))
            //            {
            //                htmlText += "<div class='row' style='border:groove'>";
            //                htmlText += "<h2>" + job.Name + "</h2>";
            //                htmlText += "<hr style='color:goldenrod'/>";
            //                htmlText += "<u>Short Job Description</u>: " + job.Description + "<br/>";
            //                htmlText += "<u>Location </u>:" + job.Location + "<br/>";
            //                htmlText += "<u>Job Start Day</u>:" + job.StartDate + "<br/>";
            //                htmlText += "<u>Daily Starting Time</u>: " + job.StartTime + " <br/>";
            //                htmlText += "<u>Daily Knockoff Time</u>: " + job.EndTime + " <br/>";
            //                htmlText += "<u>Due date(Apply before this day): </u>:" + job.DueDate + "<br/>";
            //                htmlText += "<u>Pay(After the whole job is complete)</u>:<b> R" + job.ToBePaid + "</b><br/>";
            //                string s = string.Format("<a class='btn btn-success' href='ConfirmJobApplication.aspx?JobID={0}'>Apply for job</a></br>", job.JobID);
            //                htmlText += s + "<br/></div> <br/><br/>";
            //            }
            //        }
            //        Invites.InnerHtml = htmlText; 
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