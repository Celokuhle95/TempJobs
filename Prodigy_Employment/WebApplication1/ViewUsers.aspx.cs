using System;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class ViewUsers : System.Web.UI.Page
    {
        public localhost.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {           
            lc = new localhost.Service1();
               
            String htmlText = "";
            foreach (var u in lc.ReadEmployees())
            {
                htmlText += "<div class='row' style='border: groove; border-color:beige'>";
                htmlText += "<div class ='col-md-2'>";
                System.Drawing.Image img = System.Drawing.Image.FromFile(Server.MapPath("images/washing.jpg"));
                //  img = System.Drawing.Image.FromStream(new MemoryStream(Convert.FromBase64String(u.ProfileImage))); 
                htmlText += "<img src='" + "images/washing.jpg" + "' alt='no prof image' width='160px' height='100px'/>";
                htmlText += "</div>";
                htmlText += "<div class='col-md-3'>";
                string s = string.Format("<a href='UserDetailsPage.aspx?UserID={0}'>"+u.firstName+"</a></br>", u.Id);
                htmlText += s;
                htmlText += "Last name:" + u.lastName + "</br>";
                htmlText += "Email:" + u.Email + "</br>";
                htmlText += "Contact Number:" + u.contactNumber + "</br>";
                htmlText += "</div>";
                htmlText += "</div></br>";
            }
            DisplayUsers.InnerHtml = htmlText;         
        }
    }
}