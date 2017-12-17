package com.example.dawid.mobileapp;

import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.View;
import android.widget.Toast;

import java.util.ArrayList;



public class SettingsActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);


        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
    }

    public void cancelCertificate(View view){
        Intent intent = new Intent(this, CancelCertActivity.class);
        this.startActivity(intent);
    }

    public void changePasswordView(View view) {
        Intent intent = new Intent(this, ChangePasswordActivity.class);
        this.startActivity(intent);
    }
    public void RequestToCertificate1(View view)
    {
        new RequestToCertificate(this).execute();
    }
}
