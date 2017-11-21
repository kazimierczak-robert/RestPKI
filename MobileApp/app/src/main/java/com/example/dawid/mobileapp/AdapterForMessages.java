package com.example.dawid.mobileapp;

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

public class AdapterForMessages extends RecyclerView.Adapter {

    private ArrayList<Message> mMessages = new ArrayList<>();
    private RecyclerView mRecyclerView;

    private class MyViewHolder extends RecyclerView.ViewHolder {
        public TextView mUser;
        public TextView mDate;
        public TextView mTopic;
        public MyViewHolder(View pItem) {
            super(pItem);
            mUser= (TextView) pItem.findViewById(R.id.message_user);
            mDate = (TextView) pItem.findViewById(R.id.message_date);
            mTopic = (TextView) pItem.findViewById(R.id.message_topic);
            Log.d("testy","ile " + mMessages.size());
        }
    }

    public AdapterForMessages(ArrayList<Message> mMessages, RecyclerView pRecyclerView){
        this.mMessages = mMessages;
        mRecyclerView = pRecyclerView;
    }
    @Override
    public RecyclerView.ViewHolder onCreateViewHolder(ViewGroup viewGroup, int viewType) {
        final View view = LayoutInflater.from(viewGroup.getContext())
                .inflate(R.layout.messages_layout, viewGroup, false);

        view.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                new MessageActivity().execute("");
              /*  int positionToDelete = mRecyclerView.getChildAdapterPosition(v);
                mMessages.remove(positionToDelete);
                notifyItemRemoved(positionToDelete);*/
            }
        });
        return new MyViewHolder(view);
    }

    @Override
    public void onBindViewHolder(RecyclerView.ViewHolder viewHolder, final int i) {
        Log.d("testy","ileee " + mMessages.size());
        Message message = mMessages.get(i);
        ((MyViewHolder) viewHolder).mUser.setText(message.getUser());
        ((MyViewHolder) viewHolder).mDate.setText(message.getDate());
        ((MyViewHolder) viewHolder).mTopic.setText(message.getTopic());
    }

    @Override
    public int getItemCount() {
        Log.d("testy","iless " + mMessages.size());
        return mMessages.size();
    }
}
