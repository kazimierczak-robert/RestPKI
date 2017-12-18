package com.example.dawid.mobileapp;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.DefaultItemAnimator;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.TextView;

import java.util.ArrayList;

public class CancelCertActivity extends AppCompatActivity {
    private TextView Reason;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cancel_cert);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        RecyclerView recyclerView = (RecyclerView) findViewById(R.id.recyclerViewMessagesCancelReason);
        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        recyclerView.setItemAnimator(new DefaultItemAnimator());

        ArrayList<ReasonOverturn> messages = new ArrayList<>();

        messages.add(new ReasonOverturn(1, "Uaktualnienie certyfikatu"));
        messages.add(new ReasonOverturn(2, "Kradzież klucza prywatnego"));
        messages.add(new ReasonOverturn(3, "Zwolnienie pracownika"));
        messages.add(new ReasonOverturn(4, "Błąd w certyfikacie"));
        messages.add(new ReasonOverturn(5, "Zmiana informacji w certyfikacie"));
        messages.add(new ReasonOverturn(6, "Inny"));
        recyclerView.setAdapter(new AdapterForReason(this, messages, recyclerView));

    }

}
