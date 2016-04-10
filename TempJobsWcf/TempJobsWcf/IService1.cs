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
        bool LgnUser(string username, string password, out string message, out int id);

        [OperationContract]
        bool UserNameCheck(string UserName, out string message);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
         List<Userdata> ReadEmployees();

        [OperationContract]
        void StoreSkills(string Name, int UserID);

        [OperationContract]
        List<InformalSkill> ReadSkills();

        [OperationContract]
        string ImageToBase64String(Image image);

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
