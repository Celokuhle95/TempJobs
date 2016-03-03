using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Prodigy_Employment
{
    public partial class DisplayUserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSR.CollectUserDetailsService1Client esc = new DataSR.CollectUserDetailsService1Client();
            DataSet ui = esc.getUserInfor();
            dspInfor.DataSource = ui.Tables[0];
            dspInfor.DataBind();
             
        }
    }
}