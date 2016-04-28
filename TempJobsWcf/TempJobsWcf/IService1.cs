using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TempJobsWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {       
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        void RegistrationDatabase(string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel, string profileImage);

        [OperationContract]
        void LgnUser(string username, string password, out int userID, out bool canLogin);

        [OperationContract]
         List<Userdata> ReadEmployees();

        [OperationContract]
        void StoreSkills(string Name, int UserID);

        [OperationContract]
        List<InformalSkill> ReadSkills();

        [OperationContract]
        string ImageToBase64String(Image image);

        [OperationContract]
        Userdata SingleUserDetails(int ID);

        [OperationContract]
        void PostJob( string name, string description, int duration_hours, string location, double reward, int employerID);

        [OperationContract]
        List<Job> ListOfJobs();

        [OperationContract]
        void ChangePassword(string username, string password, out bool success);

        [OperationContract]
        void ApplyForJob(int jobID, int jobseekerID);

        [OperationContract]
        List<Userdata> getApplications(int EmployerID);

        [OperationContract]
        void RegistrationDatabaseUpdate(int id, string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string profileImage_string, int age, string gender);
    }
 
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
}
