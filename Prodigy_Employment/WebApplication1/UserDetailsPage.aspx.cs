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
            if (!string.IsNullOrWhiteSpace(Request.QueryString["UserID"]))
            {
                int userID = Convert.ToInt32(Request.QueryString["UserID"]);
                localhost.Service1 lc = new localhost.Service1();

                string htmlText = "";
                foreach (var user in lc.ReadEmployees())
                {
                    if (user.Id == userID)
                    {
                        htmlText += "<div class='row'>";
                        htmlText += "<div class ='col-md-3'>";
                        htmlText += "<img width='100%' height='150px' class='img-thumbnail' src='images/cuttinggrass.jpg'>"; //must change image source to the real profile image
                        htmlText += "</div>";
                        htmlText += "<div class='col-md-6'>";
                        htmlText += "<table class='table'>";
                        htmlText += "<tbody>";
                        htmlText += "<tr><td>" + user.firstName + "</td><td>" + user.lastName + "</td></tr>";
                        htmlText += "<tr><td>Email address:</td><td>" + user.Email + "</td></tr>";
                        htmlText += "<tr><td>Residential address:</td><td>" + user.address + "</td></tr>";
                        htmlText += "<tr><td>Contact number:</td><td>" + user.contactNumber + "</td></tr>";
                        htmlText += "<tr><td>Alternative contact number:</td><td>" + user.alternativeNumber + "</td></tr>";
                        htmlText += "<tr><td>Skills:</td><td>plumber, grass cutting, watering the garden, painter</td></tr>";
                        htmlText += "<tr><td>View Employment profile:</td><td>" + "<a class='text-success' href='EmploymentProfilePage.aspx.?UserID=" + user.Id + "'>View</a>" + "</td></tr>";
                        htmlText += "<tr><td><a class='text-success' href='EmploymentProfilePage.aspx'>Employ</a></td></tr>";
                        htmlText += "</tbody>";
                        htmlText += "</table>";
                        htmlText += "</div>";
                        htmlText += "</div>";
                    }
                    UserDetails.InnerHtml = htmlText;
                }
            }          
        }
    }
}