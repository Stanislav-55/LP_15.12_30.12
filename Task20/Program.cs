/*Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/


Console.WriteLine("Введите координаты точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double ourDistans = Math.Round(Distans(x1, y1, x2, y2), 2, MidpointRounding.ToZero);                 // извлечение квадрата
Console.WriteLine($"Distance betveen segments with coordinates{x1} , {x2} and {y1} , {y2} is {ourDistans}.");
//double numRound = Math.Round(ourDistans, 2, MidpointRounding.ToZero);  округление до 2х нулей после запятой

double Distans(int xa, int ya, int xb, int yb)
{
    double distans = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));         // возведение в степень (число, степень)

    return distans;
}


