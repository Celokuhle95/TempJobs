using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prodigy_Employment.Sites.User
{
    public partial class Registration : System.Web.UI.Page
    {
        public localhost.Service1 cl;
        protected void Page_Load(object sender, EventArgs e)
        {
            cl = new localhost.Service1();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            cl.insert(txtUsername.Text ,txtFirstName.Text, txtLastName.Text, txtAdress.Text, txtEmail.Text, txtPhoneNumber.Text, txtPhoneNumberAltanative.Text, drpAuthintication.SelectedValue, txtpassword.Text);
        }
    }
}