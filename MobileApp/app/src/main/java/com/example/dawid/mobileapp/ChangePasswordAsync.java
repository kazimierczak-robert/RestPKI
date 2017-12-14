package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.AsyncTask;
import android.support.design.widget.Snackbar;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.ProgressBar;

import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

/**
 * Created by Dawid on 28.10.2017.
 */

public class ChangePasswordAsync extends AsyncTask<String, String, String> {

    private Activity activity;
    private EditText actualPassword, newPassword, repeatPassword;

    public ChangePasswordAsync(Activity activity)
    {
        this.activity = activity;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();
        actualPassword = (EditText) activity.findViewById(R.id.editTextActualPassword);
        newPassword = (EditText) activity.findViewById(R.id.editTextNewPassword);
        repeatPassword = (EditText) activity.findViewById(R.id.editTextRepeatNewPassword);
    }


    @Override
    protected String doInBackground(String... params) {
        return CheckData();

    }



    @Override
    protected void onPostExecute(String s) {
        super.onPostExecute(s);

    }

    private String CheckData() {
        String returnMessage = "";
        String acPassword = actualPassword.getText().toString();
        String nePassword = newPassword.getText().toString();
        String rePassword = repeatPassword.getText().toString();

        if(acPassword.isEmpty() || nePassword.isEmpty() || rePassword.isEmpty())
        {
            Snackbar.make(activity.getCurrentFocus(), "Wszystkie pola muszą być uzupełnione", Snackbar.LENGTH_LONG).show();
            return returnMessage;
        }
        if(!nePassword.equals(rePassword))
        {
            Snackbar.make(activity.getCurrentFocus(), "Hasła nie są takie same", Snackbar.LENGTH_LONG).show();
            return returnMessage;
        }
        String token = "";
        String wynik = changePassword(acPassword, nePassword);
        Log.d("zmaian", wynik);
        if (wynik != null) {
            try {
                JSONObject jsonObj = new JSONObject(wynik);
                token = jsonObj.getString("status");
                if(token.equals("ok")) {
                    new LogOutAsync(activity).execute();
                    return returnMessage;
                }
                else if(token.equals("fail"))
                {
                    Snackbar.make(activity.getCurrentFocus(), "Podano nieprawidłowe aktualne hasło", Snackbar.LENGTH_LONG).show();
                    return returnMessage;
                }

            } catch (JSONException e) {
                e.printStackTrace();
            }


            Snackbar.make(activity.getCurrentFocus(), "Hasło nie zostało zmienione. Proszę skontaktować się z administratorem", Snackbar.LENGTH_LONG).show();
            return returnMessage;
        }
        return returnMessage;
    }

    public String changePassword(String acPassword, String nePassword){ // zmiana hasla
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/changepass/";
        URL url;
        String response = "";
        try {
            url = new URL(requestURL);
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setReadTimeout(15000);
            conn.setConnectTimeout(15000);
            conn.setRequestMethod("POST");
            conn.setRequestProperty("Authorization", "Token "+GlobalValue.getTokenGlobal());
            conn.setDoInput(true);
            conn.setDoOutput(true);


            Uri.Builder builder = new Uri.Builder()
                    .appendQueryParameter("username", GlobalValue.getLoginGlobal() )
                    .appendQueryParameter("oldpass", acPassword)
                    .appendQueryParameter("newpass", nePassword);

            String query = builder.build().getEncodedQuery();

            OutputStream os = conn.getOutputStream();
            BufferedWriter writer = new BufferedWriter(
                    new OutputStreamWriter(os, "UTF-8"));

            writer.write(query);
            writer.flush();
            writer.close();
            os.close();
            int responseCode=conn.getResponseCode();

            if (responseCode == HttpsURLConnection.HTTP_OK) {
                String line;
                BufferedReader br=new BufferedReader(new InputStreamReader(conn.getInputStream()));
                while ((line=br.readLine()) != null) {
                    response+=line;
                }
            }
            else {
                response="";

            }
        } catch (Exception e) {
            e.printStackTrace();
        }

        return response;
    }


}

