using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class AdminManager
    {
        //Add reported Job
        public void ReportJob(int EmployerID, int JobSeekerID, int JobID, string Comment)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            ReportJob reportJob = new ReportJob();

            reportJob.EmployerID = EmployerID;
            reportJob.JobSeekerID = JobSeekerID;
            reportJob.JobID = JobID;
            reportJob.Comment = Comment;
            database.ReportJobs.InsertOnSubmit(reportJob);
            database.SubmitChanges();
        }

        //Read Reported Job
        public List<ReportJob> AllReportJobs()
        {
            List<ReportJob> reportJob = new List<ReportJob>();
            try
            {

                DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
                foreach (var rpJb in database.ReportJobs)
                {
                    ReportJob report = new ReportJob(); //store information of a single user
                    report.ReportJobID = rpJb.ReportJobID;
                    report.EmployerID = rpJb.EmployerID;
                    report.JobSeekerID = rpJb.JobSeekerID;
                    report.JobID = rpJb.JobID;
                    report.Comment = rpJb.Comment;

                    reportJob.Add(report);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return reportJob;
        }
    }
}