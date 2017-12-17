package com.example.dawid.mobileapp;

/**
 * Created by Dawid on 17.12.2017.
 */

public class PrivateKeyObject {
    String ID;

    public PrivateKeyObject(String ID, String certyficate) {
        this.ID = ID;
        Certyficate = certyficate;
    }

    public String getID() {
        return ID;
    }

    public void setID(String ID) {
        this.ID = ID;
    }

    public String getCertyficate() {
        return Certyficate;
    }

    public void setCertyficate(String certyficate) {
        Certyficate = certyficate;
    }

    String Certyficate;
}
