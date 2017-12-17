package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.AsyncTask;
import android.support.design.widget.Snackbar;
import android.util.Log;
import android.view.Menu;
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

public class SearchAsync extends AsyncTask<String, String, String>{
    private Activity activity;
    public SearchAsync(Activity activity)
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
        ArrayList<Users> users = new ArrayList<>();
        String wynik = laczenie();
        if (wynik != null) {
            JSONObject jsonObj = null;
            int counter =0;
            try {
                JSONArray docs = new JSONArray(wynik);

                for(int i = 0; i < docs.length(); i++)
                {
                    JSONObject objectJS = docs.getJSONObject(i);
                    int UserID = objectJS.getInt("id");
                    if(UserID == GlobalValue.getIDEmployeeGlobal()) {
                        continue;
                    }
                    String name = objectJS.getString("name");
                    String surname = objectJS.getString("surname");
                    String company_email = objectJS.getString("company_email");
                    users.add(counter, new Users(name + " " + surname, company_email, UserID));
                    counter++;
                }
                GlobalValue.setUsersListGlobal(users);
                SaveOtherCert();
                Intent intent = new Intent(activity, SearchActivity.class);
                activity.startActivity(intent);
                return returnMessage;

            } catch (JSONException e) {
                e.printStackTrace();
            }
        }

        Intent intent = new Intent(activity, MenuActivity.class);
        activity.startActivity(intent);
        return returnMessage;


    }

    public String laczenie(){
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/employee/";
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

    public String getOtherCert(Integer id)
    {
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/employee/" + id.toString() + "/cert/";
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

    public void SaveOtherCert()
    {
        String returnMessage = "";
        String token = "";

        ArrayList<Users> users = GlobalValue.getUsersListGlobal();
        for(int i = 0; i < users.size(); i++)
        {
            String wynik = getOtherCert(users.get(i).getID());
            if (wynik != null) {
                try {
                    JSONObject jsonObj = new JSONObject(wynik);

                    String cert =jsonObj.getString("cert");
                    String id = jsonObj.getString("id");
                    users.get(i).setCert(cert);
                    users.get(i).setCertID(id);
                } catch (JSONException e) {
                    e.printStackTrace();
                }  catch (Exception e) {
                    e.printStackTrace();
                }

            }
        }
        GlobalValue.setUsersListGlobal(users);


    }

}
