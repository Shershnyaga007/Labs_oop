namespace Lab10;

class Program
{
    private static StreamReader sr = new StreamReader("./Inlet.txt");
    private static StreamWriter sw = new StreamWriter("./Outlet.txt");

    private static Dictionary<int, int> repeat = new Dictionary<int, int>();

    public static void Main(string[] args)
    {
        string[] numsStr = sr.ReadToEnd().Split(" ");

        sr.Close();
        
        List<int> nums = new List<int>();
        
        foreach (string i in numsStr)
            nums.Add(int.Parse(i));

        foreach (int i in nums)
        {
            if (repeat.ContainsKey(i))
            {
                repeat.Add(i, 1);
            }
            else
            {
                int count = repeat[i] + 1;
                repeat.Remove(i);
                repeat.Add(i, count);
            }
        }

        List<int> nn = new List<int>();
        int max = 0;

        foreach (var i in repeat)
        {
            if (i.Value == max)
            {
                nn.Add(i.Key);
            }
            else if (i.Value > max)
            {
                nn.Clear();
                max = i.Value;
                nn.Add(i.Key);
            }
        }

        foreach (int i in nn)
        {
            sw.Write($"{i} ");
        }
        
        sw.Close();
    }
}
