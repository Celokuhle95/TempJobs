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
       
        public void RegistrationDatabase(string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel, string profileImage_string)
        {
            UserManager user = new UserManager();
            user.Register(userName, firstName, lastName, address, Email, cantactNumbers, altanativeNumber, password, authenticationLevel, profileImage_string);
        }

        public void LgnUser(string username, string password, out int userID,out bool canLogin)
        {
            UserManager user = new UserManager();
            canLogin = user.Login(username, password, out userID);
        }
        public List<Userdata> ReadEmployees()
        {
            UserManager users = new UserManager();
            return users.ReadEmployees();
        }

        public Userdata SingleUserDetails(int ID)
        {
            UserManager user = new UserManager();
            return user.SingleUserDetails(ID);
        }

        public void StoreSkills(string Name, int UserID)// save the skills of all the workers 
        {
            SkillsManager skills = new SkillsManager();
            skills.StoreSkills(Name, UserID);
        }

        public List<InformalSkill> ReadSkills()
        {
            SkillsManager skills = new SkillsManager();
            return skills.ReadSkills();
        }

        public void PostJob(string name, string description, int duration_hours, string location, double reward, int employerID)
        {
            JobManager job = new JobManager();
            job.post(name, description, duration_hours, location, reward, employerID);
        }

        public List<Job> ListOfJobs()
        {
            JobManager job = new JobManager();
            return job.ListOfJobs();
        }

        public void ChangePassword(string username, string password, out bool success)
        {
            UserManager user = new UserManager();
            user.ChangePassword(username, password, out success);
        }
        public void ApplyForJob(int jobID, int jobseekerID)
        {
            JobManager job = new JobManager();
            job.ApplyForJob(jobID, jobseekerID);
        }

        public List<Userdata> getApplications(int EmployerID)
        {
            JobManager job = new JobManager();
            return job.getApplications(EmployerID);
        }

        public string ImageToBase64String(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                Bitmap bm = new Bitmap(image);//
                bm.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public void RegistrationDatabaseUpdate(int id, string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string profileImage_string, int age, string gender)
        {
            try
            {
                userDataClassesDataContext db = new userDataClassesDataContext();
                Userdata user = (from r in db.Userdatas where r.Id == id select r).Single();
                user.Username = userName;
                user.firstName = firstName;
                user.lastName = lastName;
                user.address = address;
                user.Email = Email;
                user.contactNumber = cantactNumbers;
                user.alternativeNumber = altanativeNumber;
                user.ProfileImage_String = profileImage_string;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                e.ToString();
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
