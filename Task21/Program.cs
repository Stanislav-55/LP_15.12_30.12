﻿/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
√ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2
*/

Console.WriteLine("Введите координаты точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double ourDistans = Math.Round(Distans(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);                 // извлечение квадрата
Console.WriteLine($"Distance betveen segments with coordinates{x1} , {x2} ; {y1} , {y2} ; {z1} , {z2} is {ourDistans}.");
//double numRound = Math.Round(ourDistans, 2, MidpointRounding.ToZero);  округление до 2х нулей после запятой

double Distans(int xa, int ya, int za, int xb, int yb, int zb)
{
    double distans = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));         // возведение в степень (число, степень)

    return distans;
}