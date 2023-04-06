package org.example.Lab3;

public class Lab3 {
    public static void main(String[] args) {
        B b = new B(1, 5, 8);
        b.c2();

        float[] array = B.getArray();

        for (float i: array) {
            System.out.print(i + ", ");
        }
    }
}
