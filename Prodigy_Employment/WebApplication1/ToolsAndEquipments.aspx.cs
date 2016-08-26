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
        private string image1 = "none";
        private string image2 = "none";
        private string image3 = "none";
        private string image4 = "none";
        private string image5 = "none";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {        
               JobSeekerID = (int)Session["UserID"];
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
            else
            {
                JobSeekerID = (int)Session["UserID"];
                image1 = (string)Session["Image1"];
                if(image1 == null)
                {
                    image1 = "none";
                }

                image2 = (string)Session["Image2"];
                if (image2 == null)
                {
                    image2 = "none";
                }

                image3 = (string)Session["Image3"];
                if (image3 == null)
                {
                    image3 = "none";
                }

                image4 = (string)Session["Image4"];
                if(image4 == null)
                {
                    image4 = "none";
                }

                image5 = (string)Session["Image5"];
                if (image5 == null)
                {
                    image5 = "none";
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {     
            lc = new localhost.Service1(); 
            if (!image1.Equals("none"))
            {              
                string toolAndEquipment1 = txtNameOrDescription1.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment1, image1, JobSeekerID, true);
                //Show success message
                DisplaySuccessMessage();
            }
            
            if (!image2.Equals("none"))
            {
                string toolAndEquipment2 = txtNameOrDescription2.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment2, image2, JobSeekerID, true);
                DisplaySuccessMessage();
            }
            
            if (!image3.Equals("none"))
            {            
                string toolAndEquipment3 = txtNameOrDescription3.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment3, image3, JobSeekerID, true);
                DisplaySuccessMessage();
            }
           
            if (!image4.Equals("none"))
            {
                string toolAndEquipment4 = txtNameOrDescription4.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment4, image4, JobSeekerID, true);
                DisplaySuccessMessage();
            }
          
            if (!image5.Equals("none"))
            {          
                string toolAndEquipment5 = txtNameOrDescription5.Text;
                lc.AddNewToolOrEquipment(toolAndEquipment5, image5, JobSeekerID, true);
                DisplaySuccessMessage();
            }
            Session["Image1"] = null; // set session to null
            Session["Image2"] = null;
            Session["Image3"] = null;
            Session["Image4"] = null;
            Session["Image5"] = null;
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
                Session.Add("Image1", toolImage); //store information into memory for later access in case of a post back
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
                Session.Add("Image2", toolImage);
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
                Session.Add("Image3", toolImage);
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
                Session.Add("Image4", toolImage);
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
                Session.Add("Image5", toolImage);
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