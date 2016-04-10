package com.temporaryjobs.temporaryjobs;

/**
 * Created by hp on 3/22/2016.
 */
public class User
{
    String FName, LName, Address, Email;
    String Username, Password, Cellphone;

    public void setFName(String fName)
{
    this.FName = fName;
}

    public String getFName()
    {
        return this.FName;
    }

    public void setLName(String LName)
    {
        this.LName = LName;
    }

    public String getLName()
    {
        return this.LName;
    }

    public void setAddress(String address)
    {
        this.Address = address;
    }

    public String getAddress()
    {
        return this.Address;
    }

    public void setEmail(String email)
    {
        this.Email = email;
    }

    public String getEmail()
    {
        return this.Email;
    }

    public void setUsername(String username)
    {
        this.Username = username;
    }

    public String getUsername()
    {
        return this.Username;
    }

    public void setCellphone(String cellphone)
    {
        this.Cellphone = cellphone;
    }

    public String getCellphone()
    {
        return this.Cellphone;
    }

    public void setPassword(String password)
    {
        this.Password = password;
    }

    public String getPassword()
    {
        return this.Password;
    }

   /* public User(String FName, String LName, String Address, String Email, String Cellphone, int Age, String Username, String Password)
    {
        this.FName = FName;
        this.LName = LName;
        this.Address = Address;
        this.Email = Email;
        this.Username = Username;
        this.Password = Password;
        this.Cellphone = Cellphone;
        this.Age = Age;
    }

    public User(String FName, String LName, String Address, String Cellphone, String Username, String Password)
    {
        this.FName = FName;
        this.LName = LName;
        this.Address = Address;
        this.Email = "";
        this.Username = Username;
        this.Password = Password;
        this.Cellphone = Cellphone;
        this.Age = -1;
    }
*/

   /* public User(Object o, Object o1) {

    }*/
}
