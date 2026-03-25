using System;

public class Program
{
    public static double SquareArea(double perimeter)
    {
        double side = perimeter / 4;
        return side * side;
    }

    public static double Max(double a, double b)
    {
        return (a > b) ? a : b;
    }

    public static string PointInRegion(double x, double y)
    {
        double dist = x * x + y * y;
        double r2 = 12.0 * 12.0;

        bool onBoundary = (Math.Abs(dist - r2) < 1e-9 && x >= 0 && y <= x) ||
                          (dist <= r2 && Math.Abs(x) < 1e-9 && y <= 0) ||
                          (dist <= r2 && Math.Abs(y - x) < 1e-9 && x >= 0);
        bool inside = dist < r2 && x > 0 && y < x;

        if (onBoundary) return "На межі";
        if (inside)     return "Так";
        return "Ні";
    }

    public static int MonthsLeft(int month)
    {
        return 12 - month;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static double Expression(double a, double b)
    {
        return a + (a + b - 1) / (a * a + 1) - a * b;
    }

    static void Main()
    {
        Console.WriteLine("Оберіть завдання (1-6):");
        Console.WriteLine("1 - Площа квадрата");
        Console.WriteLine("2 - Максимум двох чисел");
        Console.WriteLine("3 - Точка в області");
        Console.WriteLine("4 - Місяці до кінця року");
        Console.WriteLine("5 - Сума двох чисел");
        Console.WriteLine("6 - Обчислення виразу");

        Console.Write("\nВаш вибір: ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Невірний формат числа!");
            return;
        }

        switch (choice)
        {
            case 1: Task1(); break;
            case 2: Task2(); break;
            case 3: Task3(); break;
            case 4: Task4(); break;
            case 5: Task5(); break;
            case 6: Task6(); break;
            default: Console.WriteLine("Невірний вибір!"); break;
        }
    }

    static void Task1()
    {
        Console.Write("Введіть периметр (a): ");
        if (double.TryParse(Console.ReadLine(), out double a))
            Console.WriteLine($"Площа квадрата: {SquareArea(a)}");
        else
            Console.WriteLine("Невірне введення!");
    }

    static void Task2()
    {
        Console.Write("Введіть перше число: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Максимальне значення: {Max(a, b)}");
    }

    static void Task3()
    {
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введіть y: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(PointInRegion(x, y));
    }

    static void Task4()
    {
        Console.Write("Введіть номер місяця (1-12): ");
        if (int.TryParse(Console.ReadLine(), out int month))
        {
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Невірний номер місяця!");
                return;
            }
            Console.WriteLine($"Місяців до кінця року: {MonthsLeft(month)}");
        }
        else
        {
            Console.WriteLine("Невірне введення!");
        }
    }

    static void Task5()
    {
        Console.Write("Введіть перше ціле число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введіть друге ціле число: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сума: {Sum(a, b)}");
    }

    static void Task6()
    {
        Console.Write("Введіть a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {Expression(a, b)}");
    }
}
