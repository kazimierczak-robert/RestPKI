package com.example.dawid.mobileapp;

/**
 * Created by Dawid on 04.12.2017.
 */

public class Users {
    String name, email;
    Integer UserID;

    public Users(String name, String email, Integer UserID)
    {
        this.UserID = UserID;
        this.name = name;

        this.email = email;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public Integer getID() {
        return UserID;
    }

    public void setID(Integer UserID) {
        this.UserID = UserID;
    }




}
