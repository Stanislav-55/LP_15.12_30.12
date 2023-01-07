/*Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.*/


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number>0)
{
    TableSquare(number);
}
else  Console.WriteLine("данное число не натуральное");

void TableSquare (int num)
{int count = 1;
while (count <= num)
{
   double square =Math.Pow(count, 2);
    Console.WriteLine($"{count,4} {square,4} ");    //    \t - длинный отступ      ,4- отступ от края 

 count++;
}
}

