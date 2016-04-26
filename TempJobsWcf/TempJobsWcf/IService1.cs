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
        string GetData(int value);
        /*Registration function 
         * */
        [OperationContract]
        void RegistrationDatabase(string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel, string profileImage);

        [OperationContract]
        void RegistrationDatabaseUpdate(int id, string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string profileImage_string, int age, string gender);

        [OperationContract]
        void storeEmployees(string employee_status, int wage_min, int wage_max, string prefered_hours, string isAvailable, int UserData_ID);

        [OperationContract]
        void storeEmployeesUpdates(string employee_status, int wage_min, int wage_max, string prefered_hours, string isAvailable, int UserData_ID);

        [OperationContract]
        bool LgnUser(string username, string password, out string message, out int id);

        [OperationContract]
        bool UserNameCheck(string UserName, out string message);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        List<Userdata> ReadUsers();

        [OperationContract]
        List<Employee_Data> ReadEmployees();

        [OperationContract]
        void getEmployee_id(int UserData_Id, out int employee_id);

        [OperationContract]
        void StoreSkills(string Name, int Employee_Id);

        [OperationContract]
        void StoreSkillsUpdates(string Name, int Employee_Id);// save the skills of all the workers 

        
        [OperationContract]
        List<InformalSkill> ReadSkills();

        [OperationContract]
        string ImageToBase64String(Image image);

        [OperationContract]
        Userdata SingleUserDetails(int ID);

        [OperationContract]
        void storeEmployers(int numberOfJobs, double Rating, string prefered_hours, string isAvailable, int UserData_ID);

        [OperationContract]
        List<Employer> ReadEmployers();

        [OperationContract]
        void PostJob(string name, string description, int duration_hours, string location, double reward, string JobPicture, int employerID);

        [OperationContract]
        List<Job> ListOfJobs();
        /* [OperationContract]
         Image Base64ToImage(string base64String);*/
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
