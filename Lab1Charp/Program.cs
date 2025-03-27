using System;
class Program
{
    static void Main()
    {
        // Завдання 1: Площа квадрата
        Console.Write("Введіть периметр квадрата (a): ");
        double perimeter = Convert.ToDouble(Console.ReadLine());
        double side = perimeter / 4;
        double area = side * side;
        Console.WriteLine($"Площа квадрата: {area}");

        // Завдання 2: Максимальне значення з двох чисел
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double max = Math.Max(num1, num2);
        Console.WriteLine($"Максимальне число: {max}");

        // Завдання 3: Перевірка точки в заштрихованій області
        Console.Write("Введіть координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        string result = CheckPoint(x, y);
        Console.WriteLine($"Результат: {result}");

        // Завдання 4: Місяці до кінця року
        Console.Write("Введіть порядковий номер місяця (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        int monthsLeft = 12 - month;
        Console.WriteLine($"Кількість місяців до кінця року: {monthsLeft}");

        // Завдання 5: Функція суми двох цілих чисел
        Console.Write("Введіть перше ціле число: ");
        int int1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть друге ціле число: ");
        int int2 = Convert.ToInt32(Console.ReadLine());
        int sum = Sum(int1, int2);
        Console.WriteLine($"Сума чисел: {sum}");

        // Завдання 6: Обчислення виразу
        Console.Write("Введіть значення a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть значення b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double expressionResult = CalculateExpression(a, b);
        Console.WriteLine($"Значення виразу: {expressionResult}");
        Console.WriteLine("Press any key to escape...");
        Console.ReadLine();
    }

    // Функція для обчислення суми двох цілих чисел
    static int Sum(int a, int b){return a + b;}

    // Функція для перевірки положення точки
    static string CheckPoint(double x, double y)
    {
        double radius = 12; // Радіус кола
        double distanceSquared = x * x + y * y; // Відстань від точки до початку координат у квадраті

        bool onCircle = Math.Abs(distanceSquared - radius * radius) < 1e-6; // Перевірка чи точка на колі
        bool onLine = Math.Abs(y - x) < 1e-6; // Перевірка чи точка на прямій y = x
        bool insideCircle = distanceSquared <= radius * radius; // Перевірка чи точка в межах кола
        bool belowLine = y <= x; // Перевірка чи точка під прямою y = x

        if (onCircle && belowLine){return "On Circle";}
        else if (onLine && insideCircle){return "On Line";}
        else if (insideCircle && belowLine){return "Inside";}
        else{return "Outside";}
    }

    // Функція для обчислення виразу a + (a + b - 1) / (a^2 + 1) - ab
    static double CalculateExpression(double a, double b)
    {
        return a + (a + b - 1) / (a * a + 1) - a * b;
    }
}
