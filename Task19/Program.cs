/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет

12821 -> да

23432 -> да*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{

    Console.WriteLine(Multiplicity(number)? $"Число {number} является палиндромом" : "Данное число не является палиндромом");
}
else System.Console.WriteLine("введите корректное число");

bool Multiplicity(int num)
{
    return num % 10 == num / 10000 && (number % 100)/10 == (number / 1000)%10;
}

