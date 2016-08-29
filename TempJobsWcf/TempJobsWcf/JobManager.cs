using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class JobManager
    {
        public void PostJob(string Name, string Description, int NumberOfDaysRequired, string DueDate, string StartDate, string StartTime, string EndTime, string Location, double ToBePaid, string RequiredSkill ,int EmployerID)
        {
            Job newJob = new Job();

            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            newJob.Name = Name;
            newJob.Description = Description;
            newJob.NumberOfDays = NumberOfDaysRequired;
            newJob.DueDate = DueDate;
            newJob.StartDate = StartDate;
            newJob.StartTime = StartTime;
            newJob.EndTime = EndTime;
            newJob.Location = Location;
            newJob.ToBePaid = ToBePaid;

            DateTime today = DateTime.Today;
            string string_date = today.ToString("dd/MMMM/yyyy");

            newJob.DatePosted = string_date;
            newJob.RequiredSkill = RequiredSkill;
            newJob.EmployerID = EmployerID;
            database.Jobs.InsertOnSubmit(newJob);
            database.SubmitChanges();
        }

        public List<Job> AllJobs ()
        {        
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            var jobs = new List<Job>(); 
            foreach(var jb in database.Jobs)
            {
                Job job = new Job();
                job.JobID = jb.JobID;
                job.Name = jb.Name;
                job.Description = jb.Description;
                job.NumberOfDays=jb.NumberOfDays;
                job.DueDate =jb.DueDate;
                job.StartDate = jb.StartDate;
                job.StartTime = jb.StartTime;
                job.EndTime = jb.EndTime;
                job.Location = jb.Location;
                job.ToBePaid = jb.ToBePaid;
                job.DatePosted = jb.DatePosted;
                job.RequiredSkill = jb.RequiredSkill;
                jobs.Add(job);
            }
            return jobs; 
        }

        public void ApplyForJob(int JobID, int JobseekerID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            JobApplication jobApplication = new JobApplication();

            jobApplication.JobID = JobID;
            jobApplication.JobSeekerID = JobseekerID;
            database.JobApplications.InsertOnSubmit(jobApplication);
            database.SubmitChanges();
        }

        public List<JobSeeker> getApplicants(int EmployerID)
        {          
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            var jobSeekersQuery = from empl in database.Employers
                             join job in database.Jobs
                             on empl.EmployerID equals job.EmployerID
                             where job.EmployerID.Equals(EmployerID)
                             join jobApp in database.JobApplications
                             on job.JobID equals jobApp.JobID
                             join jobSeeker in database.JobSeekers
                             on jobApp.JobSeekerID equals jobSeeker.JobSeekerID
                             select jobSeeker;

            List<JobSeeker> JobSeekers = new List<JobSeeker>();    
            foreach(var job in jobSeekersQuery)
            {
                var js = new JobSeeker();
                js.JobSeekerID = job.JobSeekerID;
                js.FirstName = job.FirstName;
                js.LastName = job.LastName;
                js.EmailAddress = job.EmailAddress;
                js.ContactNumber = job.ContactNumber;
                js.AlternativeContactNumber = job.AlternativeContactNumber;
                js.ResidentialAddress = job.ResidentialAddress;
                js.ProfileImage_String = job.ProfileImage_String;
                js.isAvailable = job.isAvailable;
                JobSeekers.Add(js);
            }         
            return JobSeekers;
        }
        public List<JobApplication> GetAllApplications()
        {
            List<JobApplication> invites = new List<JobApplication>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            foreach (var app in database.JobApplications)
            {
                JobApplication appl = new JobApplication();
                appl.ApplicationID = app.ApplicationID;
                appl.JobID = app.JobID;
                appl.JobSeekerID = app.JobSeekerID;
                invites.Add(appl);
            }
            
           return invites;           
        }
        public void DeleteJob(int JobID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            Job Job = (from jb in database.Jobs
                       where jb.JobID == JobID
                       select jb).Single();
            database.Jobs.DeleteOnSubmit(Job);
        }

        public void DeleteJobApplication(int JobApplicationID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            JobApplication JobApp = (from ja in database.JobApplications
                       where ja.ApplicationID == JobApplicationID
                       select ja).Single();
            database.JobApplications.DeleteOnSubmit(JobApp);
        }

        //add more functions relating to job management
        public List<Job> EmployerSpecificJobs(int EmployerID)
        {            
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            List<Job> jobs = new List<Job>();
            foreach (var jb in database.Jobs)
            {
                if(jb.EmployerID.Equals(EmployerID))
                {
                    Job job = new Job();
                    job.JobID = jb.JobID;
                    job.Name = jb.Name;
                    job.Description = jb.Description;
                    job.NumberOfDays = jb.NumberOfDays;
                    job.DueDate = jb.DueDate;
                    job.StartDate = jb.StartDate;
                    job.StartTime = jb.StartTime;
                    job.EndTime = jb.EndTime;
                    job.Location = jb.Location;
                    job.ToBePaid = jb.ToBePaid;
                    job.DatePosted = jb.DatePosted;
                    job.RequiredSkill = jb.RequiredSkill;
                    job.EmployerID = jb.EmployerID;
                    jobs.Add(job);
                }
            }          
            return jobs;           
        }

        public List<JobSeeker> SkilledJobSeeker(string search_skill)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            var jobSeekers = from skill in database.InformalSkills
                             join js in database.JobSeekers
                             on skill.JobSeekerID equals js.JobSeekerID
                             where skill.Name.Equals(search_skill)
                             select js;

            List<JobSeeker> jobseekers = new List<JobSeeker>();
            foreach (var a in jobSeekers)
            {
                JobSeeker jobSk = new JobSeeker();
                jobSk.FirstName = a.FirstName;
                jobSk.LastName = a.LastName;
                jobSk.EmailAddress = a.EmailAddress;
                jobSk.ContactNumber = a.ContactNumber;
                jobSk.AlternativeContactNumber = a.AlternativeContactNumber;
                jobSk.ResidentialAddress = a.ResidentialAddress;
                jobSk.ProfileImage_String = a.ProfileImage_String;
                jobSk.isAvailable = a.isAvailable;
                jobseekers.Add(jobSk);
            }
            return jobseekers;
        }


    }
}