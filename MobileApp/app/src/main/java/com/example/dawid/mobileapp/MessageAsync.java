package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.os.AsyncTask;
import android.support.design.widget.Snackbar;
import android.view.View;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.TextView;

import org.w3c.dom.Text;

/**
 * Created by Dawid on 28.10.2017.
 */

public class MessageAsync extends AsyncTask<String, String, String>{
    private Activity activity;
    private TextView User;
    private TextView Date;
    private TextView Topic;
    private TextView MessageContent;
    public MessageAsync(Activity activity)
    {

        this.activity = activity;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();

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

        Intent intent = new Intent(activity, MessageActivity.class);
        intent.putExtra("id", "Kowalski");
        activity.startActivity(intent);
        return  returnMessage;
    }
}
