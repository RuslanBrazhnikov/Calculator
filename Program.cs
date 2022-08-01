internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Пожалуйста введите число");
        string str = Console.ReadLine();
        int x = Int32.Parse(str);

        Console.WriteLine("Пожалуйста введите число");
        str = Console.ReadLine();
        int y = Int32.Parse(str);

       


        Console.WriteLine(String.Format("разность двух чисел: {0}", x - y));

        Console.WriteLine(String.Format("Произведение двуз чисел {0}", x * y));

        Console.WriteLine($"Отношение двуч чисел равно {x / y}");

        int max = 0;
        if(x > y)
        {
            max = x;
        
        }
        else
        {
            max = y;
        }
        Console.WriteLine($"Ьаксимум двух чисел равен {max}");

        int min = 0;
        if(x < y)
        {
            min = x;
        }
        else
            min = y;
        Console.WriteLine($"Минимум двух чисел равен {min}");
    }
}

