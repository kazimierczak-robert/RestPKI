package com.example.dawid.mobileapp;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class MenuActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);
    }

    @Override
    public void onBackPressed() {

    }


    public void LogOut(View view){
        new LogOutAsync(this).execute("");
    }

    public void Outbox(View view)
    {

         new OutboxAsync(this).execute("");
    }

    public void Inbox(View view)
    {
        new InboxAsync(this).execute("");
    }

    public void Settings(View view){
        Intent intent = new Intent(this, SettingsActivity.class);
        this.startActivity(intent);
    }
}
