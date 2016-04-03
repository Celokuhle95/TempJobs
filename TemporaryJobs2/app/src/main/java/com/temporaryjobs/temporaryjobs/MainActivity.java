package com.temporaryjobs.temporaryjobs;

import android.app.ActionBar;
import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.ActionBarActivity;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    Button bLogout;
    EditText etLName, etFName, etAddress,etEmail,etCellphone, etAge, etUsername, etPassword;
    UserLocalStore userLocalStore;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etLName = (EditText) findViewById(R.id.etLName);
        etFName = (EditText) findViewById(R.id.etFName);
        etAddress = (EditText) findViewById(R.id.etAddress);
        etCellphone = (EditText) findViewById(R.id.etCellphone);
        etEmail = (EditText) findViewById(R.id.etEmail);
        etAge = (EditText) findViewById(R.id.etAge);
        etUsername = (EditText) findViewById(R.id.etUsername);

        bLogout = (Button) findViewById(R.id.bLogout);

        bLogout.setOnClickListener(this);

        userLocalStore = new UserLocalStore(this);

    }


    protected void onStart()
    {
        super.onStart();
        if(authenticate() == true)
        {
            displayUserDetails();
        }
    }


    private boolean authenticate()
    {
        return userLocalStore.getUserLoggedIn();
    }

    private void displayUserDetails()
    {
        User user = userLocalStore.getLoggedInUser();

        etFName.setText(user.FName);
        etLName.setText(user.LName);
        etUsername.setText(user.Username);
        etAge.setText(user.Age + "");

    }

    @Override
    public void onClick(View v)
    {
        switch (v.getId())
        {
            case R.id.bLogout:
                userLocalStore.clearUserData();
                userLocalStore.setUserLoggedIn(false);

                startActivity(new Intent(this, Login.class));


                break;
        }
    }
}
