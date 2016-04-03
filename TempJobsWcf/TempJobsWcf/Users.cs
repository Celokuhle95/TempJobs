using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class Users
    {
        public int ID { set; get; }

        public String Username { set; get; }

        public String Password { set; get; }

        public String Email { set; get; }

        public String ContactNumber { set; get; }

        public String AlternativeNUmber { set; get; }

        public String Address { set; get; }

        public int AuthenticationLevel { set; get; }

        public String FirstName { set; get; }

        public String LastName { set; get; }

}
}