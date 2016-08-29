﻿using System;
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
        //Register
        public void RegisterEmployer(string FirstName, string LastName, string EmailAddress, string Password, string ContactNumber, string AlternativeContactNumber, string ResidentialAddress, string ProfileImage)
        {
            UserManager employer = new UserManager();
            employer.RegisterEmployer(FirstName, LastName, EmailAddress, Password, ContactNumber, AlternativeContactNumber, ResidentialAddress, ProfileImage);
        }

        public void RegisterJobSeeker(string FirstName, string LastName, string EmailAddress, string Password, string ContactNumber, string AlternativeContactNumber, string ResidentialAddress, string ProfileImage)
        {
            UserManager JobSeeker = new UserManager();
            JobSeeker.RegisterJobSeeker(FirstName, LastName, EmailAddress, Password, ContactNumber, AlternativeContactNumber, ResidentialAddress, ProfileImage);
        }
        //Login
        public void LoginEmployer(string EmailAddress, string Password, out int EmployerID, out bool CanLogin)
        {
            UserManager employer  = new UserManager();
            CanLogin = employer.LoginEmployer(EmailAddress, Password, out EmployerID);
        }

        public void LoginJobSeeker(string EmailAddress, string Password, out int JobSeekerID, out bool CanLogin)
        {
            UserManager jobSeeker = new UserManager();
            CanLogin = jobSeeker.LoginJobSeeker(EmailAddress, Password, out JobSeekerID);
        }

        public void LoginAdmin(string EmailAddress, string Password, out int AdminID, out bool CanLogin)
        {
            UserManager admin = new UserManager();
            CanLogin = admin.LoginAdmin(EmailAddress, Password, out AdminID);
        }

        //Read data
        public List<JobSeeker> AllJobseekers()
        {
            UserManager JobSeekers = new UserManager();
            return JobSeekers.AllJobseekers();
        }

        public List<Employer> AllEmployers()
        {
            UserManager employ = new UserManager();
            return employ.AllEmployers();
        }

        public JobSeeker SingleJobseeker(int JobSeekerID)
        {
            UserManager js = new UserManager();
            return js.SingleJobseeker(JobSeekerID);
        }

        public Employer SingleEmployer(int EmployerID)
        {
            UserManager employer = new UserManager();
            return employer.SingleEmployer(EmployerID);
        }

        //Delete Users
        public void DeleteEmployer(int EmployerID)
        {
            UserManager toDelete = new UserManager();
            toDelete.DeleteEmployer(EmployerID);
        }

        public void DeleteJobSeeker(int JobSeekerID)
        {
            UserManager toDelete = new UserManager();
            toDelete.DeleteJobSeeker(JobSeekerID);
        }

        //change password
        public void ChangeJobSeekerPassword(string EmailAddress, string Password, out bool success)
        {
            UserManager js = new UserManager();
            js.ChangeJobSeekerPassword(EmailAddress, Password, out success);
        }

        public void ChangeEmployerPassword(string EmailAddresss, string Password, out bool success)
        {
            UserManager employer = new UserManager();
            employer.ChangeEmployerPassword(EmailAddresss, Password, out success);
        }

        //Jobseekers skills
        public void StoreSkills(string Name, int SkillLevel, int JobSeekerID)// save the skills of all the workers 
        {
            SkillsManager skills = new SkillsManager();
            skills.StoreSkills(Name, SkillLevel, JobSeekerID);
        }

        public List<InformalSkill> ReadSkills(int JobSeekerID)
        {
            DatabaseClasssesDataContext db = new DatabaseClasssesDataContext();
            List<InformalSkill> skill = new List<InformalSkill>();
            foreach (var s in db.InformalSkills)
            {
                if (s.JobSeekerID.Equals(JobSeekerID))
                {
                    InformalSkill sk = new InformalSkill();
                    sk.Name = s.Name;
                    sk.SkillLevel = s.SkillLevel;
                    skill.Add(sk);
                }
            }
            return skill;
        }

        //jobs
        public void PostJob(string Name, string Description, int NumberOfDaysRequired, string DueDate, string StartDate, string StartTime, string EndTime, string Location, double ToBePaid, string RequiredSkill, int EmployerID)
        {
            JobManager job = new JobManager();
            job.PostJob(Name, Description, NumberOfDaysRequired, DueDate, StartDate, StartTime, EndTime, Location, ToBePaid, RequiredSkill, EmployerID);
        }

        public List<Job> AllJobs()
        {
            JobManager job = new JobManager();
            return job.AllJobs();
        }

        public List<Job> EmployerSpecificJobs(int EmployerID)
        {
            JobManager job = new JobManager();
            return job.EmployerSpecificJobs(EmployerID);
        }

        public void ApplyForJob(int jobID, int jobseekerID)
        {
            JobManager job = new JobManager();
            job.ApplyForJob(jobID, jobseekerID);
        }

        public List<JobSeeker> getApplicants(int EmployerID)
        {
            JobManager job = new JobManager();
            return job.getApplicants(EmployerID);
        }

        public List<JobApplication> GetAllApplications()
        {
            JobManager job = new JobManager();
            return job.GetAllApplications();
        }

        //Delete Jobs
        public void DeleteJob(int JobID)
        {
            JobManager toDelete = new JobManager();
            toDelete.DeleteJob(JobID);
        }

        public void DeleteJobApplication(int JobApplicationID)
        {
            JobManager toDelete = new JobManager();
            toDelete.DeleteJobApplication(JobApplicationID);
        }

    
        public string test()
        {
            return "you were successful";
        }
        //Tools and equipment
        public void AddNewToolOrEquipment(string Name, string Image, int JobSeekerID)
        {
            ToolAndEquipment te = new ToolAndEquipment();
            te.AddNewToolOrEquipment( Name, Image, JobSeekerID); 
        }

        public void RemoveToolOrEquipment(int tool_equipementID)
        {
            ToolAndEquipment te = new ToolAndEquipment();
            te.RemoveToolOrEquipment(tool_equipementID);
        }

        public List<Tools_Equipment> GetToolsAndEquipments(int JobSeekerID)
        {
            ToolAndEquipment te = new ToolAndEquipment();
            return te.GetToolsAndEquipments(JobSeekerID);
        }

        //Job invites
        public void InviteJobSeeker(int EmployerID, int JobSeekerID, int JobID)
        {
            InvitationAndEmployment invite = new InvitationAndEmployment();
            invite.InviteJobSeeker(EmployerID, JobSeekerID, JobID);
        }

        public List<int> Invitation_Employers(int JobSeekerID)
        {
            InvitationAndEmployment invite = new InvitationAndEmployment();
            return invite.Invitation_Employers(JobSeekerID);
        }

        public List<JobInvitation> GetAllInvites()
        {
            InvitationAndEmployment invite = new InvitationAndEmployment();
            return invite.GetAllInvites();
        }

        public List<Invitation> GetJobSeekerJobInvites(int JobSeekerID)
        {
            InvitationAndEmployment invite = new InvitationAndEmployment();
            return invite.GetJobSeekerJobInvites(JobSeekerID);
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

        public List<JobSeeker> SkilledJobSeeker(string search_skill)
        {
            JobManager job = new JobManager();
            return job.SkilledJobSeeker(search_skill);
        }
    }   
}
