using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace WebApplication1
{
    public partial class Profile : System.Web.UI.Page
    {
        string profileImge;
        
        string htmlText = "";
        localhost.Service1 lc = new localhost.Service1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id"] != null)
                {
                    foreach (var history in lc.ReadEmployees())
                    {
                        if (history.Id == Convert.ToInt32(Session["id"]))
                        {
                            if (history.authinticationLevel.Equals(1))
                                btnmore.Visible = false;
                            //if (history.Gender == null)
                            //    drpGender.SelectedValue = "2";
                            //else
                            //{
                            //    if (history.Gender.Equals("F"))
                            //        drpGender.SelectedValue = "1";
                            //    if (history.Gender.Equals("M"))
                            //        drpGender.SelectedValue = "0";
                            //}
                            txtFirstName.Text = history.firstName;
                            txtLastName.Text = history.lastName;
                            txtResAddress.Text = history.address;
                            txtCellphone.Text = history.contactNumber;
                           // txtAge.Text = history.Age.ToString();
                            txtTelephone.Text = history.alternativeNumber;
                            txtUsername.Text = history.Username;
                            txtEmail.Text = history.Email;
                            profileImge = history.ProfileImage_String;

                           
                            htmlText += "<div class='row' style= padding-top:1%'> ";
                            htmlText += "<div class ='col-md-3' style='background-color:orange'> ";

                           
                           
                                string base64ImageRepresentation = history.ProfileImage_String;
                                htmlText += "<img width='100%' height='250px'class='img-thumbnail' alt='image not available' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
                           
                            disImage.InnerHtml = htmlText;
                        }
                    }
                }else
                    Response.Redirect("LoginPage.aspx");
            }
                   
       }

        protected void btnmore_Click(object sender, EventArgs e)
        {
            Response.Redirect("profileEmployment.aspx");
        }

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {

            byte[] fileBytes = ProfileImageUpload.FileBytes;
            System.Drawing.Image profileImage = getImageFromByteArray(fileBytes);
            string profImage_string = ImageToBase64String(profileImage);
            string Gender;
            if (drpGender.SelectedValue.Equals("0"))
                Gender = "M";
            if (drpGender.SelectedValue.Equals("2"))
                Gender = "";
            if (drpGender.SelectedValue.Equals("1"))
                Gender = "F";
            else
                Gender = "";
            if (Session["id"] != null)
            {
                if (profImage_string == "")
                    lc.RegistrationDatabaseUpdate(Convert.ToInt32(Session["id"]), true, txtUsername.Text, txtFirstName.Text, txtLastName.Text, txtResAddress.Text, txtEmail.Text, txtCellphone.Text, txtTelephone.Text, profileImge, Convert.ToInt32(txtAge.Text), true, Gender);
                else
                lc.RegistrationDatabaseUpdate(Convert.ToInt32(Session["id"]), true, txtUsername.Text, txtFirstName.Text, txtLastName.Text, txtResAddress.Text, txtEmail.Text, txtCellphone.Text, txtTelephone.Text, profImage_string,Convert.ToInt32(txtAge.Text),true,Gender);
                Response.Redirect("profileEmployment.aspx");
            }
            else
                Response.Redirect("LoginPage.aspx");
          
        }


        public System.Drawing.Image getImageFromByteArray(byte[] fileBytes)
        {
            using (var ms = new MemoryStream(fileBytes))
            {
                System.Drawing.Image image = new Bitmap(ms);
                return image;
            }
        }

        public string ImageToBase64String(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                Bitmap bm = new Bitmap(image);
                bm.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

    }
}