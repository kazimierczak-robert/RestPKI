package com.example.dawid.mobileapp;

import android.app.Activity;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.View;
import android.widget.TextView;

import org.w3c.dom.Text;

public class MessageActivity extends AppCompatActivity {
    private TextView User;
    private TextView Date;
    private TextView Topic;
    private TextView Content;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_message);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        User = (TextView) findViewById(R.id.textViewReceiveMessageUser);
        Date = (TextView) findViewById(R.id.textViewReceiveMessageDate);
        Topic = (TextView) findViewById(R.id.textViewReceiveMessageTopic);
        Content = (TextView) findViewById(R.id.textViewReceiveMessageContent);
        Bundle b = getIntent().getExtras();
        String user = b.getString("user");
        User.setText(user);
        String date = b.getString("date");
        Date.setText(date);
        String topic = b.getString("topic");
        Topic.setText(topic);
        String content = b.getString("content");
        Content.setText(content);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);

    }

}
