using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class JobManager
    {
        public void post(string name, string description, int duration_hours, string location, double reward,string JobPicture, int employerID)
        {
            Job newJob = new Job();
            userDataClassesDataContext database = new userDataClassesDataContext();
            newJob.Name = name;
            newJob.Description = description;
            newJob.Duration_Hours = duration_hours;
            newJob.Location = location;
            newJob.Reward = reward;
            newJob.JobPicture = JobPicture;
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
                job.JobPicture = jb.JobPicture;
                job.Employer_ID = jb.Employer_ID;
                jobs.Add(job);
            }
            return jobs;
        }
        //add more functions relating to job management
    }

   
}