namespace Lab5
{
    class B
    {
        private bool Val;

        public B(bool val)
        {
            this.Val = val;
        }

        public static bool operator true(B b)
        {
            return !b.Val;
        }

        public static bool operator false(B b)
        {
            return b.Val;
        }

        public static B operator !(B b)
        {
            return new B(b.Val);
        }

        public void Print()
        {
            Console.WriteLine(this.Val);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            B b1 = new B(false);

            if (b1)
            {
                Console.WriteLine("True");
            }

            b1 = !b1;

            if (b1)
            {
                Console.WriteLine("True");
            }
        }
    }

}