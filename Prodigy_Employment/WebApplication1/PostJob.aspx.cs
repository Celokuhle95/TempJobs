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
    public partial class PostJob : System.Web.UI.Page
    {
        public localhost.Service1 localhost;
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost = new localhost.Service1();

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;
            int duration_Hours = Convert.ToInt32(txtDuration.Text);
            string location = txtLocation.Text;
            double reward = Convert.ToDouble(txtReward.Text);
            int EmployerID = (int)Session["EmployerID"];

            byte[] fileBytes = ProfileImageUpload.FileBytes;
            System.Drawing.Image profileImage = getImageFromByteArray(fileBytes);
            string profImage_string = ImageToBase64String(profileImage);

            localhost.PostJob(name, description, duration_Hours, true, location, reward, true, profImage_string,  EmployerID, true);
            //display some message to let employer know that posting was successdful
            Response.Redirect("Homepage.aspx");
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