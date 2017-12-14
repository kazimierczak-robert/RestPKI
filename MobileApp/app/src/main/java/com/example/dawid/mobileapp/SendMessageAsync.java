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
import java.util.Date;

import javax.net.ssl.HttpsURLConnection;

/**
 * Created by Dawid on 28.10.2017.
 */

public class SendMessageAsync extends AsyncTask<String, String, String> {

    private Activity activity;
    private EditText UserToSend, Topic, Content;

    public SendMessageAsync(Activity activity)
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
        return CheckData(params[0]);

    }



    @Override
    protected void onPostExecute(String s) {
        super.onPostExecute(s);

    }

    private String CheckData(String IDReason) {
        String returnMessage = "";
        String user = UserToSend.getText().toString();
        String topic = Topic.getText().toString();
        String content = Content.getText().toString();

        if(user.isEmpty() || topic.isEmpty() || content.isEmpty())
        {
            Snackbar.make(activity.getCurrentFocus(), "Wszystkie pola muszą być uzupełnione", Snackbar.LENGTH_LONG).show();
            return returnMessage;
        }

        String token = "";
        String wynik = sendCopy(topic, content);
        String wynik1 = sendNotCopy(topic, content);
        if (wynik != null) {
            try {
                JSONObject jsonObj = new JSONObject(wynik);
                token = jsonObj.getString("recipient_id");
                if(token.equals(GlobalValue.getUserSend().getID().toString())) {

                    Snackbar.make(activity.getCurrentFocus(), "Wiadomość została wysłana", Snackbar.LENGTH_LONG).show();
                    return returnMessage;
                }

            } catch (JSONException e) {
                e.printStackTrace();
            }


            Snackbar.make(activity.getCurrentFocus(), "Bład wysłania wiadomości", Snackbar.LENGTH_LONG).show();
            return returnMessage;
        }
        return returnMessage;
    }

    public String sendCopy(String topic, String content){ // uniewaznienie certyfikatu
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/message/";
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
                   .appendQueryParameter("send_date", TimeMethothds.getDateNowToString())
                    .appendQueryParameter("enc_topic", topic)
                    .appendQueryParameter("enc_message", content)
                    .appendQueryParameter("copy", "1");

            String query = builder.build().getEncodedQuery();

            OutputStream os = conn.getOutputStream();
            BufferedWriter writer = new BufferedWriter(
                    new OutputStreamWriter(os, "UTF-8"));

            writer.write(query);
            writer.flush();
            writer.close();
            os.close();
            int responseCode=conn.getResponseCode();

            if (responseCode == HttpsURLConnection.HTTP_CREATED) {
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

    public String sendNotCopy(String topic, String content){ // uniewaznienie certyfikatu
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/message/";
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
                    .appendQueryParameter("send_date", TimeMethothds.getDateNowToString())
                    .appendQueryParameter("enc_topic", topic)
                    .appendQueryParameter("enc_message", content)
                    .appendQueryParameter("copy", "0");

            String query = builder.build().getEncodedQuery();

            OutputStream os = conn.getOutputStream();
            BufferedWriter writer = new BufferedWriter(
                    new OutputStreamWriter(os, "UTF-8"));

            writer.write(query);
            writer.flush();
            writer.close();
            os.close();
            int responseCode=conn.getResponseCode();

            if (responseCode == HttpsURLConnection.HTTP_CREATED) {
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

