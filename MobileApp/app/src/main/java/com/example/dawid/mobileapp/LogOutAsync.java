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


    private String CheckData() {
        String returnMessage = "";
        String token = "";
            String wynik = laczenie();
            if (wynik != null) {
                try {
                    JSONObject jsonObj = new JSONObject(wynik);
                    token = jsonObj.getString("detail");
                } catch (JSONException e) {
                    e.printStackTrace();
                }
            }
        GlobalValue.setNulls();
        Intent intent = new Intent(activity, LoginActivity.class);
        activity.startActivity(intent);
        return returnMessage;


    }

    public String laczenie(){
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/logout/";
        URL url;
        String response = "";
        try {
            url = new URL(requestURL);
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setReadTimeout(15000);
            conn.setConnectTimeout(15000);
            conn.setRequestMethod("GET");
            conn.setRequestProperty("Authorization", "Token "+GlobalValue.getTokenGlobal());
            conn.connect();

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
