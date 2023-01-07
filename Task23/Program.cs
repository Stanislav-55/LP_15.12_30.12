/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125*/


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
   double square =Math.Pow(count, 3);
    Console.WriteLine($"{count,8}   | {square,4} ");    //    \t - длинный отступ      ,4- отступ от края 

 count++;
}
}