int[] array = CreateArrayRndInt(5, 1, 99);
PrintArray(array);
int subtraction=Subtraction(array);


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

int Subtraction(int[] arr)
{
    int max = arr[0];
    int min = arr[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];

    }
    int resylt = max - min;
    return resylt;
}
Console.WriteLine($"разницу между максимальным и минимальным элементов массива 1 в массиве = {subtraction} ");