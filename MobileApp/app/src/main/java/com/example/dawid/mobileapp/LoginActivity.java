package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class LoginActivity extends Activity {
    private EditText login, password;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        login = (EditText) findViewById(R.id.loginLogin);
        password= (EditText) findViewById(R.id.passwordLogin);
    }

    public void SignIn(View view)
    {

        new LoginAsync(this).execute("");


    }
}
