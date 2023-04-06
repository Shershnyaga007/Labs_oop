package org.example;

public class People {
    private String name;
    private String lastName;
    private int age;
    private boolean isMaksimMikhnovec;
    private String peopleInfo;

    public void geburstag() {
        this.age = this.age + 1;
    }

    public String isMaksMikhnovec() {
        if (isMaksimMikhnovec)
            return "JAJA";
        else
            return "Nein, it's " + this.name + " " + this.lastName;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getName() {
        return this.name;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }
    public String getLastName() {
        return this.lastName;
    }

    public void setAge(int age) {
        this.age = age;
    }
    public int getAge() {
        return this.age;
    }

    public void setMaksimMikhnovec(boolean maksimMikhnovec) {
        this.isMaksimMikhnovec = maksimMikhnovec;
    }
    public boolean getIsMaksimMikhnovec() {
        return this.isMaksimMikhnovec;
    }

    public void setPeopleInfo(String peopleInfo) {
        this.peopleInfo = peopleInfo;
    }
    public String getPeopleInfo() {
        return this.peopleInfo;
    }

    public People() {

    }

    public People(String name, String lastName, int age, boolean isMaksimMikhnovec, String peopleInfo) {
        this.name = name;
        this.lastName = lastName;
        this.age = age;
        this.isMaksimMikhnovec = isMaksimMikhnovec;
        this.peopleInfo = peopleInfo;
    }
}
