/*
Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N. Факториал сисла N.
4 -> 24
5 -> 120 
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int factorialNumbers = FactorialNumbers(number);
    Console.WriteLine($"Факториал числа {number} = {factorialNumbers}");
}
else
{
    Console.WriteLine($"введите коректное число");
}


int FactorialNumbers(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // данный блок позволяет вывести ошибку если превысит, переполнит лимит.
        {
        factorial*=i;     //sum = sum * i;
        }
    }
    return factorial;
}