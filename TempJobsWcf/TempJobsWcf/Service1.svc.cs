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

        public void RegistrationDatabase(string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel, string profileImage_string)
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
            user.ProfileImage_String = profileImage_string;
            db.Userdatas.InsertOnSubmit(user);
            db.SubmitChanges();
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
                user.Age = age;
                user.Gender = gender;
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
        public void StoreSkills(string Name, int Employee_Id)// save the skills of all the workers 
        {
            userDataClassesDataContext database = new userDataClassesDataContext();
            InformalSkill skill = new InformalSkill();
            skill.Name = Name;
            skill.Employee_Id = Employee_Id;
            database.InformalSkills.InsertOnSubmit(skill);
            database.SubmitChanges();
        }
        public void StoreSkillsUpdates(string Name, int Employee_Id)// save the skills of all the workers 
        {
            try
            {
                userDataClassesDataContext database = new userDataClassesDataContext();
                InformalSkill skill = (from s in database.InformalSkills where s.Employee_Id == Employee_Id select s).Single();
                skill.Name = Name;
                database.SubmitChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void storeEmployeesUpdates(string employee_status, int wage_min, int wage_max, string prefered_hours, string isAvailable, int UserData_ID)
        {
            try
            {
                userDataClassesDataContext database = new userDataClassesDataContext();
                Employee_Data employee = (from e in database.Employee_Datas where e.UserData_ID == UserData_ID select e).Single();
                employee.Employment_status = employee_status;
                employee.wage_Min = wage_min;
                employee.wage_max = wage_max;
                employee.prefered_hours = prefered_hours;
                employee.isAvailable = isAvailable;
                employee.UserData_ID = UserData_ID;
                database.SubmitChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void storeEmployees(string employee_status, int wage_min, int wage_max, string prefered_hours, string isAvailable, int UserData_ID)
        {
            //try
            //{
            userDataClassesDataContext database = new userDataClassesDataContext();
            Employee_Data employee = new Employee_Data();

            employee.Employment_status = employee_status;
            employee.wage_Min = wage_min;
            employee.wage_max = wage_max;
            employee.prefered_hours = prefered_hours;
            employee.isAvailable = isAvailable;
            employee.UserData_ID = UserData_ID;
            database.Employee_Datas.InsertOnSubmit(employee);
            database.SubmitChanges();
            //}
            //catch (Exception sqlEx)
            //{
            //    sqlEx.ToString();
            //}
        }

        public void storeEmployers(int numberOfJobs, double Rating, string prefered_hours, string isAvailable, int UserData_ID)
        {
            //try
            //{
            userDataClassesDataContext database = new userDataClassesDataContext();
            Employer employer = new Employer();

            employer.numberOfJobsOffered = numberOfJobs;
            employer.Rating = Rating;
            employer.prefered_hours = prefered_hours;
            employer.isAvailabe = isAvailable;
            employer.UserData_ID = UserData_ID;
            database.Employers.InsertOnSubmit(employer);
            database.SubmitChanges();
            //}
            //catch (Exception sqlEx)
            //{
            //    sqlEx.ToString();
            //}
        }


        public Boolean LgnUser(string username, string password, out string message, out int id)
        {
            id = -1;
            try
            {
                userDataClassesDataContext db = new userDataClassesDataContext();
                Userdata user = (from u in db.Userdatas where u.Username.Equals(username) select u).Single();
                if (user != null)
                {
                    if (user.password.Equals(password))
                    {
                        message = "Correct";
                        id = user.Id;
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
                if (user.Username == userName)
                    return true;
                else
                    return false;

            }
            catch (InvalidOperationException e)
            {
                message = "";
                return false;
            }
        }
        public List<Userdata> ReadUsers()
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
                    currentUser.contactNumber = u.contactNumber;
                    currentUser.alternativeNumber = u.alternativeNumber;
                    currentUser.address = u.address;
                    currentUser.authinticationLevel = u.authinticationLevel;
                    currentUser.firstName = u.firstName;
                    currentUser.lastName = u.lastName;
                    currentUser.Age = u.Age;
                    currentUser.Gender = u.Gender;
                    currentUser.ProfileImage_String = u.ProfileImage_String;

                    Users.Add(currentUser);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return Users;
        }

        public List<Employee_Data> ReadEmployees()
        {
            List<Employee_Data> employees = new List<Employee_Data>();

            try
            {
                userDataClassesDataContext database = new userDataClassesDataContext();
                foreach (var u in database.Employee_Datas)
                {
                    Employee_Data currentEmployee = new Employee_Data();
                    currentEmployee.UserData_ID = u.UserData_ID;
                    currentEmployee.Employee_Id = u.Employee_Id;
                    currentEmployee.Employment_status = u.Employment_status;
                    currentEmployee.wage_Min = u.wage_Min;
                    currentEmployee.wage_max = u.wage_max;
                    currentEmployee.prefered_hours = u.prefered_hours;
                    currentEmployee.isAvailable = u.isAvailable;

                    employees.Add(currentEmployee);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return employees;
        }

        public List<Employer> ReadEmployers()
        {
            List<Employer> employers = new List<Employer>();

            try
            {
                userDataClassesDataContext database = new userDataClassesDataContext();
                foreach (var u in database.Employers)
                {
                    Employer currentEmployer = new Employer();
                    currentEmployer.UserData_ID = u.UserData_ID;
                    currentEmployer.Employer_Id = u.Employer_Id;
                    currentEmployer.Rating = u.Rating;
                    currentEmployer.numberOfJobsOffered = u.numberOfJobsOffered;
                    currentEmployer.prefered_hours= u.prefered_hours;
                    currentEmployer.isAvailabe = u.isAvailabe;

                    employers.Add(currentEmployer);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return employers;
        }

        public void getEmployee_id(int UserData_Id, out int employee_id)
        {
            employee_id = -1;
            try
            {
                userDataClassesDataContext db = new userDataClassesDataContext();
                Employee_Data emp = (from e in db.Employee_Datas where e.UserData_ID == UserData_Id select e).Single();
                employee_id = emp.Employee_Id;
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
                    currentSkill.Employee_Id = skill.Employee_Id;
                    AllSkills.Add(currentSkill);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return AllSkills;
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

        public Userdata SingleUserDetails(int ID)
        {
            userDataClassesDataContext database = new userDataClassesDataContext();
            //Userdata user = (from u in database.Userdatas where u.Id.Equals(ID) select u).Single(); //table inside database
            Userdata user = new Userdata();
            foreach (var u in database.Userdatas)
            {
                if (u.Id.Equals(ID))
                {
                    user.Id = u.Id;
                    user.Username = u.Username;
                    user.password = u.password;
                    user.Email = u.Email;
                    user.contactNumber = u.contactNumber;
                    user.alternativeNumber = u.alternativeNumber;
                    user.address = u.address;
                    user.authinticationLevel = u.authinticationLevel;
                    user.firstName = u.firstName;
                    user.lastName = u.lastName;
                    user.ProfileImage_String = u.ProfileImage_String;
                }

            }
            return user;
        }

        public void PostJob(string name, string description, int duration_hours, string location, double reward,string JobPicture, int employerID)
        {
            JobManager job = new JobManager();
            job.post(name, description, duration_hours, location, reward,JobPicture, employerID);
        }

        public List<Job> ListOfJobs()
        {
            JobManager job = new JobManager();
            return job.ListOfJobs();
        }

        /* public Image Base64ToImage(string base64String)
         {
             throw new NotImplementedException();
         }*/
    }
}
