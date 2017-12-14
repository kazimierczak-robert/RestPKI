package com.example.dawid.mobileapp;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.TextView;

public class OutboxActivity extends AppCompatActivity {
    private TextView UserSend;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_outbox);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        UserSend = (TextView) findViewById(R.id.editTextInboxSearchUser);
        UserSend.setText(GlobalValue.getUserSend().getName() + " <" + GlobalValue.getUserSend().getEmail() + ">");
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
    }

    public void SendMessage(View view) {
        new SendMessageAsync(this).execute("");
    }
}
