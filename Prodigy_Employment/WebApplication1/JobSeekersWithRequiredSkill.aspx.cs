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
        localhost.Service1 lc = new localhost.Service1();
        protected void Page_Load(object sender, EventArgs e)
        {
            skill = (string)Session["RequiredSkill"];
            htmlText += "<div class='row' style= padding-top:1%'> ";
            foreach (var u in lc.SkilledJobSeeker(skill))
            {
                htmlText += "<div class ='col-md-6' style='border:groove'> ";
            
                string base64ImageRepresentation = u.ProfileImage_String;
                htmlText += "<br/><img width='500px' height='350px'alt='image not available' max-height='350px' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
                
                string s = string.Format("<a href='JobSeekerProfile.aspx?JobSeekerID={0}'>" + u.FirstName + "</a></br>", u.JobSeekerID);
                htmlText += "<br/><br/><p><b>first Name : </b><u>" + s + "</u></p>";
                htmlText += "<p><b>Last Lastname: </b>" + u.LastName + "</p>";
                htmlText += "</div>";
            }
            ViewJobs.InnerHtml = htmlText;
        }
    }
}