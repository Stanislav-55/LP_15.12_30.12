/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/
int[] array = CreateArrayRndInt(5, 1, 99);
PrintArray(array);
int subtraction = Subtraction(array);
Console.WriteLine($"разницу между максимальным и минимальным элементов массива 1 в массиве = {subtraction} ");

double[] array2 = CreateArrayRndDouble(7, 1, 99);
PrintArrayDouble(array2);
double subtractionDouble = SubtractionDouble(array2);
Console.WriteLine($"разницу между максимальным и минимальным элементов массива 2 в массиве = {subtractionDouble} ");



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ";");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int Subtraction(int[] arr)
{
    int max = arr[0];
    int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];

    }
    int resylt = max - min;
    return resylt;
}

double[] CreateArrayRndDouble(int size1, int min1, int max1)
{
    double[] arr1 = new double[size1];
    Random rnd = new Random();
    for (int i = 0; i < arr1.Length; i++)
    {
        double num = rnd.NextDouble() * (max1 - min1) + min1;
        arr1[i] = Math.Round(num, 1);
    }
    return arr1;
}

void PrintArrayDouble(double[] arr1)
{
    Console.Write("[");
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i < arr1.Length - 1) Console.Write(arr1[i] + ";");
        else
            Console.Write(arr1[i]);

    }

    Console.WriteLine("]");
}

double SubtractionDouble(double[] arr1)
{
    double max = arr1[0];
    double min = arr1[0];

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] > max) max = arr1[i];
        if (arr1[i] < min) min = arr1[i];

    }
    double resylt = max - min;
    resylt = Math.Round(resylt, 1);
    return resylt;
}


