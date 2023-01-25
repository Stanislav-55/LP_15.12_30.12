/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/
int[] array = CreateArray(8);
PrintArray(array);
int min=8;
int max=0;

int[] CreateArray(int size,int min,int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(mn, mx);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}," + " " );

        if (i == arr.Length - 1) ;
        {
            Console.Write($"{arr[i]}");
        }


    }
}