package com.example.dawid.mobileapp;

/**
 * Created by Dawid on 19.11.2017.
 */

public class Message {
    private String User;
    private String Date;
    private String Topic;
    private String Content;

    public Message(){

    }

    public Message(String User, String Date, String Topic, String Content){
        this.User = User;
        this.Date = Date;
        this.Topic = Topic;

        this.Content = Content;
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
