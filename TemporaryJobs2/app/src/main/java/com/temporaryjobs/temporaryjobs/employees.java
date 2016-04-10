package com.temporaryjobs.temporaryjobs;

import android.app.Activity;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.TextView;

/**
 * Created by hp on 4/2/2016.
 */
public class employees extends Activity
{
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.employees);
        String username = getIntent().getStringExtra("Username");


        TextView tv = (TextView) findViewById(R.id.TVusername);
        tv.setText(username);
    }
}
