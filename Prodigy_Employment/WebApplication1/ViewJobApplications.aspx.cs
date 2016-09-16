using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewJobApplications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("Employer"))
                {
                    int EmployerID = (int)Session["UserID"];
                    localhost.Service1 localhost = new localhost.Service1();

                    string htmlText = "";
                    htmlText += "<h2>Look  who applied for job.</h2> <br/>";
                    htmlText += "<hr id='Hr1' style='color: #808080, #C2C2C2'/>";

                    foreach (var applicant in localhost.getApplicants(EmployerID, true))
                    {

                        htmlText += "<div class='card'>";
                        string base64ImageRepresentation = applicant.ProfileImage_String;
                        htmlText += "<img width='400px'class='card-img-top img-responsive img-circle' height='400px'alt='image not available' max-height='300px' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
                        
                        htmlText += "<div class='card-block'>";
                        htmlText += "<h3 class='card-title'>" + applicant.FirstName + " " + applicant.LastName + "</h3>";
                        string s = string.Format("<a href = 'JobSeekerProfile.aspx?JobSeekerID={0}'> View full profile</a><br/> ", applicant.JobSeekerID);
                        htmlText += s;
                        string employ = string.Format("<a class='btn btn-primary' style='border-radius:initial' href = 'EmployJobSeeker.aspx?JobSeekerID={0}'> Employ. </a></br> ", applicant.JobSeekerID);
                        htmlText += "<p class='card-text' >If you would like to employ this Job Seeker click " + employ + "</p>";
                        htmlText += "</div>";
                        htmlText += "</div>";
                    }
                    Applications.InnerHtml = htmlText;
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