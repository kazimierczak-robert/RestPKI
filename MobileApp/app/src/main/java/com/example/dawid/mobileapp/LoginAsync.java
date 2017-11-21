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

public class LoginAsync extends AsyncTask<String, String, String> {

    private Activity activity;
    private ProgressBar progressBar;
    private EditText login, password;

    public LoginAsync(Activity activity)
    {
        this.activity = activity;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();
        progressBar = (ProgressBar) activity.findViewById(R.id.progressBarLogin);
        progressBar.setVisibility(View.VISIBLE);
        login = (EditText) activity.findViewById(R.id.loginLogin);
        password = (EditText) activity.findViewById(R.id.passwordLogin);
    }


    @Override
    protected String doInBackground(String... params) {
        return CheckData();

    }



    @Override
    protected void onPostExecute(String s) {
        super.onPostExecute(s);
        progressBar.setVisibility(View.INVISIBLE);

    }

    private String CheckData()
    {
        String returnMessage = "";
        String log = login.getText().toString();
        String pass = password.getText().toString();

        String a = "abc";
       /* for (int i = 0; i < 8000; i++)
            a += "abc";
*/
        if(log.isEmpty() || pass.isEmpty())
        {
            returnMessage += "Wszystkie pola muszą być uzupełnione";
            Snackbar.make(activity.getCurrentFocus(), returnMessage, Snackbar.LENGTH_LONG).show();
            return  returnMessage;
        }

        Intent intent = new Intent(activity, MenuActivity.class);
        activity.startActivity(intent);
        return  returnMessage;
    }
}

