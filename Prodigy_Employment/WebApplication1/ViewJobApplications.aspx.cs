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
            int EmployerID = (int)Session["id"];
            localhost.Service1 localhost = new localhost.Service1();

            string htmlText = "";
            htmlText += "<h2>People who applied for job</h2> <br/>";
            htmlText += "<hr id='Hr1' style='color: #808080, #C2C2C2'/>";

            foreach (var applicant in localhost.getApplications(EmployerID, true)) 
            {
               
                htmlText += "<div class='row'>";
                string base64ImageRepresentation = applicant.ProfileImage_String;
                htmlText += "<img width='100%' height='100%'alt='image not available' max-height='300px' class='img-circle' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
                htmlText += "</div>";
                htmlText += "<div class='row'>";
                htmlText += "<h3>" + applicant.firstName + " " + applicant.lastName + "</h3>";
                htmlText += "</div>";
            }
            Applications.InnerHtml = htmlText;
        }
    }
}