package com.example.dawid.mobileapp;

import android.app.Activity;
import android.os.AsyncTask;
import android.view.View;
import android.widget.EditText;
import android.widget.ProgressBar;

import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Date;

import javax.net.ssl.HttpsURLConnection;

/**
 * Created by Dawid on 17.12.2017.
 */

public class RequestToCertificate extends AsyncTask<String, String, String> {

    private Activity activity;
    public RequestToCertificate(Activity activity)
    {
        this.activity = activity;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();

    }


    @Override
    protected String doInBackground(String... params) {
        return SaveCeriticate();

    }



    @Override
    protected void onPostExecute(String s) {
        super.onPostExecute(s);


    }


    public String getCerttificate()
    {
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/cert/";
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

    public String SaveCeriticate()
    {
        String wynik = getCerttificate();
        String certificate;
        Integer IDemployee;
        String DateExpiration;
        if (wynik != null) {
            try {
                JSONObject jsonObj = new JSONObject(wynik);
                DateExpiration =jsonObj.getString("expiration_date");
                Date ExpirationDate = TimeMethothds.getDateFromString(DateExpiration);
                GlobalValue.setExpirationCertificateDate(ExpirationDate);
                certificate = jsonObj.getString("cert");
                GlobalValue.setPublicCertificateGlobal(certificate);
                IDemployee = jsonObj.getInt("employee_id");
                GlobalValue.setIDEmployeeGlobal(IDemployee);
                GlobalValue.setIDCertificateGlobal(jsonObj.getInt("id"));
            } catch (JSONException e) {
                e.printStackTrace();
            }  catch (Exception e) {
                e.printStackTrace();
            }
        }
        return "a";
    }
}
