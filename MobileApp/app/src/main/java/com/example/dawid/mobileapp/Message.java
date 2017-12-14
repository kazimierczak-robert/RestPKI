package com.example.dawid.mobileapp;

/**
 * Created by Dawid on 19.11.2017.
 */

public class Message {
    private Integer ID;
    private String User;
    private String Date;
    private String Topic;
    private String Content;

    public Message(){

    }

    public Message(Integer ID, String User, String Topic, String Content, String Date){
        this.ID = ID;
        this.User = User;
        this.Date = Date;
        this.Topic = Topic;

        this.Content = Content;
    }
    public Integer getID() {
        return ID;
    }

    public void setID(Integer ID) {
        this.ID = ID;
    }

    public String getUser() {
        return User;
    }

    public void setUser(String user) {
        User = user;
    }


    public String getDate() {
        return Date;
    }

    public void setDate(String date) {
        Date = date;
    }



    public String getTopic() {
        return Topic;
    }

    public void setTopic(String topic) {
        Topic = topic;
    }

    public String getContent() {
        return Content;
    }

    public void setContent(String content) {
        Content = content;
    }



}
