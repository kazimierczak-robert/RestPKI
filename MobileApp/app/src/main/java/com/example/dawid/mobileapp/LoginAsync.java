package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.AsyncTask;
import android.support.design.widget.Snackbar;
import android.telephony.gsm.GsmCellLocation;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.ProgressBar;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.UnsupportedEncodingException;
import java.net.HttpURLConnection;
import java.net.URL;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.security.PublicKey;
import java.security.cert.CertificateException;
import java.security.spec.InvalidKeySpecException;
import java.sql.Time;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.concurrent.ExecutionException;

import javax.microedition.khronos.opengles.GL;
import javax.net.ssl.HttpsURLConnection;
import javax.security.cert.CertificateExpiredException;
import javax.security.cert.CertificateNotYetValidException;

/**
 * Created by Dawid on 28.10.2017.
 */

public class LoginAsync extends AsyncTask<String, String, String> {

    private Activity activity;
    private ProgressBar progressBar;
    private EditText email, password;

    public LoginAsync(Activity activity)
    {
        this.activity = activity;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();
        progressBar = (ProgressBar) activity.findViewById(R.id.progressBarLogin);
        progressBar.setVisibility(View.VISIBLE);
        email = (EditText) activity.findViewById(R.id.emailLogin);
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

    public String computeHash(String input) throws NoSuchAlgorithmException, UnsupportedEncodingException {
        MessageDigest digest = MessageDigest.getInstance("SHA-256");
        digest.reset();

        byte[] byteData = digest.digest(input.getBytes("UTF-8"));
        StringBuffer sb = new StringBuffer();

        for (int i = 0; i < byteData.length; i++){
            sb.append(Integer.toString((byteData[i] & 0xff) + 0x100, 16).substring(1));
        }
        return sb.toString();
    }

    private String CheckData() {
        String returnMessage = "";
        String log = email.getText().toString();
        String pass = password.getText().toString();


        if (log.isEmpty() || pass.isEmpty()) {
            returnMessage += "Wszystkie pola muszą być uzupełnione";
            Snackbar.make(activity.getCurrentFocus(), returnMessage, Snackbar.LENGTH_LONG).show();
            return returnMessage;
        } else {
            String token = "";
            String wynik = signin();
            if (wynik != null) {
                try {
                    JSONObject jsonObj = new JSONObject(wynik);
                    token = jsonObj.getString("token");
                    GlobalValue.setTokenGlobal(token);
                    SaveCeriticate();
                    GlobalValue.setLoginGlobal(log);
                    SavePrivateKey();
                    SavePrivateKeys();
                    getEmployee();
                    SaveOtherCert();
                    getInboxMessage();
                    getInboxMessageReceive();
                    Intent intent = new Intent(activity, MenuActivity.class);
                    activity.startActivity(intent);
                    return returnMessage;
                } catch (JSONException e) {
                    e.printStackTrace();
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }

            Snackbar.make(activity.getCurrentFocus(), "Zły login lub złe hasło", Snackbar.LENGTH_LONG).show();
            return returnMessage;
        }
    }


        public String signin(){ // logowanie
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/login/";
        URL url;
        String response = "";
        try {
            url = new URL(requestURL);
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setReadTimeout(15000);
            conn.setConnectTimeout(15000);
            conn.setRequestMethod("POST");
            conn.setDoInput(true);
            conn.setDoOutput(true);


            Uri.Builder builder = new Uri.Builder()
                    .appendQueryParameter("username", email.getText().toString())
                    .appendQueryParameter("password", password.getText().toString());

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

    public void SaveCeriticate()
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
    }

    public String getPrivateKey()
    {
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/certificate/" + GlobalValue.getIDCertificateGlobal() + "/get_key/";
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

    public void SavePrivateKey()
    {
        String wynik = getPrivateKey();
        String certificate;

        String PrivateKeyl;
        if (wynik != null) {
            try {
                JSONObject jsonObj = new JSONObject(wynik);

            PrivateKeyl =jsonObj.getString("privatekey");
                Log.d("privatekeees", PrivateKeyl);
                GlobalValue.setPrivateKeyGlobal(PrivateKeyl);


            } catch (JSONException e) {
                e.printStackTrace();
            }  catch (Exception e) {
                e.printStackTrace();
            }
        }
    }


    public String getPrivateKeys()
    {
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/get_employee_keys/";
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


            Uri.Builder builder = new Uri.Builder()
                    .appendQueryParameter("id", GlobalValue.getIDEmployeeGlobal().toString());

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

    public void SavePrivateKeys()
    {
        String returnMessage = "";
        String token = "";
        ArrayList<PrivateKeyObject> privateKeysList =  new ArrayList<>();
        String wynik = getPrivateKeys();
        if (wynik != null) {
            JSONObject jsonObj = null;
            int counter =0;
            try {
                JSONArray docs = new JSONArray(wynik);

                for(int i = 0; i < docs.length(); i++)
                {
                    Log.d("privateke", wynik);
                    JSONObject objectJS = docs.getJSONObject(i);
                    String PrivateKey = objectJS.getString("privatekey");
                    String ID = objectJS.getString("cert_id");
                    privateKeysList.add(new PrivateKeyObject(ID, PrivateKey));
                }
                GlobalValue.setPrivateKeysList(privateKeysList);


            } catch (JSONException e) {
                e.printStackTrace();
            }
        }
for (PrivateKeyObject x : GlobalValue.getPrivateKeysList())
        Log.d("priavetkeyss123, ", x.getCertyficate());

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

    private static void getEmployee() {
        String returnMessage = "";
        String token = "";
        ArrayList<Users> users = new ArrayList<>();
        String wynik = getEmployeeSendAsync();
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



            } catch (JSONException e) {
                e.printStackTrace();
            }
        }

    }

    public static String getEmployeeSendAsync(){
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

    private static void getInboxMessageReceive()
    {
        String returnMessage = "";
        String wynik = getInboxMessageReceiveAsync();
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
    }

    public static String getInboxMessageReceiveAsync()
    {
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

    private static void getInboxMessage()
    {
        String returnMessage = "";
        String wynik = getInboxMessageAsync();
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
                    Users user = GlobalValue.getUserFromID(SenderID);
                    String encTopic = objectJS.getString("enc_topic");
                    String encMessage = objectJS.getString("enc_message");
                    String sendDate = objectJS.getString("send_date");
                    String certificateID = objectJS.getString("certificate_id");
                    encTopic = CryptographyMethonds.Odszyfrowanie(encTopic, certificateID);
                    encMessage = CryptographyMethonds.Odszyfrowanie(encMessage, certificateID);
                    MessageListsGlobal.MessageOutboxList.add(new Message(MessageID, user.getName() + " <" + user.getEmail()+ ">", encTopic, encMessage, TimeMethothds.getDateToMessage(sendDate)));

                }
            } catch (JSONException e) {
                e.printStackTrace();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    public static String getInboxMessageAsync()
    {
        String requestURL = "http://"+ GlobalValue.getIpAdres() + "/api/inbox/";
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

