namespace Lab4
{
    class B<T>
    {
        private T[] array = new T[0];
        public T this[int arrayIndex]
        {
            get { return array[arrayIndex]; }
            set { array[arrayIndex] = value; }
        }

        private int[] array1 = {1, 2, 3, 4, 5};
        public int this[string arrayIndex]
        {
            get => array1[int.Parse(arrayIndex)];
        }
    }

    class C<T>
    {
        public static String variable = "Nikita, buy The ban Hammer!";
    }

    class Program
    {
        public void Main(String[] args) 
        {
            B<String> b = new B<String>();

            for (int i = 0; i < 10; i++)
            {
                b[i] = i.ToString();
                Console.WriteLine("B1: " + b[i]);
            }

            Console.WriteLine("=-----=");

            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine(b[$"{i}"]);
            }

            Console.WriteLine("=-----=");

            Console.WriteLine(C<int>.variable);
        }
    }
}