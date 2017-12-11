package com.example.dawid.mobileapp;

/**
 * Created by Dawid on 09.12.2017.
 */

public class ReasonOverturn {
    private int ID;
    private String descripiton;

    public ReasonOverturn(int ID, String descripiton)
    {
        this.ID = ID;
        this.descripiton = descripiton;
    }

    public int getID() {
        return ID;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public String getDescripiton() {
        return descripiton;
    }

    public void setDescripiton(String descripiton) {
        this.descripiton = descripiton;
    }

}
