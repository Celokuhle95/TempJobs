using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class UserManager
    {
        public void RegisterEmployer(string FirstName, string LastName, string EmailAddress, string Password, string ContactNumber, string AlternativeContactNumber, string ResidentialAddress, string ProfileImage)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            Employer employer = new Employer();

            employer.FirstName = FirstName;
            employer.LastName = LastName;
            employer.EmailAddress = EmailAddress;
            employer.Password = Password;
            employer.ContactNumber = ContactNumber;
            employer.AlternativeContactNumber = AlternativeContactNumber;
            employer.ResidentialAddress = ResidentialAddress;
            employer.ProfileImage_String = ProfileImage;
            database.Employers.InsertOnSubmit(employer);
            database.SubmitChanges();
        }

        public void RegisterJobSeeker(string FirstName, string LastName, string EmailAddress, string Password, string ContactNumber, string AlternativeContactNumber, string ResidentialAddress, string ProfileImage)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            JobSeeker jobseeker = new JobSeeker();

            jobseeker.FirstName = FirstName;
            jobseeker.LastName = LastName;
            jobseeker.EmailAddress = EmailAddress;
            jobseeker.Password = Password;
            jobseeker.ContactNumber = ContactNumber;
            jobseeker.AlternativeContactNumber = AlternativeContactNumber;
            jobseeker.ResidentialAddress = ResidentialAddress;
            jobseeker.ProfileImage_String = ProfileImage;
            jobseeker.isAvailable = 0; //0 implies available, 1 implies non availability 
            database.JobSeekers.InsertOnSubmit(jobseeker);
            database.SubmitChanges();
        }

        public bool LoginEmployer(string EmailAddress, string Password, out int EmployerID)
        {
            EmployerID = -1;
            try
            {
                DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
                Employer employer = (from empl in database.Employers where empl.EmailAddress.Equals(EmailAddress) select empl).Single();
                if (employer != null)
                {
                    if (employer.Password.Equals(Password))
                    {
                        EmployerID = employer.EmployerID;
                        return true;
                    }
                    else
                    {                    
                        return false;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                return false;          
            }
            return false;
        }

        public bool LoginJobSeeker(string EmailAddress, string Password, out int JobSeekerID)
        {
            JobSeekerID = -1;
            try
            {
                DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
                JobSeeker jobSeeker = (from js in database.JobSeekers where js.EmailAddress.Equals(EmailAddress) select js).Single();
                if (jobSeeker != null)
                {
                    if (jobSeeker.Password.Equals(Password))
                    {
                        JobSeekerID = jobSeeker.JobSeekerID;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }
            return false;
        }

        public bool LoginAdmin(string EmailAddress, string Password, out int AdminID)
        {
            AdminID = -1;
            try
            {
                DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
                Admin admin = (from ad in database.Admins where ad.EmailAddress.Equals(EmailAddress) select ad).Single();
                if (admin != null)
                {
                    if (admin.Password.Equals(Password))
                    {
                        AdminID = admin.AdminID;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }
            return false;
        }

        public List<JobSeeker> AllJobseekers()
        {
            List<JobSeeker> JobSeekers = new List<JobSeeker>();
            try
            {
                DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
                foreach (var js in database.JobSeekers)
                {
                    JobSeeker jseeker = new JobSeeker();

                    jseeker.JobSeekerID = js.JobSeekerID;
                    jseeker.FirstName = js.FirstName;
                    jseeker.LastName = js.LastName;
                    jseeker.EmailAddress = js.EmailAddress;
                    jseeker.Password = js.Password;
                    jseeker.ContactNumber = js.ContactNumber;
                    jseeker.AlternativeContactNumber = js.AlternativeContactNumber;
                    jseeker.ResidentialAddress = js.ResidentialAddress;
                    jseeker.ProfileImage_String = js.ProfileImage_String;
                    jseeker.isAvailable = js.isAvailable;

                    JobSeekers.Add(jseeker);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return JobSeekers;
        }

        public List<Employer> AllEmployers() //not added in wcf service
        {
            List<Employer> employers = new List<Employer>();
            try
            {
                DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
                foreach (var em in database.Employers)
                {
                    Employer employer = new Employer(); //store information of a single user
                    employer.EmployerID = em.EmployerID;
                    employer.FirstName = em.FirstName;
                    employer.LastName = em.LastName;
                    employer.EmailAddress = em.EmailAddress;
                    employer.Password = em.Password;
                    employer.ContactNumber = em.ContactNumber;
                    employer.AlternativeContactNumber = em.AlternativeContactNumber;
                    employer.ResidentialAddress = em.ResidentialAddress;
                    employer.ProfileImage_String = em.ProfileImage_String;                   
                    employers.Add(employer);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return employers;
        }

        public JobSeeker SingleJobseeker(int JobSeekerID)
        {
            DatabaseClasssesDataContext db = new DatabaseClasssesDataContext();
            JobSeeker js = new JobSeeker();
            foreach (var s in db.JobSeekers)
            {
                if (s.JobSeekerID.Equals(JobSeekerID))
                {
                    js.FirstName = s.FirstName;
                    js.LastName = s.LastName;
                    js.EmailAddress = s.EmailAddress;
                    js.ContactNumber = s.ContactNumber;
                    js.AlternativeContactNumber = s.AlternativeContactNumber;
                    js.ResidentialAddress = s.ResidentialAddress;
                    js.ProfileImage_String = s.ProfileImage_String;
                    js.isAvailable = s.isAvailable;
                }
            }
            return js;
        }

        public Employer SingleEmployer(int EmployerID)
        {
            DatabaseClasssesDataContext db = new DatabaseClasssesDataContext();
            var employer = new Employer();
            foreach (var emp in db.Employers)
            {
                if (emp.EmployerID.Equals(EmployerID))
                {
                    employer.FirstName = emp.FirstName;
                    employer.LastName = emp.LastName;
                    employer.EmailAddress = emp.EmailAddress;
                    employer.ContactNumber = emp.ContactNumber;
                    employer.AlternativeContactNumber = emp.AlternativeContactNumber;
                    employer.ResidentialAddress = emp.ResidentialAddress;
                    employer.ProfileImage_String = emp.ProfileImage_String;                
                }
            }
            return employer;
        }

        public void ChangeJobSeekerPassword(string EmailAddress, string Password, out bool success)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            JobSeeker jobSeeker = new JobSeeker();
            foreach (var js in database.JobSeekers)
            {
                if(js.EmailAddress.Equals(EmailAddress))
                {
                    js.Password = Password;
                    success = true;
                    return;
                }  
            }
            success = false;
        }

        public void ChangeEmployerPassword(string EmailAddress, string Password, out bool success)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            Employer employer = new Employer();
            foreach (var em in database.Employers)
            {
                if (em.EmailAddress.Equals(EmailAddress))
                {
                    em.Password = Password;
                    success = true;
                    return;
                }
            }
            success = false;
        }

        public void DeleteEmployer(int EmployerID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            Employer employer = (from emp in database.Employers
                                     where emp.EmployerID.Equals(EmployerID)
                                     select emp).Single();
            database.Employers.DeleteOnSubmit(employer);
        }

        public void DeleteJobSeeker(int JobSeekerID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            JobSeeker jobSeeker = (from js in database.JobSeekers
                                 where js.JobSeekerID.Equals(JobSeekerID)
                                 select js).Single();
            database.JobSeekers.DeleteOnSubmit(jobSeeker);
        }
    }
}