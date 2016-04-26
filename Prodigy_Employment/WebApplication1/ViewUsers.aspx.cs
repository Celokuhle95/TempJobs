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
        public localhost.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {           
            lc = new localhost.Service1();
               
            String htmlText = "";
            foreach (var u in lc.ReadUsers())
            {              
              if (u.authinticationLevel == 2) //job seekers only
              {
        
                    htmlText += "<div class='row' style= padding-top:1%'> ";
                    htmlText += "<div class ='col-md-6' style='background-color:orange'> ";
                   
                    if(u.ProfileImage_String == null)
                    {
                        string image = "images/image1.jpg";
                        htmlText += "<br/><img src='" + image + "' alt='no prof image' width='100%' height='100%' max-height='300px'/>";
                    }
                    else
                    {
                         string base64ImageRepresentation = u.ProfileImage_String;
                         htmlText += "<br/><img width='100%' height='100%'alt='image not available' max-height='300px' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
                    }
                  
                    string s = string.Format("<a href='UserDetailsPage.aspx?UserID={0}'>" + u.firstName + "</a></br>", u.Id);
                    htmlText += "<p><b>first Name : </b><u>"+ s + "</u></p>";
                    htmlText += "<p><b>Last name: </b>" + u.lastName + "</p>";
                    htmlText += "<p><b>Email: </b>" + u.Email + "</p>";
                    htmlText += "<p><b>Contact Number: </b>" + u.contactNumber + "</p>";
                    htmlText += "</div>";
                    htmlText += "</div></br>";
               }
            }
            DisplayUsers.InnerHtml = htmlText;         
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