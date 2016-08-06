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
            if(Session["UserID"] != null && Session["UserType"] != null)
            {
                if(((string)Session["UserType"]).Equals("Employer"))
                {
                    int EmployerID = (int)Session["UserID"];
                    localhost1.Service1 localhost = new localhost1.Service1();

                    string htmlText = "";
                    htmlText += "<h2>Look  who applied for job.</h2> <br/>";
                    htmlText += "<hr id='Hr1' style='color: #808080, #C2C2C2'/>";

                    foreach (var applicant in localhost.getApplicants(EmployerID, true))
                    {

                        htmlText += "<div class='row'>";
                        string base64ImageRepresentation = applicant.ProfileImage_String;
                        htmlText += "<img width='100%' height='100%'alt='image not available' max-height='300px' class='img-circle' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
                        htmlText += "</div>";
                        htmlText += "<div class='row'>";
                        htmlText += "<h3>" + applicant.FirstName + " " + applicant.LastName + "</h3>";
                        string s = string.Format(" < a href = 'JobSeekerProfile.aspx?JobSeekerID={0}' > View full profile</ a ></ br > ", applicant.JobSeekerID);
                        htmlText += s;
                        string employ = string.Format(" < a href = 'EmployJobSeeker.aspx?JobSeekerID={0}' > here. </a></br> ", applicant.JobSeekerID);
                        htmlText += "If you would like to employ job seeker click " + employ;
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