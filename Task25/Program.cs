/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
Console.WriteLine("Введите число: A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: B ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0)
{
    int degree = Degree(numberA, numberB);
    Console.WriteLine($"{numberA}, {numberB} -> {degree}");
}
else
{
    Console.WriteLine("ВВедите коректно число:B");
}


int Degree(int numA, int numB)
{
    int degr = 1 ;
    int count = 0;

    while (count < numB)
    {
        degr = degr * numA;
        count = count + 1;
    }
    return degr;
}
