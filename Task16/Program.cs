/*
16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(numberA, numberB) ? $"{numberA} -> да" : $"{numberA} -> нет");

bool Square(int numA, int numB)
{
    return numA * numA == numB || numB * numB == numA;
}


/*

if (numberA % numberB == 0 || numberB % numberA == 0)

{
    Console.WriteLine($"{numberA},{numberB} -> yes");
}
else Console.WriteLine($"{numberA},{numberB} -> no");*/