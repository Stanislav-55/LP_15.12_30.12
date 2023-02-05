/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double intersectionPointX=IntersectionPointX(k1,b1,k2,b2);
double intersectionPointY=IntersectionPointY(k1,b1,k2,b2);
Console.WriteLine($"Пересечение в точке: ({intersectionPointX};{intersectionPointY})");

double IntersectionPointX(double numk1, double numb1, double numk2, double numb2)
{
    double x = (numb2 - numb1) / (numk1 - numk2);

    x = Math.Round(x, 2);

    return x;

}

double IntersectionPointY(double nuk1, double nub1, double nuk2, double nub2)
{
    double y = nuk1 * ((nub2 - nub1) / (nuk1 - nuk2)) + nub1;
    y = Math.Round(y, 2);

    return  y;

}
