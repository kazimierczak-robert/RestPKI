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

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;

import javax.net.ssl.HttpsURLConnection;

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
                    int SenderID = objectJS.getInt("recipient_id");
                    Users user = GlobalValue.getUserFromID(SenderID);
                    String encTopic = objectJS.getString("enc_topic");
                    String encMessage = objectJS.getString("enc_message");
                    String sendDate = objectJS.getString("send_date");
                    String certificateID = objectJS.getString("certificate_id");
                    encTopic = CryptographyMethonds.Odszyfrowanie(encTopic, certificateID);
                    encMessage = CryptographyMethonds.Odszyfrowanie(encMessage, certificateID);
                    MessageListsGlobal.MessageInboxList.add(new Message(MessageID, user.getName() + " <" + user.getEmail()+ ">", encTopic, encMessage, TimeMethothds.getDateToMessage(sendDate)));

                }
            } catch (JSONException e) {
                e.printStackTrace();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        Intent intent = new Intent(activity, InboxReceiveActivity.class);
        activity.startActivity(intent);
        return  returnMessage;
    }

    public String getInboxMessage()
    {
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/refresh_inbox/";
        URL url;
        String response = "";
        try {
            url = new URL(requestURL);
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setReadTimeout(15000);
            conn.setConnectTimeout(15000);
            conn.setRequestProperty("Authorization", "Token "+GlobalValue.getTokenGlobal());
            conn.setRequestMethod("POST");
            conn.setDoInput(true);
            conn.setDoOutput(true);

            ArrayList<Message> messageList =  MessageListsGlobal.MessageOutboxList;
            Integer sizeList = MessageListsGlobal.MessageOutboxList.size();
            Log.d("co to", sizeList.toString());
            Log.d("co to1", messageList.get(sizeList-1).getID().toString());
            Uri.Builder builder = new Uri.Builder()
                    .appendQueryParameter("id", messageList.get(sizeList-1).getID().toString());

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
