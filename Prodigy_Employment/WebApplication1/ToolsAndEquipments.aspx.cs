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
    public partial class WebForm2 : System.Web.UI.Page //RESEARCH HOW TO DISPLAY IMAGE STRATIGHT AWAY FROM A FILE UPLOAD
    {
        private int JobSeekerID;
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost1.Service1 localhost = new localhost1.Service1();
            if (false/*Session["UserID"] != null && ((string)Session["UserType"]).Equals("JobSeekerID")*/)
            {
                JobSeekerID = (int)Session["UserID"];
                foreach (var te in localhost.GetToolsAndEquipments(JobSeekerID, true))
                {
                    if(te != null)
                    {
                        //update images and Name to the  correct text boxes using the methodology i thought of, which generationg the name(wont work i think), or just use counter
                    }
                }
            }
            //else
            //{
            //    Response.Redirect("LoginPage.aspx");
            //}
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Research post pack
            byte[] image1Bytes = ToolImage1.FileBytes;
            localhost1.Service1 lc = new localhost1.Service1(); 
            if (image1Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment1 = txtNameOrDescription1.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment1, toolImage, JobSeekerID, true);
            }
            byte[] image2Bytes = ToolImage2.FileBytes;
            if (image2Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment2 = txtNameOrDescription2.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment2, toolImage, JobSeekerID, true);
           
 }
            byte[] image3Bytes = ToolImage3.FileBytes;
            if (image3Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment3 = txtNameOrDescription3.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment3, toolImage, JobSeekerID, true);
            }
            byte[] image4Bytes = ToolImage4.FileBytes;
            if (image4Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment4 = txtNameOrDescription4.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment4, toolImage, JobSeekerID, true);
            }
            byte[] image5Bytes = ToolImage5.FileBytes;
            if (image5Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment5 = txtNameOrDescription5.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment5, toolImage, JobSeekerID, true);
            }
            Response.Redirect("JobSeekerProfile.aspx");
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