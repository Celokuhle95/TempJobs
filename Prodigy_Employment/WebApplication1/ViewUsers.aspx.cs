using System;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication1
{
    public partial class ViewUsers : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.Service1 lc;           
            if(Session["UserID"] != null)
            {
                lc = new localhost.Service1();

                string htmlText = "";
                htmlText += "<div class='page-header'>";
                    htmlText += "<h1>Jobseekers</h1>";
                htmlText += "</div>";
                htmlText += "<div class='card-deck-wrapper'>";
                htmlText += "<div class='card-deck'>";

                foreach (var u in lc.AllJobseekers())
                {
                    htmlText += "<div class='card'>";
                    string base64ImageRepresentation = u.ProfileImage_String;                  
                    htmlText += "<img class='card-img-top img-circle img-responsive' style='height:318px; width:270px'  src='data:image/jpeg;base64," + base64ImageRepresentation + "' />";                  
                    htmlText += "<div class='card-blog'>";               
                    string s = string.Format("<h4><a href='JobSeekerProfile.aspx?JobSeekerID={0}'>" + u.FirstName + "</a>", u.JobSeekerID);            
                    htmlText +=  s + " " + u.LastName + "</h4>";
                    htmlText += "<p class='card-text'><small class='text-muted'>Click to view full profile</small></p>";
                    htmlText += "</div>";
                    htmlText += "</div>";
                }
                htmlText += "</div>";
                htmlText += "</div></br>";
                DisplayUsers.InnerHtml = htmlText;
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }    
        }

        public System.Drawing.Image Base64StringToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }      
    }
}