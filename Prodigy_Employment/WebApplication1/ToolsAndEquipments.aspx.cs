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
        private localhost.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                lc = new localhost.Service1();
                if (Session["UserID"] != null && Session["UserType"] != null)
                {
                    if(((string)Session["UserType"]).Equals("JobSeeker"))
                    {
                        JobSeekerID = (int)Session["UserID"];
                        int count = 0;
                        foreach (var te in lc.GetToolsAndEquipments(JobSeekerID, true))
                        {
                            if (te != null)
                            {
                                //update images and Name to the  correct text boxes 
                                if (count.Equals(0))
                                {
                                    if (te != null)
                                    {
                                        Image1ID.Src = "data:image/jpeg;base64,"+ te.Image;
                                        txtNameOrDescription1.Text = te.Name;
                                    }
                                }
                                else if (count.Equals(1))
                                {
                                    if (te != null)
                                    {
                                        Image2ID.Src = "data:image/jpeg;base64," + te.Image;
                                        txtNameOrDescription2.Text = te.Name;
                                    }
                                }
                                else if (count.Equals(2))
                                {
                                    if (te != null)
                                    {
                                        Image3ID.Src = "data:image/jpeg;base64," + te.Image;
                                        txtNameOrDescription3.Text = te.Name;
                                    }
                                }
                                else if (count.Equals(3))
                                {
                                    if (te != null)
                                    {
                                        Image4ID.Src = "data:image/jpeg;base64," + te.Image;
                                        txtNameOrDescription4.Text = te.Name;
                                    }
                                }
                                else if (count.Equals(4))
                                {
                                    if (te != null)
                                    {
                                        Image5ID.Src = "data:image/jpeg;base64," + te.Image;
                                        txtNameOrDescription5.Text = te.Name;
                                    }
                                }
                            }
                            count++;
                        }
                    }
                    else
                    {
                        Response.Redirect("LoginPage.aspx");
                    }                   
                }
                else
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Research post pack
            byte[] image1Bytes = ToolImage1.FileBytes;
            lc = new localhost.Service1(); 
            if (image1Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment1 = txtNameOrDescription1.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment1, toolImage, JobSeekerID, true);
                //Show success message
                DisplaySuccessMessage();
            }
            byte[] image2Bytes = ToolImage2.FileBytes;
            if (image2Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment2 = txtNameOrDescription2.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment2, toolImage, JobSeekerID, true);
                DisplaySuccessMessage();
            }
            byte[] image3Bytes = ToolImage3.FileBytes;
            if (image3Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment3 = txtNameOrDescription3.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment3, toolImage, JobSeekerID, true);
                DisplaySuccessMessage();
            }
            byte[] image4Bytes = ToolImage4.FileBytes;
            if (image4Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment4 = txtNameOrDescription4.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment4, toolImage, JobSeekerID, true);
                DisplaySuccessMessage();
            }
            byte[] image5Bytes = ToolImage5.FileBytes;
            if (image5Bytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(image1Bytes);
                string toolImage = ImageToBase64String(toolImageObject);

                string toolAndEquipment5 = txtNameOrDescription5.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment5, toolImage, JobSeekerID, true);
                DisplaySuccessMessage();
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

        protected void btnReload1_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = ToolImage1.FileBytes;
            if (imageBytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(imageBytes);
                string toolImage = ImageToBase64String(toolImageObject);
                Image1ID.Src = "data:image/jpeg;base64," + toolImage;
            }
        }

        protected void btnReload2_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = ToolImage2.FileBytes;
            if (imageBytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(imageBytes);
                string toolImage = ImageToBase64String(toolImageObject);
                Image2ID.Src = "data:image/jpeg;base64," + toolImage;
            }
        }

        protected void btnReload3_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = ToolImage3.FileBytes;
            if (imageBytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(imageBytes);
                string toolImage = ImageToBase64String(toolImageObject);
                Image3ID.Src = "data:image/jpeg;base64," + toolImage;
            }
        }
        protected void btnReload4_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = ToolImage4.FileBytes;
            if (imageBytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(imageBytes);
                string toolImage = ImageToBase64String(toolImageObject);
                Image4ID.Src = "data:image/jpeg;base64," + toolImage;
            }
        }
        protected void btnReload5_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = ToolImage5.FileBytes;
            if (imageBytes != null)
            {
                System.Drawing.Image toolImageObject = getImageFromByteArray(imageBytes);
                string toolImage = ImageToBase64String(toolImageObject);
                Image5ID.Src = "data:image/jpeg;base64," + toolImage;
            }
        }

        public void DisplaySuccessMessage()
        {
            if (Session["ScreenNotification"] == null)
            {
                Session.Add("ScreenNotification", "TurnON");
                Session.Add("ScreenNotificationMessage", "< p >Changes to your skills were successfully saved.</ p >");
            }
        }
    }
}