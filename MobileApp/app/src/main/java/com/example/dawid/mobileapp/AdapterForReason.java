package com.example.dawid.mobileapp;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import java.util.ArrayList;

/**
 * Created by Dawid on 19.11.2017.
 */

public class AdapterForReason extends RecyclerView.Adapter {

    private ArrayList<ReasonOverturn> mReasonList = new ArrayList<>();
    private RecyclerView mRecyclerView;
    private Activity contextActivity;
    private class MyViewHolder extends RecyclerView.ViewHolder {
        public TextView mReason;

        public MyViewHolder(View pItem) {
            super(pItem);
            mReason= (TextView) pItem.findViewById(R.id.cancelReason);
        }
    }

    public AdapterForReason(Activity activity, ArrayList<ReasonOverturn> mMessages, RecyclerView pRecyclerView){
        this.mReasonList = mMessages;
        mRecyclerView = pRecyclerView;
        contextActivity = activity;
    }
    @Override
    public RecyclerView.ViewHolder onCreateViewHolder(final ViewGroup viewGroup, int viewType) {
        final View view = LayoutInflater.from(viewGroup.getContext())
                .inflate(R.layout.cancel_layout, viewGroup, false);

        view.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int positionToShow = mRecyclerView.getChildAdapterPosition(v);
                Intent intent = new Intent(contextActivity, IsSureActivity.class);
                intent.putExtra("IDReason", mReasonList.get(positionToShow).getID());
                contextActivity.startActivity(intent);

            }
        });
        return new MyViewHolder(view);
    }

    @Override
    public void onBindViewHolder(RecyclerView.ViewHolder viewHolder, final int i) {
        ReasonOverturn message = mReasonList.get(i);
        ((MyViewHolder) viewHolder).mReason.setText(message.getDescripiton());

    }

    @Override
    public int getItemCount() {
        return mReasonList.size();
    }
}
