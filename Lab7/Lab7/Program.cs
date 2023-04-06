namespace Lab7;

class Vector
{
    public List<int> elements = new List<int>();

    public Vector()
    {
        
    }
    
    public Vector(int a, int b, int n)
    {
        int f1 = a;
        int f2 = b;
        int f;
        
        elements.Add(f1);
        elements.Add(f2);
        
        for (int i = 2; i < n; i++)
        {
            f = f1 + f2;
            elements[i] = f;
            f1 = f2;
            f2 = f;
        }
    }
    
    public void transformation(int i)
    {
        int minIndex = 0;
        for (int j = 1; j < elements.Count; j++)
        {
            if (Math.Abs(elements[j]) < Math.Abs(elements[minIndex]))
            {
                minIndex = j;
            }
        }
        (elements[i], elements[minIndex]) = (elements[minIndex], elements[i]);
    }
    
    public Vector filterByM(int M)
    {
        int count = 0;
        foreach (var t in elements)
        {
            if (Math.Abs(t) <= M)
            {
                count++;
            }
        }

        List<int> fElements = new List<int>();
        int index = 0;
        foreach (var t in elements)
        {
            if (Math.Abs(t) <= M)
            {
                fElements[index] = t;
                index++;
            }
        }

        Vector vector = new Vector();
        vector.elements = fElements;
        return vector;
    }
    
    public int Calculation(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < elements.Count; i++)
        {
            if ((elements[i] % 1 == 0) && (elements[i] % a == 0 || elements[i] % b == 0))
            {
                result *= elements[i];
            }
        }
        return result;
    }

    public int find()
    {
        int element = elements[0];

        for (int i = 1; i < elements.Count; i++)
            if (elements[i] > element)
                element = elements[i];

        return element;
    }
}

class Program
{
    private static int N, i, M, A, B;

    private static StreamReader sr = new StreamReader("./Inlet.txt");

    public static void Main(string[] args)
    {
        string[] nums = sr.ReadLine().Split(" ");

        N = int.Parse(nums[0]);
        i = int.Parse(nums[1]);
        M = int.Parse(nums[2]);
        A = int.Parse(nums[3]);
        B = int.Parse(nums[4]);

        List<Vector> vectors = new List<Vector>();

        while (!sr.EndOfStream)
        {
            string[] fibStr = sr.ReadLine().Split(" ");

            List<int> fib = new List<int>();
            foreach (string t in fibStr)
                fib.Add(int.Parse(t));

            Vector vector = new Vector(fib[0], fib[1], fib[2]);
            vectors.Add(vector);
        }
        
        Console.WriteLine("Преобразование: ");

        foreach (Vector vector in vectors)
        {
            vector.transformation(i);
            foreach (int t in vector.elements)
            {
                Console.Write($"{t} ");
            }
            Console.WriteLine("");
        }
        
        Console.WriteLine("");
        Console.WriteLine("Выделение/построение: ");
        
        foreach (Vector vector in vectors)
        {
            Vector v = vector.filterByM(i);
            foreach (int t in v.elements)
            {
                Console.Write($"{t} ");
            }
            Console.WriteLine("");
        }
        
        Console.WriteLine("");
        Console.WriteLine("Расчет: ");
        
        foreach (Vector vector in vectors)
        {
            int c = vector.Calculation(A, B);
            Console.Write($"{c} ");
        }
        
        Console.WriteLine("");
        Console.WriteLine("Поиск: ");
        
        foreach (Vector vector in vectors)
        {
            int c = vector.find();
            Console.Write($"{c} ");
        }
    }
}

