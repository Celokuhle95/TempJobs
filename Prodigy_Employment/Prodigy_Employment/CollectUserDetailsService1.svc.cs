using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient; 


namespace Prodigy_Employment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CollectUserDetailsService1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CollectUserDetailsService1.svc or CollectUserDetailsService1.svc.cs at the Solution Explorer and start debugging.
    public class CollectUserDetailsService1 : ICollectUserDetailsService1
    {
        public void DoWork()
        {
        }

        public DataSet getUserInfor()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server =.;database=UserDB; user=sa;password=12345";
            SqlDataAdapter da = new SqlDataAdapter("select * from userInfor", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
