using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class UserManager
    {
        public void Register(string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel, string profileImage_string)
        {
            userDataClassesDataContext db = new userDataClassesDataContext();
            Userdata user = new Userdata();
            user.Username = userName;
            user.firstName = firstName;
            user.lastName = lastName;
            user.address = address;
            user.address = address;
            user.Email = Email;
            user.contactNumber = cantactNumbers;
            user.alternativeNumber = altanativeNumber;
            user.password = password;
            user.authinticationLevel = authenticationLevel;
            user.ProfileImage_String = profileImage_string;
            db.Userdatas.InsertOnSubmit(user);
            db.SubmitChanges();

        }

        public bool Login(string username, string password, out int userID)
        {
            userID = -1;
            try
            {
                userDataClassesDataContext db = new userDataClassesDataContext();
                Userdata user = (from u in db.Userdatas where u.Username.Equals(username) select u).Single();
                if (user != null)
                {
                    if (user.password.Equals(password))
                    {
                        userID = user.Id;
                        return true;
                    }
                    else
                    {                    
                        return false;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                return false;          
            }
            return false;
        }

        public List<Userdata> ReadEmployees()
        {
            List<Userdata> Users = new List<Userdata>();
            try
            {
                userDataClassesDataContext database = new userDataClassesDataContext();
                foreach (var u in database.Userdatas)
                {
                    Userdata currentUser = new Userdata(); //store information of a single user

                    currentUser.Id = u.Id;
                    currentUser.Username = u.Username;
                    currentUser.password = u.password;
                    currentUser.Email = u.Email;
                    currentUser.contactNumber = u.contactNumber;
                    currentUser.alternativeNumber = u.alternativeNumber;
                    currentUser.address = u.address;
                    currentUser.authinticationLevel = u.authinticationLevel;
                    currentUser.firstName = u.firstName;
                    currentUser.lastName = u.lastName;
                    currentUser.ProfileImage_String = u.ProfileImage_String;

                    Users.Add(currentUser);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return Users;
        }

        public Userdata SingleUserDetails(int ID)
        {
            userDataClassesDataContext database = new userDataClassesDataContext();
            Userdata user = new Userdata();
            foreach (var u in database.Userdatas)
            {
                if (u.Id.Equals(ID))
                {
                    user.Id = u.Id;
                    user.Username = u.Username;
                    user.password = u.password;
                    user.Email = u.Email;
                    user.contactNumber = u.contactNumber;
                    user.alternativeNumber = u.alternativeNumber;
                    user.address = u.address;
                    user.authinticationLevel = u.authinticationLevel;
                    user.firstName = u.firstName;
                    user.lastName = u.lastName;
                    user.ProfileImage_String = u.ProfileImage_String;
                }
            }
            return user;
        }

        public void ChangePassword(string username, string password, out bool success)
        {
            userDataClassesDataContext database = new userDataClassesDataContext();
            Userdata user = new Userdata();
            foreach (var u in database.Userdatas)
            {
                if(u.Username.Equals(username))
                {
                    success = true;
                    u.password = password;
                    return;
                }  
            }
            success = false;
        }
    }
}