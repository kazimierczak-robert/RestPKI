package com.example.dawid.mobileapp;

import android.app.Application;

import java.util.ArrayList;

/**
 * Created by Dawid on 14.12.2017.
 */

public class MessageListsGlobal extends Application {
    public static ArrayList<Message> MessageInboxList = new ArrayList<>();
    public static ArrayList<Message> MessageOutboxList = new ArrayList<>();
}
