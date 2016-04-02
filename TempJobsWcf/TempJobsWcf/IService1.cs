using System;
using System.Collections.Generic;
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
        //function for the user to be able to  register
        void RegistrationDatabase( string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel);

         [OperationContract]
        //function that checks if the user registered for the user to be able to log in
         bool LgnUser(string username, string password, out string message);

         [OperationContract]
        //boolean function for checking if the user is registered
         bool UserNameCheck(string UserName, out string message);

         //this function returns all the records in the database given the UserName specified
         [OperationContract]
         void GetAllRecords(string email, out int id, out string firstName, out string lastName, out string address, out string contactNumbers, out string altanativeNumber, out int authenticationLevel);
        
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

       
        // TODO: Add your service operations here
        [OperationContract]
         List<Userdata> ReadEmployees();
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
