package com.example.dawid.mobileapp;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.TextView;

import org.w3c.dom.Text;

public class MessageActivity extends AppCompatActivity {
    private TextView User;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_message);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        User = (TextView) findViewById(R.id.textViewUserReceiveMessage);

        Bundle b = getIntent().getExtras();
        String id = b.getString("id");
        User.setText(id);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
    }

}
