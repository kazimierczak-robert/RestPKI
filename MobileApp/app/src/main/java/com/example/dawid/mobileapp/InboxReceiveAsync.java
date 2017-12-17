package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.os.AsyncTask;
import android.support.design.widget.Snackbar;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.ProgressBar;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.Date;
import java.util.concurrent.TimeoutException;

import javax.net.ssl.HttpsURLConnection;

import kotlin.collections.GroupingKt;

/**
 * Created by Dawid on 28.10.2017.
 */

public class InboxReceiveAsync extends AsyncTask<String, String, String>{
    private Activity activity;
    public InboxReceiveAsync(Activity activity)
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
        String wynik = getInboxMessage();
        ArrayList<Message> messages = new ArrayList<>();
        if(wynik !=null)
        {
            JSONObject jsonObj = null;

            try {
                JSONArray docs = new JSONArray(wynik);
                for(int i = 0; i < docs.length(); i++)
                {
                    JSONObject objectJS = docs.getJSONObject(i);
                    int MessageID = objectJS.getInt("id");
                    int SenderID = objectJS.getInt("sender_id");
                    String userName = GlobalValue.UsersListGlobal.get(SenderID).getName() + " <" + GlobalValue.UsersListGlobal.get(SenderID).getEmail() + ">";
                    String encTopic = objectJS.getString("enc_topic");
                    String encMessage = objectJS.getString("enc_message");
                    String sendDate = objectJS.getString("send_date");

                    Log.d("odszy", "porzed");
                  //  encTopic = testCzasu.Odszyfrowanie(encTopic);
                    Log.d("odszy", "po");
                    MessageListsGlobal.MessageInboxList.add(new Message(MessageID, userName, encTopic, encMessage, TimeMethothds.getDateToMessage(sendDate)));

                }
            } catch (JSONException e) {
                e.printStackTrace();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
      /*  Intent intent = new Intent(activity, InboxActivity.class);
        activity.startActivity(intent);*/
        return  returnMessage;
    }

    public String getInboxMessage()
    {
        Log.d("wiadomosci wyslane", "tk");
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/outbox/";
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
