package com.temporaryjobs.temporaryjobs;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

/**
 * Created by hp on 4/3/2016.
 */
public class Login1 extends Activity {
    DatabaseHelper helper = new DatabaseHelper(this);

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.login1);

        Button bLogin;
        EditText etUsername, etPassword;


        etUsername = (EditText) findViewById(R.id.etUsername);
        etPassword = (EditText) findViewById(R.id.etPassword);
        bLogin = (Button) findViewById(R.id.bLogin);




    }

    public void onClickLog(View v)
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
                Intent i = new Intent(Login1.this, employees.class);
                i.putExtra("Username", str);
                startActivity(i);
            }
            else
            {
                Toast temp = Toast.makeText(Login1.this, "Username and password don't match!", Toast.LENGTH_SHORT);
                temp.show();
            }
        }
    }
}
