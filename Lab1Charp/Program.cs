class Program
{
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
        int choice = int.Parse(Console.ReadLine());

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
        double a = double.Parse(Console.ReadLine());

        double side = a / 4;
        double area = side * side;

        Console.WriteLine($"Площа квадрата: {area}");
    }

    static void Task2()
    {
        Console.Write("Введіть перше число: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double b = double.Parse(Console.ReadLine());

        double max = (a > b) ? a : b;

        Console.WriteLine($"Максимальне значення: {max}");
    }

    static void Task3()
    {
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введіть y: ");
        double y = double.Parse(Console.ReadLine());

        double dist = x * x + y * y;
        double r2 = 12.0 * 12.0;

        bool onBoundary = (Math.Abs(dist - r2) < 1e-9 && x >= 0 && y <= x) ||
                          (dist <= r2 && Math.Abs(x) < 1e-9 && y <= 0) ||
                          (dist <= r2 && Math.Abs(y - x) < 1e-9 && x >= 0);

        bool inside = dist < r2 && x > 0 && y < x;

        if (onBoundary)
            Console.WriteLine("На межі");
        else if (inside)
            Console.WriteLine("Так");
        else
            Console.WriteLine("Ні");
    }

    static void Task4()
    {
        Console.Write("Введіть номер місяця (1-12): ");
        int month = int.Parse(Console.ReadLine());

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Невірний номер місяця!");
            return;
        }

        int remaining = 12 - month;
        Console.WriteLine($"Місяців до кінця року: {remaining}");
    }

    static int Sum(int a, int b)
    {
        return a + b;
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

        double result = a + (a + b - 1) / (a * a + 1) - a * b;

        Console.WriteLine($"Результат: {result}");
    }
}
