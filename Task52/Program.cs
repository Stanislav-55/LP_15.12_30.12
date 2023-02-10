/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ";");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double[] CreateArrayDouble(int[,] arr)
{
    int n = arr.GetLength(1);
    int m = arr.GetLength(0);
    double result = 0;
    double[] arr1 = new double[n];
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
            result = result + arr[i, j];
        double average = result / m;

        arr1[j] = Math.Round(average, 1);
    }
    return arr1;
}


int[,] array2D = CreateMatrixRndInt(3, 4, -99, 99);
PrintMatrix(array2D);
Console.WriteLine(string.Empty);
double[] createArrayDouble = CreateArrayDouble(array2D);
PrintArray(createArrayDouble);
Console.WriteLine($"Среднее арифметическое каждого столбца {a}");