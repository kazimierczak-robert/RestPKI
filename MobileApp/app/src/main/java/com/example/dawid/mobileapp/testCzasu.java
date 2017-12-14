package com.example.dawid.mobileapp;

import android.icu.util.Calendar;
import android.os.Build;
import android.support.annotation.RequiresApi;
import android.util.Log;
import android.widget.DatePicker;
import android.widget.TimePicker;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.Instant;
import java.time.ZoneId;
import java.time.ZonedDateTime;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Date;

/**
 * Created by Dawid on 12.12.2017.
 */

public class testCzasu
{

    public static void testy(){
        Log.d("czas czasu", "data");

        SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss.SSSZ") ;
        Date now = new Date();
        Log.d("czas czasudr ", dateFormat.format(now));
        String date = "2017-12-14T14:16:02.754+0000";
        String asda = "2017-12-14T13:33:16.179401+01:00";
        try {
            Date nowa = dateFormat.parse(date);
            Log.d("czas czasudr123 ", dateFormat.format(nowa));
            Log.d("czas", String.valueOf(nowa.compareTo(now)));
            if(nowa.after(now))
            {
            Log.d("czas", "tutaj");
            }
            if(nowa.before(now))
            {
                Log.d("czas", "drugi");
            }

        } catch (ParseException e) {
            e.printStackTrace();
        }



        /*  DatePicker dp = (DatePicker)findViewById(R.id.datePickerDelayed);
        TimePicker tp = (TimePicker)findViewById(R.id.timePickerDel);
        Date myDbDate = new Date(dp.getYear(), dp.getMonth(), dp.getDayOfMonth(), tp.getCurrentHour(), tp.getCurrentMinute());
        Calendar calendar =*/
    }
}
