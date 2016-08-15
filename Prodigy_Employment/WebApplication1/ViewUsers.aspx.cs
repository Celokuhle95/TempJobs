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
        public localhost1.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {           
            if(Session["UserID"] != null)
            {
                lc = new localhost1.Service1();

                string htmlText = "";
                htmlText += "<div class='row' style= padding-top:1%'> ";
                foreach (var u in lc.AllJobseekers())
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

                    string s = string.Format("<a href='JobSeekerProfile.aspx?JobSeekerID={0}'>" + u.FirstName + "</a></br>", u.JobSeekerID);
                    htmlText += "<br/><br/><p><b>first Name : </b><u>" + s + "</u></p>";
                    htmlText += "<p><b>Last Lastname: </b>" + u.LastName + "</p>";
                    htmlText += "</div>";                   
                }
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