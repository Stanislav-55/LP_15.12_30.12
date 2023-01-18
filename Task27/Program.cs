/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12  */


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countNumbers = CountNumbers(number);

Summa(number);

Console.WriteLine($"{number} -> {Summa(number)}");


int CountNumbers(int digit)
{
    int count = 0;

    while (digit != 0)
    {
        digit = digit / 10;
        count = count + 1;
    }
    return count;
}
int Summa(int num)
{
    if (num < number) return 1;
    else
    {
        int sum = 0;
        for (int i = 0; i < countNumbers; i++)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }
}
