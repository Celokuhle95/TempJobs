package com.temporaryjobs.temporaryjobs;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;

/**
 * Created by hp on 3/30/2016.
 */
public class SplashScreen extends Activity
{
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.splash);

        Thread timerThread = new Thread()
        {
            public void run()
            {
                try{
                    sleep(3000);
                }
                catch (InterruptedException e)
                {
                    e.printStackTrace();
                }
                finally {
                    Intent intent = new Intent(SplashScreen.this, MainActivity.class);
                    startActivity(intent);
                }
            }
        };
        timerThread.start();
    }

    protected void onPause()
    {
        super.onPause();
        finish();
    }

}
