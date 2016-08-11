using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class JobManager
    {
        public void post(string Name, string Description, int NumberOfDaysRequired, int StartTime, int EndTime, string Location, double ToBePaid, int EmployerID)
        {
            Job newJob = new Job();

            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            newJob.Name = Name;
            newJob.Description = Description;
            newJob.NumberOfDays = NumberOfDaysRequired;
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
            List<Job> jobs = new List<Job>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            foreach(var jb in database.Jobs)
            {
                Job job = new Job();
                job.Name = jb.Name;
                job.Description = jb.Description;
                job.NumberOfDays = jb.NumberOfDays;
                job.StartTime = jb.StartTime;
                job.EndTime = jb.EndTime;
                job.Location = jb.Location;
                job.ToBePaid = jb.ToBePaid;
                job.EmployerID = jb.EmployerID;
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
            List<JobSeeker> JobSeekers = new List<JobSeeker>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            Job jobPosted = (from job in database.Jobs where job.EmployerID.Equals(EmployerID) select job).Single();
            if (jobPosted != null)
            {
                foreach (JobApplication jobApp in database.JobApplications)
                {
                    if (jobPosted.JobID == jobApp.JobID)
                    {
                        JobSeeker jobSeeker = (from js in database.JobSeekers where js.JobSeekerID.Equals(jobApp.JobSeeker) select js).Single();
                        JobSeekers.Add(jobSeeker);
                    }
                }                  
            }
            return JobSeekers;
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
       public List<Job> EmployerSpecificJobs(int EmployerID)
       {
            List<Job> jobs = new List<Job>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            jobs = (from job in database.Jobs where job.EmployerID.Equals(EmployerID) select job).ToList();
            if (jobs != null)
            {
                return jobs;
            }
            return null;
        }

        //add more functions relating to job management
    }


}