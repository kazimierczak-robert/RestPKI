package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.AsyncTask;
import android.support.constraint.solver.Goal;
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

public class SendMessageAsync extends AsyncTask<String, String, String> {

    private Activity activity;


    public SendMessageAsync(Activity activity)
    {
        this.activity = activity;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();
    }


    @Override
    protected String doInBackground(String... params) {
        return CheckData(params[0]);

    }



    @Override
    protected void onPostExecute(String s) {
        super.onPostExecute(s);

    }

    private String CheckData(String IDReason) {
        String returnMessage = "";


        String token = "";
        String wynik = send();
        if (wynik != null) {
            try {
                JSONObject jsonObj = new JSONObject(wynik);
                token = jsonObj.getString("status");
                if(token.equals("ok")) {
                  //  SaveCeriticate();
                    Intent intent = new Intent(activity, MenuActivity.class);
                    activity.startActivity(intent);
                    return returnMessage;
                }

            } catch (JSONException e) {
                e.printStackTrace();
            }


            Snackbar.make(activity.getCurrentFocus(), "Bład unieważnienia certyfikatu", Snackbar.LENGTH_LONG).show();
            return returnMessage;
        }
        return returnMessage;
    }

    public String send(){ // uniewaznienie certyfikatu
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/certificate/" + GlobalValue.getIDCertificateGlobal()+"/revoke/";
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
                    .appendQueryParameter("sender_id", GlobalValue.getIDEmployeeGlobal().toString())
                    .appendQueryParameter("recipient_id", GlobalValue.getUserSend().getID().toString())
                  /*  .appendQueryParameter("send_date", IDReason.toString())
                    .appendQueryParameter("enc_topic", IDReason.toString())
                    .appendQueryParameter("enc_message", IDReason.toString())
                    .appendQueryParameter("copy", IDReason.toString())*/;

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

