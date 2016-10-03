using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class InvitationAndEmployment
    {
        public void InviteJobSeeker(int EmployerID, int JobSeekerID, int JobID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            bool exists = false;
            foreach(var inv in database.JobInvitations)
            {
                if(inv.EmployerID.Equals(EmployerID) && inv.JobSeekerID.Equals(JobSeekerID) && inv.JobID.Equals(JobID))
                {
                    exists = true;
                }
            }
            if(exists.Equals(false))
            {
                JobInvitation invite = new JobInvitation();
                invite.EmployerID = EmployerID;
                invite.JobSeekerID = JobSeekerID;
                invite.JobID = JobID;
                database.JobInvitations.InsertOnSubmit(invite);
                database.SubmitChanges();
            }          
        }

        public List<int> Invitation_Employers(int JobSeekerID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            List<int> employerIDs = new List<int>();           
            foreach(var inv in database.JobInvitations)
            {
                if(inv.JobSeekerID.Equals(JobSeekerID))
                {
                    employerIDs.Add(Convert.ToInt32(inv.EmployerID));
                }
            }                    
            return employerIDs;                     
        }

        public List<JobInvitation> GetAllInvites()
        {
            List<JobInvitation> invites = new List<JobInvitation>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            foreach (var inv in database.JobInvitations)
            {
                JobInvitation invite = new JobInvitation();
                invite.JobInvitationID = inv.JobInvitationID;
                invite.EmployerID = inv.EmployerID;
                invite.JobSeekerID = inv.JobSeekerID;
                invite.JobID = inv.JobID;
                invites.Add(invite);
            }
            return invites;
        }

        public List<Invitation> GetJobSeekerJobInvites(int JobSeekerID)
        {
            List<Invitation> invites = new List<Invitation>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();

            var invQuery = from inv in database.JobInvitations
                           where inv.JobSeekerID.Equals(JobSeekerID)
                           join job in database.Jobs
                           on inv.JobID equals job.JobID
                           join empl in database.Employers
                           on job.EmployerID equals empl.EmployerID
                           select new
                           {
                               job.JobID,
                               job.Name,
                               job.Description,
                               job.NumberOfDays,
                               job.DueDate,
                               job.StartDate,
                               job.StartTime,
                               job.EndTime,
                               job.Location,
                               job.ToBePaid,
                               job.DatePosted,
                               job.RequiredSkill,
                               empl.FirstName,
                               empl.LastName,
                               empl.ProfileImage_String                                                       
                           };
            foreach (var invi in invQuery)
            {
                Invitation a = new Invitation();
                a.JobID = invi.JobID;
                a.Name = invi.Name;
                a.Description = invi.Description;
                a.NumberOfDays = Convert.ToInt32(invi.NumberOfDays);
                a.DueDate = invi.DueDate;
                a.StartDate = invi.StartDate;
                a.StartTime = invi.StartTime;
                a.EndTime = invi.EndTime;
                a.Location = invi.Location;
                a.ToBePaid = Convert.ToDouble(invi.ToBePaid);
                a.DatePosted = invi.DatePosted;
                a.RequiredSkill = invi.RequiredSkill;
                a.EmployerFirstName = invi.FirstName;
                a.EmployerLastName = invi.LastName;
                a.EmployerImage = invi.ProfileImage_String;
                invites.Add(a);
            }
            return invites;        
        }
    }
}