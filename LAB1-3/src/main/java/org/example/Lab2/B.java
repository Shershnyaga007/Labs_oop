package org.example.Lab2;

public class B extends A {
    private final int d;


    public B(int a, int b, int d) {
        super(a, b);
        this.d = d;
    }

    public B(int d) {
        this.d = d;
    }

    public void c2() {
        if (this.d > this.c()) {
            System.out.println("Pass");
        }
        else {
            System.out.println("Deny");
        }
    }
}
