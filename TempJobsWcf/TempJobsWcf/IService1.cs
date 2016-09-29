﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TempJobsWcf
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember] //Datamembers stores properties of the variable and they public
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {       
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // Registration
        [OperationContract]
        void RegisterEmployer(string FirstName, string LastName, string EmailAddress, string Password, string ContactNumber, string AlternativeContactNumber, string ResidentialAddress, string ProfileImage);

        [OperationContract]
        void RegisterJobSeeker(string FirstName, string LastName, string EmailAddress, string Password, string ContactNumber, string AlternativeContactNumber, string ResidentialAddress, string ProfileImage);

        //Login
        [OperationContract]
        void LoginEmployer(string EmailAddress, string Password, out int EmployerID, out bool CanLogin);

        [OperationContract]
        void LoginJobSeeker(string EmailAddress, string Password, out int JobSeekerID, out bool CanLogin);

        [OperationContract]
        void LoginAdmin(string EmailAddress, string Password, out int JobSeekerID, out bool CanLogin);

        [OperationContract]
        List<JobSeeker> AllJobseekers();

        [OperationContract]
        List<Employer> AllEmployers();

        [OperationContract]
        JobSeeker SingleJobseeker(int JobSeekerID);

        [OperationContract]
        Employer SingleEmployer(int EmployerID);
        //Delete Users
        [OperationContract]
        void DeleteEmployer(int EmployerID);

        [OperationContract]
        void DeleteJobSeeker(int JobSeekerID);

        //Change Password
        [OperationContract]
        void ChangeJobSeekerPassword(string EmailAddress, string Password, out bool success);

        [OperationContract]
        void ChangeEmployerPassword(string EmailAddress, string Password, out bool success);

        //Jobseekers skills
        [OperationContract]
        void StoreSkills(string Name, int SkillLevel, int JobSeekerID);

        [OperationContract]
        List<InformalSkill> ReadSkills(int JobSeekerID);

        //Jobs
        [OperationContract]
        int PostJob(string Name, string Description, int NumberOfDaysRequired, string DueDate, string StartDate, string StartTime, string EndTime, string Location, double ToBePaid, string RequiredSkill, int EmployerID);

        [OperationContract]
        List<Job> AllJobs();

        [OperationContract]
        List<Job> EmployerSpecificJobs(int EmployerID);

        [OperationContract]
        void ApplyForJob(int JobID, int JobseekerID);

        [OperationContract]
        List<JobSeeker> getApplicants(int EmployerID);

        [OperationContract]
        List<JobApplication> GetAllApplications();

        //Delete Jobs
        [OperationContract]
        void DeleteJob(int JobID);

        [OperationContract]
        void DeleteJobApplication(int JobApplicationID);

        [OperationContract]
        string test();

        //Tools and equipment
        [OperationContract]
        void AddNewToolOrEquipment(string Name, string Image, int JobSeekerID);

        [OperationContract]
        void RemoveToolOrEquipment(int tool_equipementID);

        [OperationContract]
        List<Tools_Equipment> GetToolsAndEquipments(int JobSeekerID);

        //JobInvites
        [OperationContract]
        void InviteJobSeeker(int EmployerID, int JobSeekerID, int JobID);

        [OperationContract]
        List<int> Invitation_Employers(int JobSeekerID);

        [OperationContract]
        List<JobInvitation> GetAllInvites();

        [OperationContract]
        List<Invitation> GetJobSeekerJobInvites(int JobSeekerID);

        //Specifically skilled job seekers
        [OperationContract]
        List<JobSeeker> SkilledJobSeeker(string search_skill);
    }
}


