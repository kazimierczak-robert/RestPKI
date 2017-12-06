package com.example.dawid.mobileapp;

import android.app.Application;

import java.lang.reflect.Array;
import java.util.ArrayList;

/**
 * Created by Dawid on 03.12.2017.
 */

public class GlobalValue extends Application {
    private static String LoginGlobal;
    private static String TokenGlobal;
    private static String PublicCertificateGlobal;
    private static Integer IDEmployeeGlobal;
    private static final String ipAdres = "192.168.137.1:8000";



    private static ArrayList<Users> UsersListGlobal;


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
}
