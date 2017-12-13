package com.example.dawid.mobileapp;

import android.icu.util.Calendar;
import android.os.Build;
import android.support.annotation.RequiresApi;
import android.util.Log;

import java.text.SimpleDateFormat;
import java.time.Instant;
import java.time.ZoneId;
import java.time.ZonedDateTime;
import java.time.format.DateTimeFormatter;

/**
 * Created by Dawid on 12.12.2017.
 */

public class testCzasu
{

    public static void testy(){

        SimpleDateFormat databaseDateFormate = new SimpleDateFormat("yyyy-MM-dd");
        SimpleDateFormat sdf1 = new SimpleDateFormat("dd.MM.yy");
        SimpleDateFormat dr = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss.SSSZ");
        Log.d("czas czasu", sdf1.toString());
        Log.d("czas czasudr ", dr.toString());

    }
}
