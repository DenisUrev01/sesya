using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите числа через запятую: ");
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(',');
        int count = 0;

        foreach (string numStr in numberStrings)
        {
            if (int.TryParse(numStr, out int number) && number > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел больше 0: {count}");
    }
}

