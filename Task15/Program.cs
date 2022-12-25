/*Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите дату: "); 
int number = Convert.ToInt32(Console.ReadLine());  


if (number == 1)
{
    Console.WriteLine($"{number} -> Нет");
}
else if (number == 2)
{
    Console.WriteLine($"{number} -> Нет");
}
else if (number == 3)
{
    Console.WriteLine($"{number} -> Нет");
}
else if (number == 4)
{
    Console.WriteLine($"{number} -> Нет");
}
else if (number == 5)
{
    Console.WriteLine($"{number} -> Нет");
}
else if (number == 6)
{
    Console.WriteLine($"{number} ->Да");
}
else if (number == 7)
{
    Console.WriteLine($"{number} -> Да");
}
else
{
    Console.WriteLine("Введите корректно данные");
}