package com.temporaryjobs.temporaryjobs;

import android.content.Context;
import android.content.SharedPreferences;

/**
 * Created by hp on 3/22/2016.
 */
public class UserLocalStore
{
    public static final String SP_NAME = "userDetails";
    SharedPreferences userLocalDatabase;

    public UserLocalStore(Context context)
    {
        userLocalDatabase = context.getSharedPreferences(SP_NAME, 0);
    }

    public void storedUserData(User user) {
        SharedPreferences.Editor spEditor = userLocalDatabase.edit();
        spEditor.putString("FName", user.FName);
        spEditor.putString("LName", user.LName);
        spEditor.putString("Address", user.Address);
        spEditor.putString("Email", user.Email);
        spEditor.putString("Cellphone", user.Cellphone);
        spEditor.putInt("Age", user.Age);
        spEditor.putString("Username", user.Username);
        spEditor.putString("Password", user.Password);
        spEditor.commit();
    }


    public User getLoggedInUser()
    {
        String FName = userLocalDatabase.getString("FName", "");
        String LName = userLocalDatabase.getString("LName", "");
        String Address = userLocalDatabase.getString("Address", "");
        String Email = userLocalDatabase.getString("Email", "");
        String Cellphone = userLocalDatabase.getString("Cellphone", "");
        int Age = userLocalDatabase.getInt("Age", -1);
        String Username = userLocalDatabase.getString("Username", "");
        String Password = userLocalDatabase.getString("Password", "");


        User storedUser = new User(FName, LName,Address,Email,Cellphone,Age, Username, Password);

        return storedUser;

    }

    public void setUserLoggedIn(boolean loggedIn)
    {
        SharedPreferences.Editor spEditor = userLocalDatabase.edit();
        spEditor.putBoolean("loggedIn", loggedIn);
        spEditor.commit();
    }


    public boolean getUserLoggedIn()
    {
        if(userLocalDatabase.getBoolean("loggedIn", false) == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void clearUserData()
    {
        SharedPreferences.Editor spEditor = userLocalDatabase.edit();
        spEditor.clear();
        spEditor.commit();
    }

}
