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
import android.widget.Toast;

public class MainActivity extends AppCompatActivity  {

    Button bLogout;
    Button bLogin;

    DatabaseHelper helper = new DatabaseHelper(this);

    EditText etLName, etFName, etAddress,etEmail,etCellphone, etUsername, etPassword;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etLName = (EditText) findViewById(R.id.etLName);
        etFName = (EditText) findViewById(R.id.etFName);
        etAddress = (EditText) findViewById(R.id.etAddress);
        etCellphone = (EditText) findViewById(R.id.etCellphone);
        etEmail = (EditText) findViewById(R.id.etEmail);
        etUsername = (EditText) findViewById(R.id.etUsername);

        bLogout = (Button) findViewById(R.id.bLogout);
        bLogin = (Button) findViewById(R.id.bLogin);


    }


    /*protected void onStart()
    {
        super.onStart();
        if(authenticate() == true)
        {
            displayUserDetails();
        }
    }*/



   /* private void displayUserDetails()
    {
        User user = userLocalStore.getLoggedInUser();

        etFName.setText(user.FName);
        etLName.setText(user.LName);
        etUsername.setText(user.Username);

    }*/


   /** public void onClick(View v)
    {
        switch (v.getId())
        {
            case R.id.bLogout:
                userLocalStore.clearUserData();
                userLocalStore.setUserLoggedIn(false);

                startActivity(new Intent(this, Login.class));


                break;
        }
    }*/

   public void onButtonClick(View v)
   {
       if(v.getId() == R.id.bLogin)
       {
           EditText a = (EditText) findViewById(R.id.TFusername);
           String str = a.getText().toString();
           EditText b = (EditText) findViewById(R.id.TFpassword);
           String pass = b.getText().toString();

           String password = helper.searchPass(str);

           if(pass.equals(password))
           {
               Intent i = new Intent(MainActivity.this, employees.class);
               i.putExtra("Username", str);
               startActivity(i);
           }
           else
           {
               Toast temp = Toast.makeText(MainActivity.this, "Username and password don't match!", Toast.LENGTH_SHORT);
               temp.show();
           }
       }
       else if(v.getId() == R.id.bLogout)
       {
           Intent i = new Intent(MainActivity.this, Register.class);
           startActivity(i);
       }
   }

   /* public void onClickReg(View v)
    {
        if(v.getId() == R.id.bLogout)
        {
            Intent i = new Intent(MainActivity.this, Register.class);
            startActivity(i);
        }
        if(v.getId() == R.id.bLogin)
        {
            Intent i = new Intent(MainActivity.this, Login1.class);

            startActivity(i);
        }
    }
*/

}
