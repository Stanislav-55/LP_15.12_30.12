/* 14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да  
? - тогда
: - иначе                  */

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 7;
int numberC = 23;

Console.WriteLine(Multiplicity(numberA, numberB, numberC) ? $"{numberA} -> да" : $"{numberA} -> нет");

bool Multiplicity(int numA, int numB, int numC)
{
     return numA % numB == 0 && numA % numC == 0;
} 

/*
if (numberA % numberB == 0 && numberA % numberC == 0) 
{
    Console.WriteLine($"{numberA} -> да");
}

else Console.WriteLine($"{numberA} -> нет");*/

