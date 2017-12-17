package com.example.dawid.mobileapp;

import android.app.Activity;
import android.app.SearchManager;
import android.content.Context;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v4.view.MenuItemCompat;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.support.v7.widget.SearchView;
import android.support.v7.widget.Toolbar;
import android.text.Spannable;
import android.text.style.ForegroundColorSpan;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;
import java.util.Locale;

import javax.microedition.khronos.opengles.GL;

public class SearchActivity extends AppCompatActivity implements SearchView.OnQueryTextListener {
    private Activity contextActivity;
    RecyclerView recyclerView;
    RecyclerviewAdapter myRecAdapter;
    List<Users> list;
    String searchString="";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);


        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        Log.d("co to jest", "przed polaczneiem");
        list = GlobalValue.getUsersListGlobal();
        // Recyclerview
        recyclerView = (RecyclerView) findViewById(R.id.recyclerview);
        recyclerView.setHasFixedSize(true);
        // Adapter
        myRecAdapter = new RecyclerviewAdapter(list, SearchActivity.this);
        recyclerView.setLayoutManager(new LinearLayoutManager(SearchActivity.this));
        recyclerView.setAdapter(myRecAdapter);
        // Item Spacing
        int spacingInPixels = getResources().getDimensionPixelSize(R.dimen.margin_cardview);
        recyclerView.addItemDecoration(new SpacesItemDecoration(spacingInPixels));
    }
    @Override
    public boolean onQueryTextSubmit(String query) {
        return false;
    }
    @Override
    public boolean onQueryTextChange(String newText) {
        // Search Filter
        final List<Users> filteredModelList = filter(list, newText);
        if (filteredModelList.size() > 0) {
            myRecAdapter.setFilter(filteredModelList);
            return true;
        } else {
            // If not matching search filter data
            Toast.makeText(SearchActivity.this, "Taki użytkownik nie istnieje", Toast.LENGTH_SHORT).show();
            return false;
        }
    }

    public class RecyclerviewAdapter extends RecyclerView.Adapter<RecyclerviewAdapter.VH> {

        public List<Users> DataList;
        public Context context;
        ArrayList<Users> mModel;

        public RecyclerviewAdapter(List<Users> parkingList, Context context) {
            this.DataList = parkingList;
            this.context = context;
        }

        @Override
        public RecyclerviewAdapter.VH onCreateViewHolder(ViewGroup parent, int viewType) {
            return new RecyclerviewAdapter.VH(LayoutInflater.from(parent.getContext()).inflate(R.layout.recyclerview_item, parent, false));
        }

        @Override
        public void onBindViewHolder(RecyclerviewAdapter.VH holder, int position) {

            holder.htxt.setText(DataList.get(position).getName());
            holder.dtxt.setText(DataList.get(position).getEmail());

            Users txt = DataList.get(position);
            String name = txt.getName().toLowerCase(Locale.getDefault());
            // logic of highlighted text
            if (name.contains(searchString)) {

                int startPos = name.indexOf(searchString);
                int endPos = startPos + searchString.length();

                Spannable spanString = Spannable.Factory.getInstance().newSpannable(holder.htxt.getText());
                spanString.setSpan(new ForegroundColorSpan(Color.RED), startPos, endPos, Spannable.SPAN_EXCLUSIVE_EXCLUSIVE);
                // red color of matching text

                holder.htxt.setText(spanString);
            }
        }

        @Override
        public int getItemCount() {
            return DataList.size();
        }

        public class VH extends RecyclerView.ViewHolder {
            TextView htxt,dtxt;

            public VH(View itemView) {
                super(itemView);

                htxt = (TextView) itemView.findViewById(R.id.textView);
                dtxt = (TextView) itemView.findViewById(R.id.textView2);

                itemView.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {

                        String name = htxt.getText().toString();
                        Users userToSend;
                      /*  ArrayList<Users> usersList = GlobalValue.getUsersListGlobal();
                        for(int i = 0; i < usersList.size(); i++){
                            String userName = usersList.get(i).getName();
                            if(name.equals(userName))
                            {
                                userToSend = usersList.get(i);
                                Log.d("users ", i + " " + userToSend.getName());
                                Log.d("users1", usersList.get(i).getCert());
                                Log.d("users2", userToSend.getCert());
                                GlobalValue.setUserSend(userToSend);
                            }
                        }*/
                        for(Users u : GlobalValue.getUsersListGlobal()){
                            if(name.equals(u.getName())) {
                                userToSend = u;
                                GlobalValue.setUserSend(userToSend);

                            }
                        }
                        Intent intent = new Intent(context, OutboxActivity.class);
                        context.startActivity(intent);

                    }
                });
            }

        }

        public void setFilter(List<Users> countryModels) {
            mModel = new ArrayList<>();
            mModel.addAll(countryModels);
            notifyDataSetChanged();
        }

    }


    // Search Method
    private List<Users> filter(List<Users> models, String query) {

        query = query.toLowerCase();
        this.searchString=query;

        final List<Users> filteredModelList = new ArrayList<>();
        for (Users model : models) {
            final String text = model.getName().toLowerCase();
            if (text.contains(query)) {
                filteredModelList.add(model);
            }
        }
        myRecAdapter = new RecyclerviewAdapter(filteredModelList, SearchActivity.this);
        recyclerView.setLayoutManager(new LinearLayoutManager(SearchActivity.this));
        recyclerView.setAdapter(myRecAdapter);
        myRecAdapter.notifyDataSetChanged();

        return filteredModelList;
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu, menu);

        MenuItem searchitem = menu.findItem(R.id.action_search);
        SearchView searchView = (SearchView) MenuItemCompat.getActionView(searchitem);
        SearchManager searchManager = (SearchManager) getSystemService(SEARCH_SERVICE);
        searchView.setSearchableInfo(searchManager.getSearchableInfo(getComponentName()));

        TextView searchText = (TextView)
                searchView.findViewById(android.support.v7.appcompat.R.id.search_src_text);

        searchText.setTextColor(Color.parseColor("#FFFFFF"));
        searchText.setHintTextColor(Color.parseColor("#FFFFFF"));
        searchText.setHint("Szukaj użytkownika");
        searchView.setOnQueryTextListener(this);

        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        return super.onOptionsItemSelected(item);
    }



}
