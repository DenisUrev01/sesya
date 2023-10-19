using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение k2: ");
        double k2 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        double b2 = double.Parse(Console.ReadLine());

        // Находим x-координату точки пересечения
        double x = (b2 - b1) / (k1 - k2);

        // Вычисляем y-координату точки пересечения
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения: ({x}, {y})");
    }
}