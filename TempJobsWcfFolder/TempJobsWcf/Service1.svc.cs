using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TempJobsWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void RegistrationDatabase(string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel)
        {
            userDataClassesDataContext db = new userDataClassesDataContext();
            Userdata user = new Userdata();
            user.Username = userName;
            user.firstName = firstName;
            user.lastName = lastName;
            user.address = address;
            user.address = address;
            user.Email = Email;
            user.contactNumber = cantactNumbers;
            user.alternativeNumber = altanativeNumber;
            user.password = password;
            user.authinticationLevel = authenticationLevel;
            db.Userdatas.InsertOnSubmit(user);
            db.SubmitChanges();

        }

        public Boolean LgnUser(string username, string password,out string message)
        {
            try
            {
                userDataClassesDataContext db = new userDataClassesDataContext();
                Userdata user = (from u in db.Userdatas where u.Username.Equals(username) select u).Single();
                if (user != null)
                {
                    if (user.password.Equals(password))
                    {
                        message = "Correct";
                        return true;
                        
                    }
                    else
                    {
                        message = "password incorrect";
                        return false;

                    }
                }
                else
                {
                    message = username + " has not registered";
                    return false;
                }
            }
            catch (InvalidOperationException e)
            {
               message = username + "  has not registered";
                return false;
            }
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
