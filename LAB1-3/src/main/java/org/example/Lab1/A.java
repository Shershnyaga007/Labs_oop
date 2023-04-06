package org.example.Lab1;

public class A {
    private int a;
    private int b;

    public void setA(int a) {
        this.a = a;
    }

    public A() {

    }

    public void setB(int b) {
        this.b = b;
    }
    public void c() {
        System.out.println("a % b: " + this.a % this.b);
        System.out.println("a + b: " + (this.a + this.b));
    }
}
