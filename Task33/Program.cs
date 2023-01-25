/*Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/
int[] array = CreateArrayRndInt(12, -9, 100);
PrintArray(array);
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());



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
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
bool FindNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
{
if (arr[i] == num)
return true;
}
return false;
}

bool findNumber = FindNumber(array, number);
if (findNumber)
{
    Console.WriteLine($"число {number} есть в массиве -");
    PrintArray(array);
}
else
{
    Console.WriteLine($"числа {number} нет в массиве -");
    PrintArray(array);
}
