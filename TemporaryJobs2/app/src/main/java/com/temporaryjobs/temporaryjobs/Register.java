package com.temporaryjobs.temporaryjobs;

import android.app.Activity;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class Register extends Activity
{
    DatabaseHelper helper = new DatabaseHelper(this);
    Button bRegister;
    EditText lastName, firstName, WAddress,CEmail,CCellphone, CUsername, CPassword, CConfirmPassword;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);


       /* bRegister.setOnClickListener(this);
        {

        }*/

    }


    public void onRegistrationClick(View v)
    {
        if(v.getId() == R.id.bRegister)
        {
            firstName = (EditText) findViewById(R.id.etFName);
            lastName = (EditText) findViewById(R.id.etLName);
            WAddress = (EditText) findViewById(R.id.etAddress);
            CEmail = (EditText) findViewById(R.id.etEmail);
            CCellphone = (EditText) findViewById(R.id.etCellphone);
            CUsername = (EditText) findViewById(R.id.etUsername);
            CPassword = (EditText) findViewById(R.id.etPassword);
            CConfirmPassword = (EditText) findViewById(R.id.etConfirmPassword);
            bRegister = (Button) findViewById(R.id.bRegister);

            String FName = firstName.getText().toString();
            String LName = lastName.getText().toString();
            String Address = WAddress.getText().toString();
            String Email = CEmail.getText().toString();
            String Cellphone = CCellphone.getText().toString();
            String Username = CUsername.getText().toString();
            String Password = CPassword.getText().toString();
            String ConfirmPassword = CConfirmPassword.getText().toString();

            if(!Password.equals(ConfirmPassword))
            {
                //pop up message
                Toast pass = Toast.makeText(Register.this, "Passwords don't match!", Toast.LENGTH_SHORT);
                pass.show();
            }
            else
            {
                User u = new User();
                u.setFName(FName);
                u.setLName(LName);
                u.setAddress(Address);
                u.setEmail(Email);
                u.setCellphone(Cellphone);
                u.setUsername(Username);
                u.setPassword(Password);

                helper.insertEmployee(u);

                Toast temp = Toast.makeText(Register.this, "You have registered successfully!", Toast.LENGTH_SHORT);
                temp.show();



            }



        }
    }
    //@Override
  /*  public void onClick(View v)
    {
        switch (v.getId())
        {
            case R.id.bRegister:
                String FName = etFName.getText().toString();
                String LName = etLName.getText().toString();
                String Address = etAddress.getText().toString();
                String Email = etEmail.getText().toString();
                String Cellphone = etCellphone.getText().toString();
                int Age = Integer.parseInt(etAge.getText().toString());
                String Username = etUsername.getText().toString();
                String Password = etPassword.getText().toString();

                User registeredData = new User(FName, LName, Address, Email, Cellphone, Age, Username, Password);


                break;
        }
    }*/

}
