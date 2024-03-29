package com.example.dawid.mobileapp;

import android.util.Log;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.TimeZone;

/**
 * Created by Dawid on 14.12.2017.
 */

public class TimeMethothds {
    private static SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ssZ") ;

    public static Date getDateFromString(String date)
    {
        dateFormat.setTimeZone(TimeZone.getTimeZone("Europe/Zagreb"));
        try {
            Date end = dateFormat.parse(date);
            return end;
        } catch (ParseException e) {
            e.printStackTrace();
        }
        return null;
    }
    public static String getDateNowToString()
    {
        dateFormat.setTimeZone(TimeZone.getTimeZone("Europe/Zagreb"));
        Date now = new Date();
        return dateFormat.format(now);
    }
    public static String getDateToMessage(String dateView)
    {
        dateFormat.setTimeZone(TimeZone.getTimeZone("Europe/Zagreb"));

        String year = dateView.substring(0, 4);
        String month = dateView.substring(5, 7);
        String day = dateView.substring(8, 10);
        String time = dateView.substring(11,19);
        return day + "." + month + "."+year + "  " + time;
    }
}
