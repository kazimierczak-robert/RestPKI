package com.example.dawid.mobileapp;

import android.app.Application;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Date;

/**
 * Created by Dawid on 03.12.2017.
 */

public class GlobalValue extends Application {
    private static String LoginGlobal;
    private static String TokenGlobal;
    private static String PublicCertificateGlobal;
    private static Integer IDEmployeeGlobal;
    private static Integer IDCertificateGlobal;
    private static String PublicKeyGlobal;
    private static String PrivateKeyGlobal;



    private static ArrayList<PrivateKeyObject> PrivateKeysList;
    private static final String ipAdres = "195.181.212.93"; //"192.168.137.1:8000";//
    private static Users UserSend;
    public static ArrayList<Users> UsersListGlobal;
    private static Date ExpirationCertificateDate;

    public static String getLoginGlobal() {
        return LoginGlobal;
    }

    public static void setLoginGlobal(String loginGlobal) {
        LoginGlobal = loginGlobal;
    }

    public static String getTokenGlobal() {
        return TokenGlobal;
    }

    public static void setTokenGlobal(String tokenGlobal) {
        TokenGlobal = tokenGlobal;
    }

    public static String getIpAdres() {
        return ipAdres;
    }
    public static String getPublicCertificateGlobal() {
        return PublicCertificateGlobal;
    }

    public static void setPublicCertificateGlobal(String publicCertificateGlobal) {
        PublicCertificateGlobal = publicCertificateGlobal;
    }

    public static Integer getIDEmployeeGlobal() {
        return IDEmployeeGlobal;
    }

    public static void setIDEmployeeGlobal(Integer IDEmploeeGlobal) {
        GlobalValue.IDEmployeeGlobal = IDEmploeeGlobal;
    }

    public static ArrayList<Users> getUsersListGlobal() {
        return UsersListGlobal;
    }

    public static void setUsersListGlobal(ArrayList<Users> usersListGlobal) {
        UsersListGlobal = usersListGlobal;
    }

    public static Users getUserSend() {
        return UserSend;
    }

    public static void setUserSend(Users userSend) {
        UserSend = userSend;
    }

    public static Integer getIDCertificateGlobal() {
        return IDCertificateGlobal;
    }

    public static void setIDCertificateGlobal(Integer IDCertificateGlobal) {
        GlobalValue.IDCertificateGlobal = IDCertificateGlobal;
    }

    public static Date getExpirationCertificateDate() {
        return ExpirationCertificateDate;
    }

    public static void setExpirationCertificateDate(Date expirationCertificateDate) {
        ExpirationCertificateDate = expirationCertificateDate;
    }
    public static Users getUserFromID(int ID)
    {
        for(int i = 0; i < UsersListGlobal.size(); i++)
        {
            Users u = UsersListGlobal.get(i);
            if(u.getID().equals(ID))
            {
                return u;
            }
        }
        return null;
    }
    public static String getPrivateKeyGlobal() {
        return PrivateKeyGlobal;
    }

    public static void setPrivateKeyGlobal(String privateKeyGlobal) {
        PrivateKeyGlobal = privateKeyGlobal;
    }
    public static String getPublicKeyGlobal() {
        return PublicKeyGlobal;
    }

    public static void setPublicKeyGlobal(String publicKeyGlobal) {
        PublicKeyGlobal = publicKeyGlobal;
    }
    public static ArrayList<PrivateKeyObject> getPrivateKeysList() {
        return PrivateKeysList;
    }

    public static void setPrivateKeysList(ArrayList<PrivateKeyObject> privateKeysList) {
        PrivateKeysList = privateKeysList;
    }
    public static void setNulls()
    {
        LoginGlobal = "";
        TokenGlobal = "";
        IDEmployeeGlobal = 0;
        PublicCertificateGlobal = "";
        UsersListGlobal= null;
        UserSend = null;
    }
}
