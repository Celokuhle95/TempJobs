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

        public void RegistrationDatabase(string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel)
        {
            //instatiating the linq dataclass with table from the database
            userDataClassesDataContext db = new userDataClassesDataContext();
            //instantiating the table in the linq from the databaase
            Userdata user = new Userdata();
            //adding a user to the database
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

        public void GetAllRecords(string email, out int id,out string firstName, out string lastName, out string address, out string contactNumbers, out string altanativeNumber, out int authenticationLevel)
        {
            id = -1;
            firstName = null;
            lastName = null;
            address = null;
            contactNumbers = null;
            altanativeNumber = null;
            authenticationLevel = -1;
            try
            {
                //instatiating the linq dataclass with table from the database
                userDataClassesDataContext db = new userDataClassesDataContext();
                //Accesing the user in our databse where the user in the database is the same as the user specified in the 
                Userdata user = (from u in db.Userdatas where u.Email.Equals(email) select u).Single();

                    id = user.Id;
                    firstName = user.firstName;
                    lastName = user.lastName;
                    address = user.address;
                    contactNumbers = user.contactNumber;
                    altanativeNumber = user.alternativeNumber;
                    authenticationLevel =(int)user.authinticationLevel;
            }
            catch (InvalidOperationException e)
            {
               return;
            }
        }

        public Boolean LgnUser(string email, string password,out string message)
        {
            try
            {
                //instatiating the linq dataclass with table from the database
                userDataClassesDataContext db = new userDataClassesDataContext();
                //Accesing the user in our databse where the user in the database is the same as the user specified in the parameters
                Userdata user = (from u in db.Userdatas where u.Email.Equals(email) select u).Single();
                if (user != null)
                {
                    //password validation matching the one in our database with the one in the parameters
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
                    message = email + " has not registered";
                    return false;
                }
            }
            catch (InvalidOperationException e)
            {
                //return false if the user has not registered yet
               message = email + "  has not registered";
                return false;
            }
        }

        public Boolean UserNameCheck(string email, out string message)
        {
            try
            {
                //instatiating the linq dataclass with table from the database
                userDataClassesDataContext db = new userDataClassesDataContext();
                //Accesing the user in our databse where the user in the database is the same as the user specified in the parameters
                Userdata user = (from u in db.Userdatas where u.Email.Equals(email) select u).Single();
                message = email + " already exist in our system";
                return false;
               
            }
            catch (InvalidOperationException e)
            {
                message = "";
                return true;
            }
        }
        //this functions reads all information of users in the database.
        public List<Userdata> ReadEmployees()
        {
            List<Userdata> users = new List<Userdata>();
            try
            {
                userDataClassesDataContext db = new userDataClassesDataContext();
                users = (from user in db.Userdatas select user).ToList();
               
            }
            catch (Exception e)
            {
               e.ToString() ;
            }
            return users;
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
