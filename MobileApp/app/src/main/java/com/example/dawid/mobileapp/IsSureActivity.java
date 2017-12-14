package com.example.dawid.mobileapp;

import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;

public class IsSureActivity extends AppCompatActivity {
    private int IDReason;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_is_sure);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        Bundle b = getIntent().getExtras();
        IDReason = b.getInt("IDReason");

        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
    }

    public void exitCancelCert(View view) {
        Intent intent = new Intent(this, SettingsActivity.class);
        this.startActivity(intent);
    }

    public void cancelCert(View view) {
        new CancelCertAsync(this).execute(IDReason);
    }
}
