package com.example.dawid.mobileapp;

/**
 * Created by Dawid on 04.12.2017.
 */

public class Users {
    String name, email;
    Integer ID;

    public Users(Integer ID, String name, String email)
    {
        this.ID = ID;
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
        return ID;
    }

    public void setID(Integer ID) {
        this.ID = ID;
    }




}
