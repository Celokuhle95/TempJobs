package com.temporaryjobs.temporaryjobs;

/**
 * Created by hp on 3/22/2016.
 */
public class User
{
    String FName, LName, Address, Email;
    String Username, Password, Cellphone;
    int Age;

    public User(String FName, String LName, String Address, String Email, String Cellphone, int Age, String Username, String Password)
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


    public User(Object o, Object o1) {

    }
}
