package com.example.dawid.mobileapp;

import android.app.Application;

/**
 * Created by Dawid on 03.12.2017.
 */

public class GlobalValue extends Application {
    private static String LoginGlobal, TokenGlobal;
    private static final String ipAdres = "192.168.137.1:8000";



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
}
