package org.example.Lab3;

public class B extends A {
    private final int d;
    private static float[] array;


    public B(int a, int b, int d) {
        super(a, b);
        this.d = d;
        array = new float[a];
    }

    public B(int a, int d) {
        this.d = d;
        array = new float[a];
    }

    public void c2() {
        for (int i=0; i < array.length; i++) {
            array[i] = (this.getA() + this.getB() + this.d) / i;
        }
    }

    public static float[] getArray() {
        return array;
    }
}
