using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class JobManager
    {
        public void PostJob(string Name, string Description, int NumberOfDaysRequired, string DueDate, string StartDate, string StartTime, string EndTime, string Location, double ToBePaid, int EmployerID)
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
            newJob.EmployerID = EmployerID;
            database.Jobs.InsertOnSubmit(newJob);
            database.SubmitChanges();
        }

        public List<Job> AllJobs ()
        {
            //List<Job> jobs = new List<Job>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            var jobs = from jb in database.Jobs
                       select new
                       {
                           jb.JobID,
                           jb.Name,
                           jb.Description,
                           jb.NumberOfDays,
                           jb.DueDate,
                           jb.StartDate,
                           jb.StartTime,
                           jb.EndTime,
                           jb.Location,
                           jb.ToBePaid
                       };

            return (List<Job>)jobs;
            //foreach (var jb in database.Jobs)
            //{
            //    Job job = new Job();
            //    job.JobID = jb.JobID;
            //    job.Name = jb.Name;
            //    job.Description = jb.Description;
            //    job.NumberOfDays = jb.NumberOfDays;
            //    job.DueDate = jb.DueDate;
            //    job.StartDate = jb.StartDate;
            //    job.StartTime = jb.StartTime;
            //    job.EndTime = jb.EndTime;
            //    job.Location = jb.Location;
            //    job.ToBePaid = jb.ToBePaid;
            //    job.EmployerID = jb.EmployerID;
            //    jobs.Add(job);
            //}
            //return jobs;
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
            //List<JobSeeker> JobSeekers = new List<JobSeeker>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            var jobSeekers = from empl in database.Employers
                             join job in database.Jobs
                             on empl.EmployerID equals job.EmployerID
                             where job.EmployerID.Equals(EmployerID)
                             join jobApp in database.JobApplications
                             on job.JobID equals jobApp.JobID
                             join jobSeeker in database.JobSeekers
                             on jobApp.JobSeekerID equals jobSeeker.JobSeekerID
                             select jobSeeker;
                             //select new
                             //{
                             //    jobSeeker.JobSeekerID,
                             //    jobSeeker.FirstName,
                             //    jobSeeker.LastName,
                             //    jobSeeker.EmailAddress,
                             //    jobSeeker.ContactNumber,
                             //    jobSeeker.AlternativeContactNumber,
                             //    jobSeeker.ResidentialAddress,
                             //    jobSeeker.ProfileImage_String,
                             //    jobSeeker.IsAvailable
                             //};
            return (List<JobSeeker>)jobSeekers;


            //foreach (var job in EmployerSpecificJobs(EmployerID))
            //{
            //    foreach(var app in GetAllApplications())
            //    {
            //        if(app.JobID.Equals(job.JobID))
            //        {
            //            UserManager user = new UserManager();
            //            JobSeeker js = user.SingleJobseeker(Convert.ToInt32(app.JobSeekerID));
            //            JobSeekers.Add(js);
            //        }
            //    }
            //}
            //return JobSeekers;
            //if (jobPosted != null)
            //{
            //    foreach (JobApplication jobApp in database.JobApplications)
            //    {
            //        if (jobPosted.JobID == jobApp.JobID)
            //        {
            //            JobSeeker jobSeeker = (from js in database.JobSeekers where js.JobSeekerID.Equals(jobApp.JobSeeker) select js).Single();
            //            JobSeekers.Add(jobSeeker);
            //        }
            //    }                  
            //}
            //return JobSeekers;
        }
        public List<JobApplication> GetAllApplications()
        {
            List<JobApplication> invites = new List<JobApplication>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            foreach (var app in database.JobApplications)
            {
                JobApplication invite = new JobApplication();
                invite.JobID = app.JobID;
                invite.JobSeekerID = app.JobSeekerID;
                invites.Add(invite);
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
            List<Job> jobs = new List<Job>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
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
                    job.EmployerID = jb.EmployerID;
                    jobs.Add(job);
                }
            }
           
            return jobs;
           
        }
    }
}