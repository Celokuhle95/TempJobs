package com.temporaryjobs.temporaryjobs;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Register extends AppCompatActivity implements View.OnClickListener
{
    Button bRegister;
    EditText etLName, etFName, etAddress,etEmail,etCellphone, etAge, etUsername, etPassword;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        etFName = (EditText) findViewById(R.id.etFName);
        etLName = (EditText) findViewById(R.id.etLName);
        etAddress = (EditText) findViewById(R.id.etAddress);
        etEmail = (EditText) findViewById(R.id.etEmail);
        etCellphone = (EditText) findViewById(R.id.etCellphone);
        etAge = (EditText) findViewById(R.id.etAge);
        etUsername = (EditText) findViewById(R.id.etUsername);
        etPassword = (EditText) findViewById(R.id.etPassword);
        bRegister = (Button) findViewById(R.id.bRegister);

        bRegister.setOnClickListener(this);
        {

        }

    }

    @Override
    public void onClick(View v)
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
    }

}
