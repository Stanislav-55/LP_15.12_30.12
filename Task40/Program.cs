/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/
Console.WriteLine("Введите число: A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: B ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: C ");
int numberC = Convert.ToInt32(Console.ReadLine());
bool result = IsExistTriengl(numberA, numberB, numberC);
Console.WriteLine(result?"Такой треугольник существует":"Такого треугольника не существует");

bool IsExistTriengl(int numA, int numB, int numC)    //этот метод возвращает да или нет
{
    if (numA < numB + numC &&
    numB < numA + numC &&
    numC < numA + numB
        )
        return true;
    else
        return false;


}