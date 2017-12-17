package com.example.dawid.mobileapp;

/**
 * Created by Dawid on 04.12.2017.
 */

public class Users {
    String name, email;
    Integer UserID;
    String Cert;

    public String getCertID() {
        return CertID;
    }

    public void setCertID(String certID) {
        CertID = certID;
    }

    String CertID;
    public Users(String name, String email, Integer UserID, String Cert)
    {
        this.UserID = UserID;
        this.name = name;
        this.Cert = Cert;
        this.email = email;
    }
    public Users(String name, String email, Integer UserID)
    {
        this.UserID = UserID;
        this.name = name;

        this.email = email;
    }


    public String getCert() {
        return Cert;
    }

    public void setCert(String cert) {
        Cert = cert;
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
