// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = -3 b = 9 -> нет
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int square = numberB * numberB;
    if (square == numberA)
    {
        Console.WriteLine($"Квадратом числа {numberB} является число {numberA}");
    }
    else
    {
        Console.WriteLine($"Квадратом числа {numberB} не является число {numberA}");
    }

