package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.os.AsyncTask;
import android.support.design.widget.Snackbar;
import android.view.View;
import android.widget.EditText;
import android.widget.ProgressBar;

/**
 * Created by Dawid on 28.10.2017.
 */

public class OutboxAsync extends AsyncTask<String, String, String>{
    private Activity activity;
    private EditText UserToSend, Topic, Content;
    public OutboxAsync(Activity activity)
    {

        this.activity = activity;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();
        UserToSend = (EditText) activity.findViewById(R.id.editTextInboxSearchUser);
        Topic = (EditText) activity.findViewById(R.id.editTextInboxTopic);
        Content = (EditText) activity.findViewById(R.id.editTextInboxMessageContent);
    }


    @Override
    protected String doInBackground(String... params) {
        return CheckData();

    }



    @Override
    protected void onPostExecute(String s) {
        super.onPostExecute(s);
    }

    private String CheckData()
    {
        String returnMessage = "";
        String user = UserToSend.getText().toString();
        String topic = Topic.getText().toString();
        String content = Content.getText().toString();

        if(user.isEmpty() || topic.isEmpty() || content.isEmpty())
        {
            Snackbar.make(activity.getCurrentFocus(), "Wszystkie pola muszą być uzupełnione", Snackbar.LENGTH_LONG).show();
            return returnMessage;
        }

        Intent intent = new Intent(activity, OutboxActivity.class);
        activity.startActivity(intent);
        return  returnMessage;
    }
}
