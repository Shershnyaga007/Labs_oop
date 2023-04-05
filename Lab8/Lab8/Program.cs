namespace Lab8
{
    class Program
    {
        public static StreamReader sr = new StreamReader("./Inlet.txt");
        public static StreamWriter sw = new StreamWriter("./Outlet.txt");

        public static int K;

        public static List<int> Elements = new List<int>();
        
        public static void Main(string[] args)
        {
            K = Int32.Parse(sr.ReadLine());

            while (!sr.EndOfStream)
            {
                string[] elem = sr.ReadLine().Split(' ');
        
                foreach (string i in elem)
                {
                    Elements.Add(Int32.Parse(i));
                }
            }
            
            sr.Close();

            
            for (int i = Elements.Count - 1; i >= 0; i--)
            {
                if (Elements[i] % K == 0)
                {
                    Elements.Insert(i + 1, Elements[0]);
                }
            }
            
            foreach (var element in Elements)
            {
                sw.WriteLine(element);
            }

            sw.Close();
        }
    }
}