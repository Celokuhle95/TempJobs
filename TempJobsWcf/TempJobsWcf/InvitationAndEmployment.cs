using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class InvitationAndEmployment
    {
        public void InviteJobSeeker(int EmployerID, int JobSeekerID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            JobInvitation invite = new JobInvitation();
            invite.EmployerID = EmployerID;
            invite.JobSeekerID = JobSeekerID;
            database.JobInvitations.InsertOnSubmit(invite);
            database.SubmitChanges();
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
                invites.Add(invite);
            }
            return invites;
        }

        public List<JobInvitation> GetJobSeekerJobInvites(int JobSeekerID)
        {
            List<JobInvitation> invites = new List<JobInvitation>();
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            foreach (var inv in database.JobInvitations)
            {
                if(inv.JobSeekerID.Equals(JobSeekerID))
                {
                    JobInvitation invite = new JobInvitation();
                    invite.JobInvitationID = inv.JobInvitationID;
                    invite.EmployerID = inv.EmployerID;
                    invite.JobSeekerID = inv.JobSeekerID;
                    invites.Add(invite);
                }              
            }          
            return invites;           
        }
    }
}