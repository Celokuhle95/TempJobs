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
        public localhost.Service1 cl; //references the local host
        
        public bool isUserName; 
        protected void Page_Load(object sender, EventArgs e)
        {
            cl = new localhost.Service1();
            isUserName = false;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text; //getting the values from the textboxes
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtResAddress.Text;
            string Email = txtEmail.Text;
            string cantactNumbers = txtCellphone.Text;
            string altanativeNumber = txtTelephone.Text;
            string password = txtPassword.Text;         
            int authenticationLevel = System.Convert.ToInt32(drpAuthintication.SelectedValue);

            byte[] fileBytes = ProfileImageUpload.FileBytes;
            System.Drawing.Image profileImage = getImageFromByteArray(fileBytes);
            string profImage_string = ImageToBase64String(profileImage);
           
            // string ImagePath = "images/washing.jpg"; //default value to change later into the path of a selected image

            //byte[] imageArray = System.IO.File.ReadAllBytes(@ImagePath); //take a file path and convert image into byte array
            //string ImageStringRepresentation = Convert.ToBase64String(imageArray); //convert byte array into a string representation

            if (password.Length < 6) //ensure the password strength is atleast 6 characters
           {
                lblError.Text = "Password must be atleast 6 characters long";
                lblError.Visible = true;
                return;
           }
            if (authenticationLevel.Equals(1) || authenticationLevel.Equals(2))
            {
                if (password == txtConfirmPassword.Text)
                {
                    if (userName == " ")
                    {
                        lblError.Text = " Please enter a username";
                        lblError.Visible = true;
                        return;
                    }
                    else {
                        cl.RegistrationDatabase(userName, firstName, lastName, address, Email, cantactNumbers, altanativeNumber,Secrecy.HashPassword( password), authenticationLevel, true, profImage_string);
                        Response.Redirect("HomePage.aspx");
                    }
                }
                else
                {
                   lblError.Text=" Passwords are not the same";
                   lblError.Visible = true;
                    return;
                }
            }
            else
            {
                lblError.Text = "select an option on the drpdown menu";
                lblError.Visible = true;
                return;
            }
        }

        protected void TextUsername_TextChanged(object sender, EventArgs e)
        {
            bool d, b;
            string username = txtUsername.Text;
            string message = "Username already taken";
            cl.UserNameCheck(username, out d, out b, out message);
            if (d)
            {
                lblUserError.Text = message; //displaying an message
                lblUserError.Visible = true;
                isUserName = true;
                return;
            }
            else
            {
                isUserName = false;
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