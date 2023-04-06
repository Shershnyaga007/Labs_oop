package org.example;


import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Random;

public class Main {
    public static void main(String[] args) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Random random = new Random();

        System.out.print("Enter name: ");
        String name = reader.readLine();
        System.out.print("Enter lastName: ");
        String lastName = reader.readLine();
        System.out.print("Enter age: ");
        int age = Integer.parseInt(reader.readLine());
        boolean isMaks = random.nextBoolean();
        System.out.print("Enter peopleInfo: ");
        String peopleInfo = reader.readLine();

        People people = new People(name, lastName, age, isMaks, peopleInfo);

        System.out.println("Name " + people.getName());
        System.out.println("lastName " + people.getLastName());
        System.out.println("is Maks? " + people.isMaksMikhnovec());

        System.out.println("Today " + people.getName() + "is " + people.getAge());
        people.geburstag();
        System.out.println("Today " + people.getName() + "is " + people.getAge());
    }
}