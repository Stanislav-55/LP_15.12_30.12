/*
Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6   */



Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} -> третьей цифры нет");
while (number < 1000)
{
    if (number > 99)
    {
        int thirdDigit = number % 10;
        break; 
        Console.WriteLine($"{number}-> {thirdDigit}");
    }
    break;
     Console.WriteLine($"{number}-> третьей цифры нет");
}


