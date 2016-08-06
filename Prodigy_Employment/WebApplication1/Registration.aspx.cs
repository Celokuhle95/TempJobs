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
        public localhost1.Service1 cl; //references the local host
        
        protected void Page_Load(object sender, EventArgs e)
        {
            cl = new localhost1.Service1();
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

            byte[] fileBytes = ProfileImageUpload.FileBytes;
            System.Drawing.Image profileImage = getImageFromByteArray(fileBytes);
            string profImage_string = ImageToBase64String(profileImage);
           
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
                        cl.RegisterEmployer(firstName, lastName, emailAddress, Secrecy.HashPassword(password), cellphoneNumbers, altanativeContactNumber, residentialAddress, profImage_string);
                        Response.Redirect("LoginPage.aspx");
                    }
                    else if (userLevel.Equals(2))
                    {
                        cl.RegisterJobSeeker(firstName, lastName, emailAddress, Secrecy.HashPassword(password), cellphoneNumbers, altanativeContactNumber, residentialAddress, profImage_string);
                        Response.Redirect("Skills.aspx");
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
                lblError.Text="Make sure your password and confirm password match";
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
    }
}