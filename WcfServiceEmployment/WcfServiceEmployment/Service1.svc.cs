﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceEmployment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

       public void insert(string userName, string firstName, string lastName, string Adress, string Email,
       string phoneNumber, string phoneNumberalt, int authinticationLevel, string password)
        {

            UserDataClassesDataContext db = new UserDataClassesDataContext();
            UserEmployment user = new UserEmployment();
            user.userName = userName;
            user.firstName = firstName;
            user.lastName = lastName;
            user.Adress = Adress;
            user.Email = Email;
            user.phoneNumber = phoneNumber;
            user.phoneNumberAlt = phoneNumberalt;
            user.password = password;
            user.authinticationLevel = authinticationLevel;
            db.UserEmployments.InsertOnSubmit(user);
            db.SubmitChanges();
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
