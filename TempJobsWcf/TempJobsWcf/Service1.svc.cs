using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public void RegistrationDatabase(string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel, string profileImage)
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
            user.ProfileImage = profileImage;
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

        public Boolean UserNameCheck(string userName, out string message)
        {
            try
            {
                userDataClassesDataContext db = new userDataClassesDataContext(); //dataclass create
                Userdata user = (from u in db.Userdatas where u.Username.Equals(userName) select u).Single(); //table inside database
                message = userName + " already exist in our system";
                return false;
               
            }
            catch (InvalidOperationException e)
            {
                message = "";
                return true;
            }
        }
        public List<Userdata> ReadEmployees()
        {
            List<Userdata> Users = new List<Userdata>();

            try
            {
                userDataClassesDataContext database = new userDataClassesDataContext();
                foreach (var u in database.Userdatas)
                {
                    Userdata currentUser = new Userdata(); //store information of a single user

                    currentUser.Id = u.Id;
                    currentUser.Username = u.Username;
                    currentUser.password = u.password;
                    currentUser.Email = u.Email;
                    currentUser.contactNumber  = u.contactNumber;
                    currentUser.alternativeNumber = u.alternativeNumber;
                    currentUser.address = u.address;
                    currentUser.authinticationLevel = u.authinticationLevel;
                    currentUser.firstName = u.firstName;
                    currentUser.lastName = u.lastName;
                    currentUser.ProfileImage = u.ProfileImage;

                    Users.Add(currentUser);
                }
            }
            catch (Exception e)
            {
               e.ToString() ;
            }
            return Users;
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

        public void StoreSkills(string Name, int UserID)
        {
            userDataClassesDataContext database = new userDataClassesDataContext();
            InformalSkill skill = new InformalSkill();
            skill.Name = Name;
            skill.UserData_ID = UserID;
            database.InformalSkills.InsertOnSubmit(skill);
            database.SubmitChanges();
        }

        public List<InformalSkill> ReadSkills()
        {
            List<InformalSkill> AllSkills = new List<InformalSkill>();

            try
            {
                userDataClassesDataContext database = new userDataClassesDataContext();
                foreach (var skill in database.InformalSkills)
                {
                    InformalSkill currentSkill = new InformalSkill(); //store information of a single skill

                    currentSkill.Skill_ID = skill.Skill_ID;
                    currentSkill.Name = skill.Name;
                    currentSkill.UserData_ID = skill.UserData_ID;    
                    AllSkills.Add(currentSkill);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return AllSkills;
        }

        /*  public string ImageToBase64(Image image)
          {
              using (MemoryStream ms = new MemoryStream())
              {
                  // Convert Image to byte[]
                  image.Save(ms, format);
                  byte[] imageBytes = ms.ToArray();

                  // Convert byte[] to Base64 String
                  string base64String = Convert.ToBase64String(imageBytes);
                  return base64String;
              }
          }

          public Image Base64ToImage(string base64String)
          {
              throw new NotImplementedException();
          }*/
    }
}
