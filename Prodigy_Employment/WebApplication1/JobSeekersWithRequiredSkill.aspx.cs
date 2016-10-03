using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class JobSeekersWithRequiredSkill : System.Web.UI.Page
    {
        string htmlText = "";
        string skill = "";
        int JobID = 0;
        localhost.Service1 lc = new localhost.Service1();
        protected void Page_Load(object sender, EventArgs e)
        {
            skill = (string)Session["RequiredSkill"];
            JobID = Convert.ToInt32(Request.QueryString["JobID"]);
            string htmlText = "";
            htmlText += "<div class='page-header'>";
            htmlText += "<h1>Jobseekers</h1>";
            htmlText += "</div>";
            htmlText += "<div class='card-deck-wrapper'>";
            htmlText += "<div class='card-columns'>";

            foreach (var u in lc.SkilledJobSeeker(skill))
            {
                htmlText += "<div class='card'>";
                string base64ImageRepresentation = u.ProfileImage_String;
                htmlText += "<img class='card-img-top img-fluid img-responsive' style='max-height:350px; max-width:100%'  src='data:image/jpeg;base64," + base64ImageRepresentation + "' />";
                htmlText += "<div class='card-block'>";
                string s = string.Format("<h4><a href='JobSeekerProfile.aspx?JobID={0}&JobSeekerID={1}'>" + u.FirstName + "</a>", JobID, u.JobSeekerID);
                htmlText += s + " " + u.LastName + "</h4>";
                htmlText += "<p class='card-text'><small class='text-muted'>Click to view full profile</small></p>";
                htmlText += "</div>";
                htmlText += "</div>";
            }
            htmlText += "</div>";
            htmlText += "</div></br>";                    
            ViewJobs.InnerHtml = htmlText;
        }
    }
}