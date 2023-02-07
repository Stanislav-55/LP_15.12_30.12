/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1,7 -> такого элемента в массиве нет
*/
Console.Write("Введите положительное число - позицию элемента по строке: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число - позицию элемента по столбцу: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int rows = 6;
int columns = 7;

if (numberA > 0 | rows >= numberA
 && numberB > 0 | columns >= numberB)
{
    int[,] array2D = CreateMatrixRndInt(rows, columns, -99, 99, numberA, numberB);
    PrintMatrix(array2D);
    Console.WriteLine($"Значение элемента по строке {numberA}, столбцу {numberB} = {array2D[numberA - 1, numberB - 1]}");
}
else
    Console.WriteLine("Такого элемента в массиве нет");


int[,] CreateMatrixRndInt(int rowsA, int columnsA, int min, int max, int numA, int numB)
{
    int[,] matrix = new int[rowsA, columnsA];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

