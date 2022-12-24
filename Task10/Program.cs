/*
Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */


Console.WriteLine("ВВедите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
Console.WriteLine($"({number}->{Degit(number)})");
}
else if(number < -99 && number > -1000)
{
    Console.WriteLine($"({number}->{Degit(-number)})");
}
else Console.WriteLine($"Введите корректное число");
 

int Degit(int num)
{
    return (num / 10) % 10;
        
}
/*
if (number < 1000 && number > 99) 

{
   int secondDigit = (number / 10) % 10;
    Console.WriteLine($"{secondDigit}");
}
else
Console.WriteLine("Введите корректное число");*/

