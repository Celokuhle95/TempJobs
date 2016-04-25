using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            int EmployerID = (int)Session["id"];
            localhost.PostJob(name, description, duration_Hours, true, location, reward, true, EmployerID, true);
            //display some message to let employer know that posting was successdful
            Response.Redirect("Homepage.aspx");
        }
    }
}