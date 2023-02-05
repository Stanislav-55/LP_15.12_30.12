/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
Console.Write("Введите числа через запятую: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
int sumNumbers=SumNunbers(array);
Console.WriteLine($"Кол-во элементов больше 0: {sumNumbers}");

int SumNunbers(int[]arr)
{
 int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]> 0)
            count++;
    }
    return count;
}