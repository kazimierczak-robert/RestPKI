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

public class LogOutAsync extends AsyncTask<String, String, String>{
    private Activity activity;
    public LogOutAsync(Activity activity)
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

        Intent intent = new Intent(activity, LoginActivity.class);
        activity.startActivity(intent);
        return  returnMessage;
    }
}
