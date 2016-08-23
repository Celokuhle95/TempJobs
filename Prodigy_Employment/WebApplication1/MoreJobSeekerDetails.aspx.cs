using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //    if (!string.IsNullOrWhiteSpace(Request.QueryString["UserID"]))
        //    {
        //        int userID = Convert.ToInt32(Request.QueryString["UserID"]);
        //        localhost1.Service1 lc = new localhost1.Service1();
                
        //        string htmlText = "";
        //        foreach (var user in lc.AllJobseekers())
        //        {
        //            if (user.JobSeekerID == userID)
        //            {
        //                htmlText += "<h3>Job seeker details.</h3><br/>";
        //                htmlText += "<div class='row'>";
        //                htmlText += "<div class ='col-md-3'>";

        //                string base64ImageRepresentation = user.ProfileImage_String;
        //                htmlText += "<img width='100%' height='250px'class='img-thumbnail' alt='image not available' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
        //                htmlText += "</div>";
        //                htmlText += "<div class='col-md-6'>";
        //                htmlText += "<table class='table'>";
        //                htmlText += "<tbody>";
        //                htmlText += "<tr><td><b>First name:</b></td><td>" + user.FirstName + "</td></tr>";
        //                htmlText += "<tr><td><b>Last name:</b></td><td>" + user.LastName + "</td></tr>";
        //                htmlText += "<tr><td><b>Residential address:</b></td><td>" + user.ResidentialAddress + "</td></tr>";
        //                htmlText += "<tr><td><b>Skills:</b></td><td>plumber, grass cutting, watering the garden, painter</td></tr>";
        //                htmlText += "<tr><td><b>Employment profile:</b></td><td><a href='EmploymentProfilePage.aspx.?UserID=" + user.JobSeekerID + "'><b>View</b></a>" + "</td></tr>";
        //                htmlText += "<tr><td><b>Have a Job to be done?:</b></td><td><a href='EmploymentProfilePage.aspx'><b>Employ</b></a></td></tr>";
        //                htmlText += "</tbody>";
        //                htmlText += "</table>";
        //                htmlText += "</div>";
        //                htmlText += "</div>";
        //            }
        //            UserDetails.InnerHtml = htmlText;
        //        }
        //    }          
        }
    }
}