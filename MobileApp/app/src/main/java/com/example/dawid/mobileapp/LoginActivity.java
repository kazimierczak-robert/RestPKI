package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class LoginActivity extends Activity {
    private EditText login, password;
    private int backButtonCount = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        login = (EditText) findViewById(R.id.loginLogin);
        password= (EditText) findViewById(R.id.passwordLogin);
    }



    @Override
    public void onBackPressed()
    {
        if(backButtonCount >= 1)
        {
            Intent intent = new Intent(Intent.ACTION_MAIN);
            intent.addCategory(Intent.CATEGORY_HOME);
            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            startActivity(intent);
        }
        else
        {
            Toast.makeText(this, "Naciśnij jeszcze raz, aby zamknąć aplikację.", Toast.LENGTH_SHORT).show();
            backButtonCount++;
        }
    }
    public void SignIn(View view)
    {
        new LoginAsync(this).execute("");
    }
}
