namespace Lab7
{

    struct Passager
    {
        public Int32 quantity;
        public Int32 mass;
    }
    
    class Program
    {
        
        public static StreamReader sr = new StreamReader("./Inlet.txt");
        public static StreamWriter sw = new StreamWriter("./Outlet.txt");
        public static Int32 K;
        
        public static List<Passager> Passagers= new List<Passager>();

        public static void Main(string[] args)
        {
            K = Int32.Parse(sr.ReadLine() ?? string.Empty);

            while (!sr.EndOfStream)
            {
                Passager passager = new Passager();
                passager.quantity = Int32.Parse(sr.ReadLine());
                passager.mass = Int32.Parse(sr.ReadLine());
                Passagers.Add(passager);
            }
            
            sr.Close();

            int one = 0;
            int two = 0;

            for (int i = 0; i < Passagers.Count; i++)
                for (int k = 0; k < Passagers.Count; k++)
                    if (k != i)
                    {
                        if (Passagers[i].quantity == Passagers[k].quantity && 
                            Math.Abs(Passagers[i].mass - Passagers[k].mass) < K)
                        {
                            one = i + 1;
                            two = k + 1;
                            
                        }
                    }

            if (one == 0)
            {
                sw.Write("-1");
            }
            else
            {
                sw.Write($"{one} {two}");
            }
            
            sw.Close();
        }
    }
}
