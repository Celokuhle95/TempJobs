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
    public partial class Registration : System.Web.UI.Page
    {
        public localhost.Service1 cl =new localhost.Service1(); //references the local host
        private string image = "none";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {         
                image = (string)Session["Image"];
                if (image == null)
                {
                    image = "none";
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //getting the values from the textboxes
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string emailAddress = txtEmail.Text;
            string password = txtPassword.Text;
            string cellphoneNumbers = txtCellphone.Text;
            string altanativeContactNumber = txtAltContactNum.Text;
            string residentialAddress = txtResAddress.Text;

            int userLevel = System.Convert.ToInt32(drpUsertype.SelectedValue);

            //byte[] fileBytes = ProfileImageUpload.FileBytes;
            //System.Drawing.Image profileImage = getImageFromByteArray(fileBytes);

            //string profImage_string = ImageToBase64String(profileImage);

            if (password.Length < 6) //ensure the password strength is atleast 6 characters
            {
                lblError.Text = "Make sure your password is 6 characters or more";
                lblError.Visible = true;
                return;
            }

            if (password == txtConfirmPassword.Text)
            {
                if (emailAddress == " ")
                {
                    lblError.Text = "Make sure your e-mail address is not empty";
                    lblError.Visible = true;
                    return;
                }
                else
                {
                    if (userLevel.Equals(1))
                    {
                        if(image.Equals("none"))
                        {
                            lblError.Text = "Please ensure that you have selected a profile image";
                            lblError.Visible = true;
                            return;
                        }
                        cl.RegisterEmployer(firstName, lastName, emailAddress, Secrecy.HashPassword(password), cellphoneNumbers, altanativeContactNumber, residentialAddress, image);
                        Session["Image"] = null; // set session to null
                        Response.Redirect("LoginPage.aspx");
                    }
                    else if (userLevel.Equals(2))
                    {
                        if (image.Equals("none"))
                        {
                            lblError.Text = "Please ensure that you have selected a profile image";
                            lblError.Visible = true;
                            return;
                        }
                        cl.RegisterJobSeeker(firstName, lastName, emailAddress, Secrecy.HashPassword(password), cellphoneNumbers, altanativeContactNumber, residentialAddress, image);
                        Session["Image"] = null; // set session to null
                        Response.Redirect("LoginPage.aspx");
                    }
                    else
                    {
                        lblError.Text = "Make sure you select whether to register as an employer or a job seeker";
                        lblError.Visible = true;
                        return;
                    }
                }
            }
            else
            {
                lblError.Text = "Make sure your password and confirm password match";
                lblError.Visible = true;
                return;
            }
           

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

        protected void drpUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] imageBytes = ProfileImageUpload.FileBytes;

            if (imageBytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(imageBytes);
                string toolImage = ImageToBase64String(toolImageObject);
               // Image5ID.Src = "data:image/jpeg;base64," + toolImage;
                Session.Add("Image", toolImage);
            }
        }
    }
}