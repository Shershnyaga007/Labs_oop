namespace Lab9;

public class Program
{

    private static StreamReader sr = new StreamReader("./Inlet.txt");
    private static StreamWriter sw = new StreamWriter("'./Outlet.txt");
    
    public static void Main(string[] args)
    {
        string[] words = sr.ReadToEnd().Split(" ");
        
        sr.Close();
        
        IEnumerable<string> filteredWords = words.Where((word, i) => i % 2 == 0)
            .Select((word, i) => i % 2 == 0 ? word : new string(word.Reverse().ToArray()));

        if (!filteredWords.Any())
        {
            sw.WriteLine("Empty");
        }

        foreach (string filteredWord in filteredWords)
        {
            sw.Write($"{filteredWord} ");
        }

        sw.Close();
    }
}