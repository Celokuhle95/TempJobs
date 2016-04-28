using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class JobManager
    {
        public void post(string name, string description, int duration_hours, string location, double reward, int employerID)
        {
            Job newJob = new Job();
            userDataClassesDataContext database = new userDataClassesDataContext();
            newJob.Name = name;
            newJob.Description = description;
            newJob.Duration_Hours = duration_hours;
            newJob.Location = location;
            newJob.Reward = reward;
            newJob.Employer_ID = employerID;
            database.Jobs.InsertOnSubmit(newJob);
            database.SubmitChanges();
        }

        public List<Job> ListOfJobs ()
        {
            List<Job> jobs = new List<Job>();
            userDataClassesDataContext database = new userDataClassesDataContext();
            foreach(var jb in database.Jobs)
            {
                Job job = new Job();
                job.Name = jb.Name;
                job.Description = jb.Description;
                job.Duration_Hours = jb.Duration_Hours;
                job.Location = jb.Location;
                job.Reward = jb.Reward;
                job.Employer_ID = jb.Employer_ID;
                jobs.Add(job);
            }
            return jobs;
        }

        public void ApplyForJob(int jobID, int jobseekerID)
        {
            userDataClassesDataContext database = new userDataClassesDataContext();
            JobApp jobApplication = new JobApp();

            jobApplication.JobId = jobID;
            jobApplication.JobseekerId = jobseekerID;
            database.JobApps.InsertOnSubmit(jobApplication);
            database.SubmitChanges();
        }

        public List<Userdata> getApplications(int EmployerID)
        {
            List<Userdata> jobseekers = new List<Userdata>();
            userDataClassesDataContext database = new userDataClassesDataContext();
            foreach (Job job in database.Jobs)
            {
                if(job.Employer_ID.Equals(EmployerID))
                {
                    foreach(JobApp jobApp in database.JobApps)
                    {
                        if(job.JobID.Equals(jobApp.JobId))
                        {
                             foreach(Userdata jobseeker in database.Userdatas)
                             {
                                if(jobApp.JobseekerId.Equals(jobseeker.Id))
                                {//only store the information we are going to need
                                    Userdata jSeeker = new Userdata();
                                    jSeeker.firstName = jobseeker.firstName;
                                    jSeeker.lastName = jobseeker.lastName;
                                    jSeeker.contactNumber = jobseeker.contactNumber;
                                    jSeeker.ProfileImage_String = jobseeker.ProfileImage_String;
                                    jobseekers.Add(jSeeker);
                                }
                             }
                        }
                    }
                }
            }
            return jobseekers;
        }
        //add more functions relating to job management
    }

   
}