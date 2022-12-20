/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно   */
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int res = Multiplicity(numberA, numberB);
Console.WriteLine(res ==0 ? "Кратно" : $"не кратно, остаток от деления {res}");
int Multiplicity(int numA, int numB)
{
    return numA % numB;
}










/*
bool result = numberA % numberB ==0;

if (result)
{
    Console.Write($"{numberA} является кратным {numberB} ");

}
else
{    
    Console.Write($"{numberA} не кратно {numberB}, остаток {numberA % numberB} ");
}


*/