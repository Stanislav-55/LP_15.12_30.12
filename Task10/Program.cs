/*
Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */


Console.WriteLine("ВВедите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degit(number) > 99 && Degit(number) < 1000 ? $"{second}" : "Введите корректное число");

int Degit(int num)
{
    int second = (num / 10) % 10;
    return second;
}
/*
if (number < 1000 && number > 99) 

{
   int secondDigit = (number / 10) % 10;
    Console.WriteLine($"{secondDigit}");
}
else
Console.WriteLine("Введите корректное число");
*/
