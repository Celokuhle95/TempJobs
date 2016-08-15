using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewEmpoyers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost1.Service1 localhost;
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("Admin"))
                {
                    localhost = new localhost1.Service1();
                    string htmlText = "<h2>Rgistered Employers</h2>";
                    htmlText += "<div class='row' style= padding-top:1%'> ";
                    foreach (var u in localhost.AllEmployers())
                    {
                        htmlText += "<div class ='col-md-6' style='border:groove'> ";

                        if (u.ProfileImage_String == null)
                        {
                            string image = "images/image1.jpg";
                            htmlText += "<br/><img src='" + image + "' alt='no prof image' width=60%' height='60%' max-height='300px'/>";
                        }
                        else
                        {
                            string base64ImageRepresentation = u.ProfileImage_String;
                            htmlText += "<br/><img width='60%' height='60%'alt='image not available' max-height='300px' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
                        }
                      
                        htmlText += "<br/><br/><p><b>first Name : </b><u>" + u.FirstName + "</u></p>";
                        htmlText += "<p><b>Last Lastname: </b>" + u.LastName + "</p>";
                        htmlText += "</div>";
                    }
                    htmlText += "</div></br>";
                    DisplayEmployers.InnerHtml = htmlText;
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